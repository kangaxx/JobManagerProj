using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManager
{
    class PovInfo
    {
        public int ID { set; get; }
        public string PlaceName { set; get; }
    }

    class SubJobInfo
    {
        public int sub_job_id { set; get; }

    }

    class Global
    {
        public static string config = System.AppDomain.CurrentDomain.BaseDirectory + "\\files\\dbconn.aes"; 
    }
}
