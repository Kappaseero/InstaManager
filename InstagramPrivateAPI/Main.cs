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
using InstagramPrivateAPI.InstagramInteracter.Posts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;


namespace InstagramPrivateAPI
{
    public class Main : BackgroundService
    {
        private IInstaApi instaApi;

        public Main(HttpClient httpClient, IConfiguration configuration)
        {

            instaApi = InstagramAPISharpInstance.CreateInstance( 
                //username and password from appsettings.json
                configuration.GetSection("Credentials").GetSection("username").Value,
                configuration.GetSection("Credentials").GetSection("password").Value);
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {

            await InstagramBot(stoppingToken);
        }
        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            
            await base.StopAsync(stoppingToken);
        }

        private async Task InstagramBot(CancellationToken stoppingToken)
        {

        }
    }
}
