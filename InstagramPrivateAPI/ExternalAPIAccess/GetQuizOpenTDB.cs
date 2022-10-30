using InstagramPrivateAPI.Helpers;
using InstagramPrivateAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.ExternalAPIAccess
{
    internal class GetQuizOpenTDB : IGetQuiz
    {
        public GetQuizOpenTDB(HttpClient httpClient)
        {
            HttpClient = httpClient;
            QuestionAnswer = GetDataAsync().Result;
        }
        public HttpClient HttpClient { get; set; }
        public QuestionAnswerModel QuestionAnswer { get; set; }
        public string Uri { get { return "https://opentdb.com/api.php?amount=1&difficulty=easy&type=multiple"; } }


        // Gets 1 QnA from QuizOpenTDB and deserializes it with Helpers.QuizDeserializers
        public async Task<QuestionAnswerModel> GetDataAsync()
        {
            QuestionAnswerModel result;
            try
            {
                var response = await HttpClient.GetAsync(Uri);
                result = QuizDeserializers.OpenTDBDeserializer(QuestionAnswer, response);

                return result;
            }
            catch
            {
                return null;
            }
            

        }
    }
}
