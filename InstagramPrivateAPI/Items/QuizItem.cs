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
        //public QuizItem(IGetQuiz getQuiz, IQuestionAnswerModel questionAnswer, ITextModel textModel, IInstaApi instaApi, InstaImageUpload instaImage, TextToImageBase textToImage, DateTime dateTimeNextQuiz)
        //{
        //    TextToImage = textToImage;
        //    GetQuiz = getQuiz;
        //    QuestionAnswer = questionAnswer;
        //    TextModel = textModel;
        //    InstaApiInstance = instaApi;
        //    Background = background;
        //    FinalImage = instaImage;
        //    ReadyUpImage(FinalImage, textToImage);
        //    DateTimeCreated = DateTime.Now;
        //    DateTimeNextQuiz = dateTimeNextQuiz;

        //    int rightAnswer;
        //    Caption = QuizCaption.UnguessedCaption(QuestionAnswer, DateTimeCreated, out rightAnswer);
        //    RightAnswer = rightAnswer;
        //    EndedCaption = QuizCaption.GuessedCaption(QuestionAnswer, DateTimeCreated, DateTimeNextQuiz);



        //}

        public QuizItem(QuizSettingsBase quizSettings)
        {
            DateTimeNextQuiz = quizSettings.DateTimeNextQuiz;
            Image = quizSettings.Image;
            TextToImage = quizSettings.TextToImage;
            GetQuiz = quizSettings.GetQuiz;
            QuestionAnswer = quizSettings.QuestionAnswer;
            UnguessedBackground = quizSettings.UnguessedBackground;
            GuessedBackground = quizSettings.GuessedBackground;
            TextModel = quizSettings.TextModel;
            InstaApiInstance = quizSettings.InstaApiInstance;
            Deserializer = quizSettings.Deserializer;
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
        private  IInstaApi InstaApiInstance { get; set; }
        private  QuizDeserializer Deserializer { get; set; }


        private  IResult<InstaMedia>? PostResult { get; set; }
        private  ResultInfo? PostInfo { get; set; }
        private  int RightAnswer { get; set; }


        


        public async Task PostUnguessed()
        {
            //get a http response from api with GetQuiz and deserializing it
            try
            {
                var response = await GetQuiz.GetDataAsync();
                QuestionAnswer = Deserializer.Deserialize(QuestionAnswer, response);
                Image.ImageBytes = TextToImage.CreateImage(UnguessedBackground, TextModel, QuestionAnswer.Question);

                string caption = QuizCaption.UnguessedCaption(QuestionAnswer, DateTimeCreated, out int rightAnswer);
                RightAnswer = rightAnswer;
                PostResult = await ImagePoster.Post(InstaApiInstance, Image, caption);
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
                PostResult = await ImagePoster.Post(InstaApiInstance, Image, caption);
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
