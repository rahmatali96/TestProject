using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Settings
{
    public class AppSettings
    {
        public string Domain { get; set; }
        public string Audience { get; set; }
        public string Client_id { get; set; }
        public string Client_secret { get; set; }
        public string Callback_Uri { get; set; }
        public string Connection { get; set; }
    }
}
