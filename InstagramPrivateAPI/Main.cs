using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.API;
using InstagramAccess;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;


namespace InstagramPrivateAPI
{
    public class Main : BackgroundService
    {
        private HttpClient _httpclient;
        private IInstaApi instaApi;

        public Main(HttpClient httpClient, IConfiguration configuration)
        {

            _httpclient = httpClient;
            instaApi = InstaAPIInstance.CreateInstance(httpClient, 
                //username and password from appsettings.json
                configuration.GetSection("Credentials").GetSection("username").Value,
                configuration.GetSection("Credentials").GetSection("password").Value);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            return Task.CompletedTask;
        }


    }
}
