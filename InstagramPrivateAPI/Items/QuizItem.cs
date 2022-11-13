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
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes;
using InstagramPrivateAPI.InstagramInteracter.Posts;
using InstagramPrivateAPI.Helpers.Captions;

namespace InstagramPrivateAPI.Items
{
    // the class that wraps everything together for a quiz
    internal class QuizItem
    {
        public QuizItem(IGetQuiz getQuiz, IQuestionAnswerModel questionAnswer, ITextModel textModel, IInstaApi instaApi, Uri background, InstaImageUpload instaImage, TextToImageBase textToImage)
        {
            TextToImage = textToImage;
            GetQuiz = getQuiz;
            QuestionAnswer = questionAnswer;
            TextModel = textModel;
            InstaApiInstance = instaApi;
            Background = background;
            FinalImage = instaImage;
            ReadyUpImage(FinalImage, textToImage);
            Caption = QuizCaption.MakeCaption(questionAnswer);
        }

        public InstaImageUpload FinalImage { get; set; }
        public TextToImageBase TextToImage { get; set; }
        public IGetQuiz GetQuiz { get; set; }
        public IQuestionAnswerModel QuestionAnswer { get; set; }
        public Uri Background { get; set; }
        public ITextModel TextModel { get; set; }
        public IInstaApi InstaApiInstance { get; set; }
        public IResult<InstaMedia>? PostResult { get; set; }
        public string Caption { get; set; }
        public ResultInfo? PostInfo { get; set; }





        public async Task Post()
        {

            PostResult = await ImagePoster.Post(InstaApiInstance, FinalImage, Caption);
            PostInfo = PostResult.Info;
        }

        private void ReadyUpImage(InstaImageUpload instaImage, TextToImageBase textToImage)
        {
            instaImage.Height = 1080;
            instaImage.Width = 1080;
            instaImage.ImageBytes = textToImage.CreateImage();
        }

        
    }
}
