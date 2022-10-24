using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.API;

namespace InstagramAccess
{
    

    internal static class InstaAPIInstance
    {
        
        internal static IInstaApi CreateInstance (HttpClient httpClient, string username, string password)
        {
            IInstaApi api = InstaApiBuilder.CreateBuilder()
                .SetUser(UserSessionData.ForUsername(username).WithPassword(password))
                .UseHttpClient(httpClient)
                .Build();

            return api;
        }
    }
}
