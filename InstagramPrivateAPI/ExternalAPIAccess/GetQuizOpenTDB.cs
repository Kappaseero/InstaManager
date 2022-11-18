﻿using InstagramPrivateAPI.Helpers;
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
        }
        public HttpClient HttpClient { get; set; }
        public string Uri { get { return "https://opentdb.com/api.php?amount=1&type=multiple"; } }


        // Gets 1 QnA from QuizOpenTDB
        public async Task<HttpResponseMessage> GetDataAsync()
        {
            try
            {
                var response = await HttpClient.GetAsync(Uri);

                return response;
            }
            catch
            {
                return null;
            }
            

        }
    }
}
