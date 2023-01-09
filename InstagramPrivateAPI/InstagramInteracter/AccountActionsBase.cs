using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Enums;
using InstaManagerLibrary.Enums;

namespace InstaManagerLibrary.InstagramInteracter
{
    public abstract class AccountActionsBase
    {
        public abstract bool IsLoggedIn { get; }
        public abstract bool Challenged { get;}
        public abstract ChallengeEnum ChallengeType { get; protected set; }
        public abstract Task<Enums.LoginEnum> TryLogInAsync();
        public abstract Task<bool> LogInChallengedAsync(string verificationCode);
        public abstract Task<bool> SubmitPhoneNumberAsync(string phoneNumber);
    }
}
