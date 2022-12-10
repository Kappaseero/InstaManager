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
using InstagramPrivateAPI.Items;


namespace InstagramPrivateAPI
{
    public class Main
    {
        public QuizItem Quiz { get; set; }
        public Main(QuizItem qItem)
        {
            Quiz = qItem;
        }

        private async Task InstagramBot(CancellationToken stoppingToken)
        {
            
                await Quiz.PostUnguessed();

        }
    }
}
