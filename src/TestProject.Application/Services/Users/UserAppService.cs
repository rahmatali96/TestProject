using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Services.Users.Dto;
using static System.Net.WebRequestMethods;

namespace TestProject.Services.Users
{
    public class UserAppService : IUserAppService
    {
        public Task<CreateSignupInput> CreateAuth0User(CreateSignupInput signupInput)
        {
            throw new NotImplementedException();
        }

        public Task<ForgotPasswordInput> ForgotPassword(ForgotPasswordInput forgotPasswordInpu0t)
        {
            throw new NotImplementedException();
        }

        public void GetAllSignup()
        {
            throw new NotImplementedException();
        
        }

        public Task<LoginInput> LoginWithAuth0(LoginInput loginInput)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
