
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Services.Users.Dto;

namespace TestProject.Services.Users
{
    public interface IUserAppService:IApplicationService
    {
        Task<CreateSignupInput> CreateAuth0User(CreateSignupInput signupInput);
        Task<LoginInput> LoginWithAuth0(LoginInput loginInput);
        Task<ForgotPasswordInput>ForgotPassword(ForgotPasswordInput forgotPasswordInpu0t);
        void GetAllSignup();
        void UpdatePassword(string password);

    }
}
