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
    internal abstract class PhotoPost
    {
        
        internal abstract HttpClient Client { get; set; }
        internal abstract string Caption { get; set; }
        internal abstract InstaImageUpload Image { get; set; }



        internal virtual void MakePhotoPost(IInstaApi instaApi)
        {
            instaApi.MediaProcessor.UploadPhotoAsync(Image, Caption);
        }
    }
}
