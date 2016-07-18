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
    public partial class frmMain : Form
    {
        enum FormStatus
        {
            FS_None = 1,
            FS_RowSelected = 2,
        }
        private int _checkIndex = -1;
        private int _checkJobShowerIndex = -1;
        private int _checkSubJobIndex = -1;
        #region 基本功能
        public frmMain()
        {
            InitializeComponent();
            refreshData();
        }

        //刷新业务信息数据，功能函数
        private void refreshData()
        {
            DataReadWriteHelper jobReader = new DataReadWriteHelper(Global.config);
            jobReader.readData(ref this.lvJob, "select * from job_list");
            jobReader.readData(ref this.lvJobShower, "select * from job_list");
            _checkIndex = -1;
            _checkJobShowerIndex = -1;
            _checkSubJobIndex = -1;
            lvSubJobList.Clear();
        }

        #endregion

        #region 业务管理
        //实现编辑功能
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_checkIndex >= 0 && _checkIndex < lvJob.Items.Count)
            {
                FrmJobEdit theEdit = new FrmJobEdit(lvJob.Items[_checkIndex].SubItems[0].Text, lvJob.Items[_checkIndex].SubItems[1].Text, lvJob.Items[_checkIndex].SubItems[2].Text,
                    lvJob.Items[_checkIndex].SubItems[3].Text, lvJob.Items[_checkIndex].SubItems[4].Text, lvJob.Items[_checkIndex].SubItems[5].Text);
                theEdit.ShowDialog();
                refreshData();
            }
        }

        //记录单选信息，完善记录单选功能必须
        private void lvJob_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                _checkIndex = e.Index;
                for (int i = 0; i < lvJob.Items.Count; ++i)
                {
                    if (i != _checkIndex)
                        lvJob.Items[i].Checked = false;
                }
            }
        }



        //新增业务信息
        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmJobNew newJob = new FrmJobNew();
            newJob.ShowDialog();
            refreshData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_checkIndex >= 0 && _checkIndex < lvJob.Items.Count)
            {
                DataReadWriteHelper jobReader = new DataReadWriteHelper(Global.config);
                jobReader.deleteData("delete from job_list where job_id = " + lvJob.Items[_checkIndex].SubItems[0].Text);
                refreshData();
            }
        }

        #endregion
        #region 业务步骤管理

        private void lvJobShower_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                _checkJobShowerIndex = e.Index;
                loadSubJobList(_checkJobShowerIndex);
                for (int i = 0; i < lvJobShower.Items.Count; ++i)
                {
                    if (i != _checkIndex)
                        lvJobShower.Items[i].Checked = false;
                }
            }
        }

        private void loadSubJobList(int idx)
        {
            DataReadWriteHelper jobReader = new DataReadWriteHelper(Global.config);
            _checkSubJobIndex = -1;
            jobReader.readData(ref this.lvSubJobList, "select * from sub_job_list where job_id = " + lvJobShower.Items[idx].SubItems[0].Text);
        }

        private void lvSubJobList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                _checkSubJobIndex = e.Index;
                for (int i = 0; i < lvSubJobList.Items.Count; ++i)
                {
                    if (i != _checkIndex)
                        lvSubJobList.Items[i].Checked = false;
                }
            }
        }

        //新增步骤
        private void btnSubJobNew_Click(object sender, EventArgs e)
        {
            if (!checkSubJobInfo())
            {
                MessageBox.Show("请先创建或勾选任务！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_checkSubJobIndex < 0) //root 步骤
            {
                FrmSubJobNew newSubJob = new FrmSubJobNew(true, Int32.Parse(lvJobShower.Items[_checkJobShowerIndex].SubItems[0].Text), -1, "", "");
                newSubJob.ShowDialog();
                refreshData();
            }
            else
            {
                FrmSubJobNew newSubJob = new FrmSubJobNew(false, Int32.Parse(lvJobShower.Items[_checkJobShowerIndex].SubItems[0].Text),
                    Int32.Parse(lvSubJobList.Items[_checkSubJobIndex].SubItems[0].Text),lvSubJobList.Items[_checkSubJobIndex].SubItems[4].Text,
                    lvSubJobList.Items[_checkSubJobIndex].SubItems[5].Text);
                newSubJob.ShowDialog();
                refreshData();
            }

        }

        //修改步骤
        private void btnSubJobEdit_Click(object sender, EventArgs e)
        {
            if (!checkSubJobInfo())
            {
                return;
            }
            else
            {
                FrmSubJobEdit editSubJob = new FrmSubJobEdit( 
                    Int32.Parse(lvSubJobList.Items[_checkSubJobIndex].SubItems[0].Text),
                    lvSubJobList.Items[_checkSubJobIndex].SubItems[4].Text,
                    lvSubJobList.Items[_checkSubJobIndex].SubItems[5].Text,
                    Int32.Parse(lvSubJobList.Items[_checkSubJobIndex].SubItems[6].Text),
                    Int32.Parse(lvSubJobList.Items[_checkSubJobIndex].SubItems[8].Text)
                    );
                editSubJob.ShowDialog();
                refreshData();
            }

        }

        private void btnSubJobDel_Click(object sender, EventArgs e)
        {
            if (!checkSubJobInfo())
                return;
            else if (_checkSubJobIndex >= 0 && _checkSubJobIndex < lvJob.Items.Count)
            {
                DataReadWriteHelper jobReader = new DataReadWriteHelper(Global.config);
                jobReader.deleteData("delete from sub_job_list where sub_job_id = " + lvSubJobList.Items[_checkSubJobIndex].SubItems[0].Text);
                refreshData();
            }

        }


        private bool checkSubJobInfo()
        {
            if (_checkJobShowerIndex < 0)
            {
                MessageBox.Show("请先创建或勾选任务！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (lvSubJobList.Items.Count > 0 && _checkSubJobIndex < 0)
            {
                MessageBox.Show("当看到本提示时，请勾选需要修改的步骤！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion






    }
}
