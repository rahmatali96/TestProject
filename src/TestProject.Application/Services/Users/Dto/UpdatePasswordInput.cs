using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Users.Dto
{
    public class UpdatePasswordInput
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
