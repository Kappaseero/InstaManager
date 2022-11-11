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

namespace InstagramPrivateAPI.Items
{
    // the class that wraps everything together for a quiz
    internal class QuizItem
    {
        public QuizItem(IGetQuiz getQuiz, IQuestionAnswerModel questionAnswer, ITextModel textModel, IInstaApi instaApi, Uri background)
        {
            GetQuiz = getQuiz;
            QuestionAnswer = questionAnswer;
            TextModel = textModel;
            InstaApiInstance = instaApi;
            Background = background;
        }

        public IGetQuiz GetQuiz { get; set; }
        public IQuestionAnswerModel QuestionAnswer { get; set; }
        public Uri Background { get; set; }
        public ITextModel TextModel { get; set; }
        public IInstaApi InstaApiInstance { get; set; }
        public bool HasBeenAnswered { get; set; }

    }
}
