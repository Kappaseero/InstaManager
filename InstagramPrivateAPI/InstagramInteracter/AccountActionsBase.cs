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
    public abstract class AccountActionsBase
    {
        public abstract bool IsLoggedIn { get; }
        public abstract Task<Enums.LoginEnum> TryLogInAsync();
        public abstract Task<bool> LogInChallengedAsync(string verificationCode);
        public abstract Task<bool> SubmitPhoneNumberAsync(string phoneNumber);
    }
}
