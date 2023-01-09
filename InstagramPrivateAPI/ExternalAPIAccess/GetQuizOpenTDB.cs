using InstaManagerLibrary.Helpers;
using InstaManagerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaManagerLibrary.ExternalAPIAccess
{
    internal class GetQuizOpenTDB : IGetQuiz
    {
        public GetQuizOpenTDB()
        {
        }
        public string Uri { get { return "https://opentdb.com/api.php?amount=1&type=multiple"; } }


        // Gets 1 QnA from QuizOpenTDB
        public async Task<string> GetDataAsync(HttpClient httpClient)
        {
            try
            {
                var response = await httpClient.GetStringAsync(Uri);

                return response;
            }
            catch
            {
                return null;
            }
            

        }
    }
}
