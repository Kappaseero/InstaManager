using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Enums;
using InstagramPrivateAPI.Enums;

namespace InstagramPrivateAPI.InstagramInteracter
{
    internal class AccountActions : AccountActionsBase
    {
        public AccountActions(IInstaApi instaApi)
        {
            InstaApi = instaApi;
        }
        private IInstaApi InstaApi { get; }
        
        public override bool IsLoggedIn { get { return InstaApi.IsUserAuthenticated; }}
        private ChallengeEnum ChallengeType { get; set; }


        /// <summary>
        /// Tries to log the passed IInstaApi instance in. Do this before most actions on the instance. Remember to log out. Accepts a log in challenge if challenged by FB/IG.
        /// </summary>
        /// <param name="instaApi">The instance to log in.</param>
        /// <returns>True if you need to </returns>
        public override async Task<Enums.LoginEnum> TryLogInAsync()
        {
            if (!InstaApi.IsUserAuthenticated)
            {
                //most of this is taken from the github repo samples
                //https://github.com/ramtinak/InstagramApiSharp/tree/master/samples/ChallengeRequireExample

                await InstaApi.SendRequestsBeforeLoginAsync();
                await Task.Delay(5000);

                var logInResult = await InstaApi.LoginAsync();
                if (logInResult.Succeeded)
                {
                    await InstaApi.SendRequestsAfterLoginAsync();

                    ChallengeType = ChallengeEnum.None;
                    return Enums.LoginEnum.Success;
                }
                else if (logInResult.Value == InstaLoginResult.ChallengeRequired)
                {
                    var challenge = await InstaApi.GetChallengeRequireVerifyMethodAsync();
                    if (challenge.Succeeded)
                    {
                        if (challenge.Value.SubmitPhoneRequired)
                        {
                            ChallengeType = ChallengeEnum.PhoneNumber;
                            return Enums.LoginEnum.SubmitPhone;
                        }
                        else
                        {
                            var result = await InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync();
                            ChallengeType = ChallengeEnum.Email;
                            return LoginEnum.EmailChallenged;
                        }
                    }
                    else
                    {
                        ChallengeType = ChallengeEnum.None;
                        return LoginEnum.Unsuccessful;
                    }
                }
                else
                {
                    ChallengeType = ChallengeEnum.None;
                    return LoginEnum.Unsuccessful;
                }
            }
            else
            {
                ChallengeType = ChallengeEnum.None;
                return Enums.LoginEnum.AlreadyLoggedIn;
            }
            
        }
        /// <summary>
        /// Tries to log in the passed IInstaApi instance in when a verification code is needed.
        /// This returns false when 2 factor authentication is needed.
        /// </summary>
        /// <param name="instaApi"></param>
        /// <param name="verificationCode"></param>
        /// <returns>True if successful. False if not successful or 2 factor auth needed.</returns>
        public override async Task<bool> LogInChallengedAsync(string verificationCode)
        {
            var result = await InstaApi.VerifyCodeForChallengeRequireAsync(verificationCode);

            if (result.Succeeded)
                return true;

            else return false;
        }

        /// <summary>
        /// Submits the passed in phone number for the challenge.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns>True if success. False if not.</returns>
        public override async Task<bool> SubmitPhoneNumberAsync(string phoneNumber)
        {
            var result = await InstaApi.SubmitPhoneNumberForChallengeRequireAsync(phoneNumber);
            if (result.Succeeded) { return true; }
            else { return false; }
        }


        /// <summary>
        /// Logs the passed IInstaApi instance out.
        /// </summary>
        /// <param name="instaApi">The instance to log out.</param>
        public async void LogOutAsync(IInstaApi instaApi)
        {
            await instaApi.LogoutAsync();
        }
    }
}
