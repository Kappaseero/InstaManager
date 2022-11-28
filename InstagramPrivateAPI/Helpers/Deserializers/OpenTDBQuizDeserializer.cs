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

        internal override IQuestionAnswerModel? Deserialize (IQuestionAnswerModel model, string deserializable)
        {
            ApiSpecificClass? midResult = new();
            string? responseMessage = deserializable;
            if (responseMessage == null)
            {
                return null;
            }

            midResult = JsonSerializer.Deserialize<ApiSpecificClass>(responseMessage);
            if(midResult == null)
            {
                return null;
            }

            model.Answer = midResult.results[0].correct_answer;
            model.WrongAnswers = midResult.results[0].incorrect_answers;
            model.Question = midResult.results[0].question;
            return model;
        }
        //used in the middle so the deserializer understands the names
        private class ApiSpecificClass
        {
            public int response_code { get; set; }
            public Results[] results { get; set; }

            
            public class Results
            {
                public string[]? incorrect_answers { get; set; }
                public string correct_answer { get; set; }
                public string question { get; set; }
            }

        }
    }
}
