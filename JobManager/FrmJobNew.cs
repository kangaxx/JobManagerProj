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
    public partial class FrmJobNew : Form
    {
        public FrmJobNew()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataReadWriteHelper drw = new DataReadWriteHelper(Global.config);
            string args = "[{'name':'@sn','value':'" + txtSN.Text + "','direct':'1'},{'name':'@name','value':'" + txtName.Text + "','direct':'1'}"
            + ",{'name':'@desc','value':'" + txtDesc.Text + "','direct':'1'},{'name':'@type','value':'" + txtType.Text + "','direct':'1'},{'name':'@key','value':'" + txtKeyWord.Text + "','direct':'1'}]";

            drw.callProc("PROC_INSERT_JOB_LIST", args);
            this.Close();
        }
    }
}
