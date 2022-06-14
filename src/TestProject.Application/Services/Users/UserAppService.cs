using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TestProject.Services.Settings;
using TestProject.Services.Users.Dto;
using TestProject.Services.Users.Dto.InputDto;
using TestProject.Services.Users.Dto.OutputDto;

namespace TestProject.Services.Users
{
    public class UserAppService : IUserAppService
    {
        private readonly IOptions<AppSettings> _appSettings;

        public UserAppService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings;
        }
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

        public LoginResponseDto LoginTherapist(LoginBodyDto loginBody)
        {
            loginBody.grant_type = "password";
            loginBody.scope = "read:current_user";
            loginBody.client_id = _appSettings.Value.Client_id;
            loginBody.client_secret = _appSettings.Value.Client_secret;
            loginBody.audience = "https://dev-jv13awpw.us.auth0.com/api/v2/";
            var client = new RestClient("https://dev-jv13awpw.us.auth0.com/oauth/token");
            var request = new RestRequest("",Method.Post);
            var jsonBody = JsonConvert.SerializeObject(loginBody);
            request.AddHeader("content-type", "application/json");
            request.AddBody(jsonBody,"application/json");
            var response = client.Execute(request);
            var data = response.IsSuccessful;
            var responseObj = JsonConvert.DeserializeObject<LoginResponseDto>(response.Content);
            return responseObj;
        }

        //[HttpGet,
        //[System.Web.Http.Route("GetCallback{response}")]
        [Microsoft.AspNetCore.Mvc.HttpGet("GetCallback/{response}")]
        public void GetCallback([FromUri]string response)
        {
            throw new NotImplementedException();
        }

        public void UpdatePassword(string password)
        {
            throw new NotImplementedException();
        }

    }
}
