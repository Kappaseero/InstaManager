using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using InstagramPrivateAPI.Models;
using InstagramPrivateAPI.Helpers.Deserializers;

namespace InstagramPrivateAPI.Helpers
{
    internal class OpenTDBQuizDeserializer : QuizDeserializer
    {

        internal override IQuestionAnswerModel? Deserialize (IQuestionAnswerModel model, HttpResponseMessage httpResponse)
        {
            ApiSpecificClass? midResult = new();
            string? responseMessage = httpResponse.Content.ToString();
            if (responseMessage == null)
            {
                return null;
            }

            midResult = JsonSerializer.Deserialize<ApiSpecificClass>(responseMessage);
            if(midResult == null)
            {
                return null;
            }

            model.Answer = midResult.correct_answer;
            model.WrongAnswers = midResult.incorrect_answers;
            model.Question = midResult.question;
            return model;
        }
        //used in the middle so the deserializer understands the names
        private class ApiSpecificClass
        {
            public string incorrect_answers { get; set; } = string.Empty;
            public string correct_answer { get; set; } = string.Empty;
            public string question { get; set; } = string.Empty;
        }
    }
}
