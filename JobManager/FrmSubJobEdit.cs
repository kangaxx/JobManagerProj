using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobManager
{
    public partial class FrmSubJobEdit : Form
    {
        private int _type = -1;
        private int _postId = -1;
        private int _id = -1;
        private string _name = "";
        private string _text = "";

        private List<PovInfo> _listPov;   //导航点信息集

        #region 基本功能
        public FrmSubJobEdit(int id, string name, string text, int type,int postId)
        {
            _type = type;
            _postId = postId;
            _id = id;
            _name = name;
            _text = text;

            InitializeComponent();
            getPovList();
            initialFormByOriData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //初始化界面
        private void initialFormByOriData()
        {
            this.txtStepName.Text = _name;
            this.txtStepText.Text = _text;
            this.cbStepType.SelectedIndex = this.cbStepType.FindString(_type.ToString());
            foreach (PovInfo info in _listPov)
            {
                if (info.ID == _postId)
                {
                    cbPostId.SelectedIndex = cbPostId.FindString(info.PlaceName);
                }
            }
        }

        //获取位置点列表信息
        private void getPovList()
        {
            DataReadWriteHelper drw = new DataReadWriteHelper(Global.config);
            _listPov = drw.readData<PovInfo>("select ID, PlaceName from Nav");
            if (_listPov != null && _listPov.Count > 0)
            {
                foreach (PovInfo t in _listPov)
                {
                    if (t.PlaceName != null && t.ID > 0)
                        cbPostId.Items.Add(t.PlaceName);

                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int postId = -1;
            if (cbPostId.SelectedIndex >= 0)
            {
                postId = (int)_listPov.ElementAt(cbPostId.SelectedIndex).ID;
            }
            DataReadWriteHelper drw = new DataReadWriteHelper(Global.config);
            string cmd = String.Format("update sub_job_list set SUB_JOB_NAME=\"{0}\", SUB_JOB_TEXT=\"{1}\", SUB_JOB_TYPE=\"{2}\", POST_ID=\"{3}\" where SUB_JOB_ID = {4}",
                                        txtStepName.Text, txtStepText.Text, cbStepType.Text,postId, _id);
            drw.updateData(cmd);

            this.Close();
        }
        #endregion



    }
}
