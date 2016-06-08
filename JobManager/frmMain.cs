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
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string config = System.AppDomain.CurrentDomain.BaseDirectory + "\\dbconn.key";
            DataReadHelper jobReader = new DataReadHelper(config);
            jobReader.ReadData(ref this.lvJob, "select * from test");
        }


    }
}
