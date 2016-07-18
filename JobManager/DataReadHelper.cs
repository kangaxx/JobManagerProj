using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRG_LinqLibrary;
using System.Data;
using System.Windows.Forms;

namespace JobManager
{




    class DataReadWriteHelper
    {
        private string _config;
        public DataReadWriteHelper(string configFile)
        {
            _config = configFile;
        }


        //读取数据刷新listview
        public void readData(ref ListView lv, string queryString)
        {
            try
            {
                using (HRG_DBFactory factory = new HRG_DBFactory(_config))
                {
                    lv.Clear();
                    HRG_IDataContext dc = factory.getDC();
                    IDataReader dr = dc.obj_Query(queryString);
                    if (dr == null)
                        return;
                    lv.View = View.Details;

                    while (dr.Read())
                    {
                        List<string> values = new List<string>();
                        for (int i = 0; i < dr.FieldCount; ++i)
                        {
                            if (lv.Columns.Count < dr.FieldCount)
                            {
                                lv.Columns.Add(dr.GetName(i), 120, HorizontalAlignment.Left);
                            }
                            values.Add(dr[i].ToString());

                        }
                        ListViewItem items = new ListViewItem(values.ToArray());
                        lv.Items.Add(items);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(String.Format("Error, {0}", e), "Error info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<T> readData<T>(string queryString) where T: new()
        {
            using (HRG_DBFactory factory = new HRG_DBFactory(_config))
            {
                Type type = typeof(T);
                List<T> result = new List<T>();
                HRG_IDataContext dc = factory.getDC();
                IDataReader dr = dc.obj_Query(queryString);
                while (dr.Read())
                {
                    T t = new T();
                    for (int i = 0; i < dr.FieldCount; ++i)
                    {
                        //values.Add(dr[i].ToString());
                        System.Reflection.PropertyInfo prop = type.GetProperty(dr.GetName(i).ToString());
                        if (prop != null)
                            prop.SetValue(t, dr.GetValue(i), null);
                    }
                    result.Add(t);

                }
                return result;
            }
        }

        public int updateData(string queryString)
        {
            using (HRG_DBFactory factory = new HRG_DBFactory(_config))
            {
                HRG_IDataContext dc = factory.getDC();
                return dc.Update(queryString);

            }
        }

        public int insertData(string queryString)
        {
            using (HRG_DBFactory factory = new HRG_DBFactory(_config))
            {
                HRG_IDataContext dc = factory.getDC();
                return dc.Insert(queryString);

            }
        }

        public int deleteData(string queryString)
        {
            using (HRG_DBFactory factory = new HRG_DBFactory(_config))
            {
                HRG_IDataContext dc = factory.getDC();
                return dc.Delete(queryString);

            }
        }

        public string callProc(string procName, string procArg)
        {
            using (HRG_DBFactory factory = new HRG_DBFactory(_config))
            {
                HRG_IDataContext dc = factory.getDC();
                return dc.QueryProc(procName, procArg);

            }
        }

    }
}
