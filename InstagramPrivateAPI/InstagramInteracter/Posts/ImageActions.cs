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
    internal static class ImageActions
    {
       public static async Task<IResult<InstaMedia>> PostAsync(IInstaApi instaApi, InstaImageUpload instaImage, string caption)
        {
            var post = await instaApi.MediaProcessor.UploadPhotoAsync(instaImage, caption);
            return post;
        }

        public static async Task<IResult<bool>> DeletePostAsync(IInstaApi instaApi, string mediaId, InstaMediaType mediaType)
        {
            var result = await instaApi.MediaProcessor.DeleteMediaAsync(mediaId, mediaType);
            return result;
        }
    }
}
