using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using InstagramPrivateAPI.Models;

namespace InstagramPrivateAPI.Helpers
{
    internal static class QuizDeserializers
    {
        internal static IQuestionAnswerModel OpenTDBDeserializer(IQuestionAnswerModel model, HttpResponseMessage httpResponse)
        {
            OpenTDBModel? midresult = JsonSerializer.Deserialize<OpenTDBModel>(httpResponse.Content.ToString());
            model.Answer = midresult.CorrectAnswer;
            model.WrongAnswers = midresult.WrongAnswers;
            model.Question = midresult.Question;
            return model;
        }
        //check these for exact names from the api response
        private class OpenTDBModel
        {
            public string WrongAnswers { get; set; } = string.Empty;
            public string CorrectAnswer { get; set; } = string.Empty;
            public string Question { get; set; } = string.Empty;
        }
    }
}
