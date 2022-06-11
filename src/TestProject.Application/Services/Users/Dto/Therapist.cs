using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Users.Dto
{
    public class Therapist: UserBase
    {
        [Required]
        public string Title { get; set; }


        [Required]
        public string City { get; set; }


        [Required]
        public string Country { get; set; }


        [Required]
        public int ZipCode { get; set; }


        [Required]
        public string Currency { get; set; }
    }
}
