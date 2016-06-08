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
    class DataReadHelper
    {
        private string _config;
        public DataReadHelper(string configFile)
        {
            _config = configFile;
        }

        public void ReadData(ref ListView lv, string queryString)
        {
            using (HRG_DBFactory factory = new HRG_DBFactory(_config))
            {
                HRG_IDataContext dc = factory.getDC();
                IDataReader dr = dc.obj_Query(queryString);
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


    }
}
