using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Services.Users.Dto
{
    [AutoMapFrom(typeof(TherapistDto))]

    public class user_metadata
    {
        public string title { get; set; }
        public string country_code { get; set; }
        public string Phone_number { get; set; }


    }
}
