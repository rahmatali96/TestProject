
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
        Task<CreateSignupInput> CreateTherapist(CreateSignupInput createSignup);
        Task<LoginInput> LoginTherapist(LoginInput login);
        Task<ForgotPasswordInput>ForgotPassword(ForgotPasswordInput forgotPasswordInpu0t);
        Task<TokenInput> GetToken();
        void GetAllSignup(getUser user);
        void UpdatePassword(string password);
    }
}
