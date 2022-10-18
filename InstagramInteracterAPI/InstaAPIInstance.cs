using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.API;

namespace InstagramInteracterAPI
{
    

    public static class InstaAPIInstance
    {
        
        public static IInstaApi CreateInstance (IHttpClientFactory factory, string username, string password)
        {
            IInstaApi api = InstaApiBuilder.CreateBuilder()
                .SetUser(UserSessionData.ForUsername(username).WithPassword(password))
                .UseHttpClient(factory.CreateClient())
                .Build();

            return api;
        }
    }
}
