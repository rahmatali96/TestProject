
using Abp.Application.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Services.Users.Dto;
using TestProject.Services.Users.Dto.InputDto;
using TestProject.Services.Users.Dto.OutputDto;

namespace TestProject.Services.Users
{
    public interface IUserAppService:IApplicationService
    {
        Task<CreateSignupInput> CreateTherapist(CreateSignupInput createSignup);
        LoginResponseDto LoginTherapist(LoginBodyDto loginBody);
        Task<ForgotPasswordInput>ForgotPassword(ForgotPasswordInput forgotPasswordInpu0t);
        Task<TokenInput> GetToken();
        void GetAllSignup(getUser user);
        void UpdatePassword(string password);
        void GetCallback(string response);
    }
}
