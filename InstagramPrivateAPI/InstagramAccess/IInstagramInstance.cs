using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.API;
using Microsoft.Extensions.Configuration;

namespace InstagramPrivateAPI.InstagramAccess
{
    internal interface IInstagramInstance
    {
        public IInstaApi CreateInstance(string username, string password);
        
    }
}
