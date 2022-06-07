using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Users.Dto
{
    public class ForgotPasswordInput
    {

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
