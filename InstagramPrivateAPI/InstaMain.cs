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


namespace InstagramPrivateAPI
{
    public class InstaMain
    {
        public IInstaApi instaApi { get; }
        public QuizItem Quiz { get; set; }
        public InstaMain(QuizItem qItem, string username, string password)
        {
            instaApi = InstagramInstanceActions.CreateInstance(username, password);
            Quiz = qItem;
        }

        /// <summary>
        /// Tries to log the InstaAPI in. Also checks for login challenges.
        /// </summary>
        /// <returns>The correct LoginEnum from the following. Success, Challenged, Unsuccessful.</returns>
        public async Task<LoginEnum> ValidateCredentialsAsync()
        {
            
        }
    }
}
