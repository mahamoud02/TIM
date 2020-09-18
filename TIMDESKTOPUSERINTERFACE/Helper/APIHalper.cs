using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TIMDESKTOPUSERINTERFACE.Models;

namespace TIMDESKTOPUSERINTERFACE.Helper
{
    public class APIHalper : IAPIHalper
    {
        private HttpClient Apiclient;
        public APIHalper()
        {
            InitializeClient();
        }

        private void InitializeClient()
        {
            String api = ConfigurationManager.AppSettings["api"];

            Apiclient = new HttpClient();
            Apiclient.BaseAddress = new Uri(api);
            Apiclient.DefaultRequestHeaders.Accept.Clear();
            Apiclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<String ,String>("grant_type","password"),
                new KeyValuePair<String ,String>("username",username),
                new KeyValuePair<String ,String>("password",password)
            });

            using (HttpResponseMessage response = await Apiclient.PostAsync("/Token", data))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                    return result;

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }

            }
        }

    }
}
