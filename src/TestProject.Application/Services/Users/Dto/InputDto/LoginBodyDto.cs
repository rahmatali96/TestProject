using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Users.Dto.InputDto
{
    public class LoginBodyDto
    {
        public string grant_type;
        public string username { get; set; }
        public string password { get; set; }
        public string scope;
        public string client_id;
        public string client_secret;
        public string audience;
    }
}
