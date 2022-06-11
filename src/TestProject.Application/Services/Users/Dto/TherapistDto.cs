using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Users.Dto
{
    public class TherapistDto
    {
        public string client_id { get; set; }
        public string connection { get; set; }

        [Required, DataType(DataType.EmailAddress), StringLength(255, ErrorMessage = "Email required")]
        public string email { get; set; }

        [Required, DataType(DataType.Text), StringLength(255, ErrorMessage = "Firstname is required ")]
        public string given_name { get; set; }

        [Required, DataType(DataType.Text), StringLength(255, ErrorMessage = "Lastname is required ")]
        public string family_name { get; set; }

        [Required, DataType(DataType.Password), StringLength(255, MinimumLength = 8, ErrorMessage = "Password is required")]
        public string password { get; set; }
        public string title { get; set; }
        public string country_code { get; set; }
        public string Phone_number { get; set; }
    }
}
