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
using InstagramPrivateAPI.Enums;
using InstagramPrivateAPI.InstagramInteracter;

namespace InstagramPrivateAPI
{
    public class InstaMain
    {
        public IInstaApi instaApi { get; }
        public QuizItem Quiz { get; set; }
        public bool Challenged { get; set; }
        public AccountActionsBase AccountActions { get; }

        public InstaMain(QuizItem qItem, string username, string password)
        {
            instaApi = InstagramInstanceActions.CreateInstance(username, password);
            Quiz = qItem;
            AccountActions = new AccountActions(instaApi);
        }

    }
}
