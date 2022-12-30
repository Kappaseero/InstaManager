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
using InstagramPrivateAPI.Helpers.Deserializers;

namespace InstagramPrivateAPI.Items
{
    // the class that wraps everything together for a quiz
    public class QuizItem
    {
        public QuizItem(QuizSettingsBase quizSettings, IInstaApi instaApi, HttpClient httpClient)
        {
            DateTimeNextQuiz = quizSettings.DateTimeNextQuiz;
            Image = quizSettings.Image;
            TextToImage = quizSettings.TextToImage;
            GetQuiz = quizSettings.GetQuiz;
            QuestionAnswer = quizSettings.QuestionAnswer;
            UnguessedBackground = quizSettings.UnguessedBackground;
            GuessedBackground = quizSettings.GuessedBackground;
            TextModel = quizSettings.TextModel;
            Deserializer = quizSettings.Deserializer;

            InstaApi = instaApi;
            HttpClient = httpClient;
        }




        private DateTime DateTimeCreated { get; set; } = DateTime.Now;
        private  DateTime DateTimeNextQuiz { get; set; }
        private  InstaImageUpload Image { get; set; }
        private  TextToImageBase TextToImage { get; set; }
        private  IGetQuiz GetQuiz { get; set; }
        private  IQuestionAnswerModel QuestionAnswer { get; set; }
        private  Uri UnguessedBackground { get; set; }
        private  Uri GuessedBackground { get; set; }
        private  ITextModel TextModel { get; set; }
        private  QuizDeserializer Deserializer { get; set; }
        private HttpClient HttpClient { get; set; }
        private IInstaApi InstaApi { get; set; }


        private  IResult<InstaMedia>? PostResult { get; set; }
        private  ResultInfo? PostInfo { get; set; }
        private  int RightAnswer { get; set; }


        //muista laitta login ja logout ja conf check


        public async Task PostUnguessed()
        {
            //get a http response from api with GetQuiz and deserializing it
            try
            {
                var response = await GetQuiz.GetDataAsync(HttpClient);
                QuestionAnswer = Deserializer.Deserialize(QuestionAnswer, response);
                Image.ImageBytes = TextToImage.CreateImage(UnguessedBackground, TextModel, QuestionAnswer.Question);

                string caption = QuizCaption.UnguessedCaption(QuestionAnswer, DateTimeCreated, out int rightAnswer);
                RightAnswer = rightAnswer;
                PostResult = await ImagePoster.Post(InstaApi, Image, caption);
                PostInfo = PostResult.Info;
            }
            catch (Exception ex)
            {
                NotifyOfException(ex);
            }
            
        }

        public async Task PostGuessed()
        {
            try
            {
                Image.ImageBytes = TextToImage.CreateImage(UnguessedBackground, TextModel, QuestionAnswer.Question);

                string caption = QuizCaption.GuessedCaption(QuestionAnswer, DateTimeCreated, DateTimeNextQuiz);
                PostResult = await ImagePoster.Post(InstaApi, Image, caption);
                PostInfo = PostResult.Info;
            }
            catch (Exception ex)
            {
                NotifyOfException(ex);
            }
        }

       

        private void NotifyOfException(Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.Source);
        }
    }
}
