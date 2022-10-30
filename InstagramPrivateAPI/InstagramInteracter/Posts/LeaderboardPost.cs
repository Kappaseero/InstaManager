using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramPrivateAPI.Models;

namespace InstagramPrivateAPI.InstagramInteracter.Posts
{
    internal class LeaderboardPost : PhotoPost
    {
        public LeaderboardPost(HttpClient httpClient, InstaImageUpload instaImageUpload, LeaderboardModel leaderboardModel)
        {
            Client = httpClient;
            Caption = GenerateCaption();
            Image = instaImageUpload;
            Image.Uri = GenerateMedia();
            Leaderboard = leaderboardModel;
        }

        internal override HttpClient Client { get; set; }
        internal override string Caption { get; set; }
        internal override InstaImageUpload Image { get; set; }
        public LeaderboardModel Leaderboard { get; set; }

        private string GenerateCaption()
        {
            return string.Empty;
        }

        private string GenerateMedia()
        {
            return string.Empty;
        }
    }
}
