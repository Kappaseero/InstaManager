﻿using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.API;

namespace InstagramAccess
{
    

    public static class InstagramInstanceActions
    {
        public static IInstaApi CreateInstance (string username, string password)
        {
            IInstaApi api = InstaApiBuilder.CreateBuilder()
                .SetUser(UserSessionData.ForUsername(username).WithPassword(password))
                .Build();
            
            return api;
        }
    }
}
