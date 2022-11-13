using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramPrivateAPI.ExternalAPIAccess;
using InstagramPrivateAPI.Helpers;
using InstagramPrivateAPI.InstagramInteracter;
using InstagramApiSharp.API;
using InstagramPrivateAPI.Models;
using InstagramApiSharp.Classes;

namespace InstagramPrivateAPI.InstagramInteracter.Posts
{
    internal static class ImagePoster
    {
       public static async Task<IResult<InstaMedia>> Post(IInstaApi instaApi, InstaImageUpload instaImage, string caption)
        {
            var post = await instaApi.MediaProcessor.UploadPhotoAsync(instaImage, caption);
            return post;
        }
    }
}
