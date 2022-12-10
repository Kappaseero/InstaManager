using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.SessionHandlers;
using InstagramApiSharp.API;
using InstagramPrivateAPI.InstagramAccess;

namespace InstagramAccess
{
    

    public class InstagramAPISharpInstance : IInstagramInstance
    {
        public InstagramAPISharpInstance()
        {

        }
        public IInstaApi CreateInstance (string username, string password)
        {
            IInstaApi api = InstaApiBuilder.CreateBuilder()
                .SetUser(UserSessionData.ForUsername(username).WithPassword(password))
                .Build();
            
            return api;
        }
    }
}
