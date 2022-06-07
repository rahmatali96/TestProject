using Abp.AutoMapper;
using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Services.Users.Dto
{
    public class CreateSignupInput
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }


        [Required,DataType(DataType.PhoneNumber),StringLength(10)]
        public long Mobile { get; set; }
    }
}
