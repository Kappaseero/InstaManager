﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstaManagerLibrary.ExternalAPIAccess;
using InstaManagerLibrary.Helpers;
using InstaManagerLibrary.InstagramInteracter;
using InstagramApiSharp.API;
using InstaManagerLibrary.Models;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes;
using InstaManagerLibrary.InstagramInteracter.Posts;
using InstaManagerLibrary.Helpers.Captions;
using InstaManagerLibrary.Helpers.Deserializers;

namespace InstaManagerLibrary.Items
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
        private byte[] UnguessedBackground { get; set; }
        private  byte[] GuessedBackground { get; set; }
        private  ITextModel TextModel { get; set; }
        private  QuizDeserializer Deserializer { get; set; }
        private HttpClient HttpClient { get; set; }
        private IInstaApi InstaApi { get; set; }


        private  IResult<InstaMedia>? PostResult { get; set; }
        private  ResultInfo? PostInfo { get; set; }
        private  int RightAnswer { get; set; }


        //muista laitta login ja logout ja conf check


        public async Task<bool> PostUnguessedAsync()
        {
            //get a http response from api with GetQuiz and deserializing it
            try
            {
                var response = await GetQuiz.GetDataAsync(HttpClient);
                var deserialized = Deserializer.Deserialize(QuestionAnswer, response);

                //null check
                if (deserialized == null || deserialized.Question == null) { return false; }

                QuestionAnswer = deserialized;
                Image.ImageBytes = TextToImage.CreateImage(UnguessedBackground, TextModel, QuestionAnswer.Question);

                string caption = QuizCaption.UnguessedCaption(QuestionAnswer, DateTimeCreated, out int rightAnswer);
                RightAnswer = rightAnswer;
                PostResult = await ImageActions.PostAsync(InstaApi, Image, caption);
                PostInfo = PostResult.Info;
                return true;
            }
            catch (Exception ex)
            {
                NotifyOfException(ex);
                return false;
            }
            
        }

        public async Task<bool> PostGuessedAsync()
        {
            try
            {
                Image.ImageBytes = TextToImage.CreateImage(UnguessedBackground, TextModel, QuestionAnswer.Question);

                string caption = QuizCaption.GuessedCaption(QuestionAnswer, DateTimeCreated, DateTimeNextQuiz);
                PostResult = await ImageActions.PostAsync(InstaApi, Image, caption);
                PostInfo = PostResult.Info;
                return true;
            }
            catch (Exception ex)
            {
                NotifyOfException(ex);
                return false;
            }
        }

       

        private void NotifyOfException(Exception exception)
        {
            Console.WriteLine(exception.Message);
            Console.WriteLine(exception.Source);
        }
    }
}
