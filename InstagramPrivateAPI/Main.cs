using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI
{
    public class Main
    {
        private readonly HttpClient _httpclient;
        private readonly string _username;
        private readonly string _password;

        public Main(HttpClient httpClient, string username, string password)
        {
            _httpclient = httpClient;
            _username = username;
            _password = password;


        }
    }
}
