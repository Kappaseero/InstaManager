using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes;

namespace InstagramPrivateAPI.InstagramInteracter
{
    internal static class AccountActions
    {
        /// <summary>
        /// Tries to log the passed IInstaApi instance in. Do this before most actions on the instance. Remember to log out. Accepts a log in challenge if challenged by FB/IG.
        /// </summary>
        /// <param name="instaApi">The instance to log in.</param>
        /// <returns>True if you need to </returns>
        public static async Task<bool> TryLogInAsync(IInstaApi instaApi)
        {
            //most of this is taken from the github repo samples
            await instaApi.SendRequestsBeforeLoginAsync();
            await Task.Delay(2000);
            var logInResult = await instaApi.LoginAsync();
            if (logInResult.Succeeded)
            {
                await instaApi.SendRequestsAfterLoginAsync();
            }
            else
            {
                if(logInResult.Value == InstaLoginResult.ChallengeRequired)
                {
                    var challenge = await instaApi.GetChallengeRequireVerifyMethodAsync();
                    if (challenge.Succeeded)
                    {
                        if (challenge.Value.SubmitPhoneRequired)
                        {
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Tries to log in the passed IInstaApi instance in when a verification code is needed.
        /// </summary>
        /// <param name="instaApi"></param>
        /// <param name="verificationCode"></param>
        /// <returns></returns>
        public static async Task<bool> LogInChallengedAsync(IInstaApi instaApi, string verificationCode)
        {
            return true;
        }

        /// <summary>
        /// Logs the passed IInstaApi instance out.
        /// </summary>
        /// <param name="instaApi">The instance to log out.</param>
        public static void LogOut(IInstaApi instaApi)
        {
            instaApi.LogoutAsync();
        }
        /// <summary>
        /// Sometimes the login is challenged by Facebook/Instagram. This has to be accepted to log in.
        /// </summary>
        /// <param name="instaApi"></param>
        /// <returns>True if challenged. False if not challenged.</returns>
        private static bool CheckChallenge(IInstaApi instaApi)
        {
            return true;
        }
    }
}
