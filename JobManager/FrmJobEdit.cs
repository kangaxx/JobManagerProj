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

    public partial class FrmJobEdit : Form
    {
        private string job_id;
        private string job_sn;
        private string job_name;
        private string job_desc;
        private string job_type;
        private string job_key;

        public FrmJobEdit(string id, string sn, string name, string desc, string type, string key)
        {
            job_id = id;
            job_sn = sn;
            job_name = name;
            job_desc = desc;
            job_type = type;
            job_key = key;
            InitializeComponent();
            txtSN.Text = sn;
            txtName.Text = name;
            txtDesc.Text = desc;
            txtType.Text = type;
            txtKeyWord.Text = key;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataReadWriteHelper drw = new DataReadWriteHelper(Global.config);
            string cmd = String.Format("update job_list set JOB_SN=\"{0}\", JOB_NAME=\"{1}\", JOB_DESC=\"{2}\", JOB_TYPE=\"{3}\", JOB_KEY_WORD=\"{4}\" where JOB_ID = {5}"
                                        , txtSN.Text, txtName.Text, txtDesc.Text, txtType.Text, txtKeyWord.Text, job_id);
            drw.updateData(cmd);
            this.Close();

        }


    }
}
