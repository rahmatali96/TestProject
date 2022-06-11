using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Services.Users.Dto
{
    [AutoMapFrom(typeof(TherapistDto))]
    public class CreateSignupInput
    {
        public string client_id { get; set; }
        public string connection { get; set; }

        [Required,DataType(DataType.EmailAddress),StringLength(255,ErrorMessage ="Email required")]
        public string email { get; set; }

        [Required,DataType(DataType.Text),StringLength(255,ErrorMessage ="Firstname is required ")]
        public string given_name { get; set; }

        [Required, DataType(DataType.Text), StringLength(255, ErrorMessage = "Lastname is required ")]
        public string family_name { get; set; }

        [Required,DataType(DataType.Password),StringLength(255,MinimumLength =8,ErrorMessage ="Password is required")]
        public string password { get; set; }

        public user_metadata user_metadata { get; set; }

        public static explicit operator CreateSignupInput(string v)
        {
            throw new NotImplementedException();
        }
    }
}
