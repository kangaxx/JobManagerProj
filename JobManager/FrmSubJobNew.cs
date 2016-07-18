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



    public partial class FrmSubJobNew : Form
    {
        private bool _root = false;
        private int _parentId = -1;
        private int _jobId = -1;
        private string parentStepTextFmt = "上一个步骤名称:{0}, 说明：{1}";

        private List<PovInfo> _listPov;
        public FrmSubJobNew(bool root, int jobId, int parentId, string parentName, string parentText)
        {
            _root = root;
            _parentId = parentId;
            _jobId = jobId;
            InitializeComponent();
            showParentStepText(parentName, parentText);
            getPovList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //定制上一节步骤内容的展示
        private void showParentStepText(string name, string text)
        {
            if (_root)
            {
                lblParentStep.Text = "没有可以选择的上一个步骤，本步骤是当前任务的第一步";
            }
            else
                lblParentStep.Text = string.Format(parentStepTextFmt, name, text);
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
            string args = "[{'name':'@name','value':'" + txtStepName.Text + "','direct':'1'},{'name':'@text','value':'" + txtStepText.Text + "','direct':'1'}"
            + ",{'name':'@parentid','value':'" + _parentId.ToString() + "','direct':'1'} ,{'name':'@jobid','value':'" + _jobId.ToString() + "','direct':'1'}" 
            + ",{'name':'@type','value':'" + cbStepType.Text + "','direct':'1'},{'name':'@postid','value':'" + postId.ToString() + "','direct':'1'}]";

            drw.callProc("PROC_INSERT_SUB_JOB_LIST", args);
            this.Close();
        }
    }
}
