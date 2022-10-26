using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.InstagramInteracter.Posts
{
    internal class QuizPost : PhotoPost
    {
        public QuizPost(HttpClient httpClient, InstaImageUpload instaImageUpload)
        {
            Client = httpClient;
            Caption = GenerateCaption();
            Image = instaImageUpload;
            Image.Uri = GenerateMedia();
        }


        internal override HttpClient Client { get; set; }
        internal override string Caption { get; set; }
        internal override InstaImageUpload Image { get; set; }

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
