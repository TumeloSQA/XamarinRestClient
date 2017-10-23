using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XamarinRestClient.RestClient
{
    public class EmployeeServices
    {
        public void Login(string username, string password)
        {
            // We are using the RestSharp library which provides many useful
            // methods and helpers when dealing with REST.
            // We first create the request and add the necessary parameters
            var client = new HttpClient("http://staging.tangent.tngnt.co/api-token-auth/");
            var request = new RestRequest("oauth/ro", Method.POST);
            request.AddParameter("client_id", "{YOUR-AUTH0-CLIENT-ID");
            request.AddParameter("username", username);
            request.AddParameter("password", password);
            request.AddParameter("connection", "{YOUR-CONNECTION-NAME-FOR-USERNAME-PASSWORD-AUTH}");
            request.AddParameter("grant_type", "password");
            request.AddParameter("scope", "openid");

      
        }
    }
}
