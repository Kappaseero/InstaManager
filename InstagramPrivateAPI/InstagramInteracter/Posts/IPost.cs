using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;

namespace InstagramPrivateAPI.InstagramInteracter.Posts
{
    internal interface IPost
    {
        internal string Caption { get; set; }
        internal InstaImageUpload Image { get; set; }

    }
}
