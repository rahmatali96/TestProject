using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Users.Dto.OutputDto
{
    public class FbLoginResponse
    {
        public string sub { get; set; }
        public string given_name { get; set; }
        public string nickname { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string updated_at { get; set; }
        public string email { get; set; }
        public string email_verified { get; set; }
    }
}
