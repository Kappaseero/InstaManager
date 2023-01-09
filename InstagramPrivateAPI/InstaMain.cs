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
using InstaManagerLibrary.InstagramInteracter.Posts;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using InstaManagerLibrary.Items;
using InstaManagerLibrary.Enums;
using InstaManagerLibrary.InstagramInteracter;
using InstaManagerLibrary.Models;

namespace InstaManagerLibrary
{
    public class InstaMain
    {
        public IInstaApi instaApi { get; }
        public HttpClient HttpClient { get; }
        public QuizItem Quiz { get; }
        public bool Challenged { get; }
        public AccountActionsBase AccountActions { get; }
        public LeaderboardBase Leaderboard { get; }

        public InstaMain(QuizSettingsBase quizSettings, HttpClient httpClient, string username, string password)
        {
            instaApi = InstagramInstanceActions.CreateInstance(username, password);
            Quiz = new QuizItem(quizSettings, instaApi, httpClient);
            AccountActions = new AccountActions(instaApi);
            Leaderboard = new LeaderboardModel(this);
            HttpClient = httpClient;
        }

    }
}
