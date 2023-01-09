using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstaManagerLibrary.ExternalAPIAccess;
using InstaManagerLibrary.Helpers;
using InstaManagerLibrary.InstagramInteracter;
using InstagramApiSharp.API;
using InstaManagerLibrary.Models;
using InstagramApiSharp.Classes;

namespace InstaManagerLibrary.InstagramInteracter.Posts
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
