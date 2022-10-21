using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.API;

namespace InstagramAccess
{
    

    public static class InstaAPIInstance
    {
        
        public static IInstaApi CreateInstance (HttpClient httpClient, string username, string password)
        {
            IInstaApi api = InstaApiBuilder.CreateBuilder()
                .SetUser(UserSessionData.ForUsername(username).WithPassword(password))
                .UseHttpClient(httpClient)
                .Build();

            return api;
        }
    }
}
