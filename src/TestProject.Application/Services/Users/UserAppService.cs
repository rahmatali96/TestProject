using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TestProject.Services.Users.Dto;

namespace TestProject.Services.Users
{
    public class UserAppService : IUserAppService
    {
        public async Task<CreateSignupInput> CreateTherapist(CreateSignupInput createSignup)
        {

            var signup = new CreateSignupInput
            {
                client_id = createSignup.client_id,
                connection = createSignup.connection,
                email = createSignup.email,
                password = createSignup.password,
                given_name = createSignup.given_name,
                family_name = createSignup.family_name,
                user_metadata = new user_metadata
                {
                    title = createSignup.user_metadata.title,
                    country_code = createSignup.user_metadata.country_code,
                    Phone_number = createSignup.user_metadata.Phone_number,

                },
                             
            };

            var json = JsonConvert.SerializeObject(signup);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://testerpromact.au.auth0.com/dbconnections/signup";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            //var resultresponse = JsonConvert.DeserializeObject(result);
            return signup;

        }

        public Task<ForgotPasswordInput> ForgotPassword(ForgotPasswordInput forgotPasswordInpu0t)
        {
            throw new NotImplementedException();
        }

        public void GetAllSignup(getUser user)
        {
            
        }

        //public void GetAllSignup()
        //{
        //    //HttpClient client = new HttpClient();
        //    //var url = "https://testerpromact.au.auth0.com/dbconnections/signup");
        //    //var response = await client.PostAsync(url, data);

        //    //var result = await response.Content.ReadAsStringAsync();
        //    //return signup;
        //}


        public async Task<TokenInput> GetToken()
        {
            var token = new TokenInput
            {
                client_id = "DcS0UVdGpcsCXo2nlqa0xSLDGjbQtSvV",
                client_secret = "g1MCM73LBhE8_ctA6MgcTcBE82S49h25YlU5OAS9SAOH0QJfP3f3WZwWtdJoLOig",
                audience = "https://localhost:44311/api",
                grant_type = "client_credentials"
            };
            var json = JsonConvert.SerializeObject(token);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://testerpromact.au.auth0.com/oauth/token";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            return token;
        }

        public Task<LoginInput> LoginTherapist(LoginInput login)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
