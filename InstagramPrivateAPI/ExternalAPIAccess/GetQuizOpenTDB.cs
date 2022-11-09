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
        public GetQuizOpenTDB(HttpClient httpClient, IQuestionAnswerModel QAmodel)
        {
            HttpClient = httpClient;
            QuestionAnswer = GetDataAsync(QAmodel).Result;
        }
        public HttpClient HttpClient { get; set; }
        public IQuestionAnswerModel QuestionAnswer { get; set; }
        public string Uri { get { return "https://opentdb.com/api.php?amount=1&type=multiple"; } }


        // Gets 1 QnA from QuizOpenTDB and deserializes it with Helpers.QuizDeserializers
        public async Task<IQuestionAnswerModel> GetDataAsync(IQuestionAnswerModel questionAnswerModel)
        {
            try
            {
                var response = await HttpClient.GetAsync(Uri);
                var result = QuizDeserializers.OpenTDBDeserializer(questionAnswerModel ,response);

                return result;
            }
            catch
            {
                return null;
            }
            

        }
    }
}
