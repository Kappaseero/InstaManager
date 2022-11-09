using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramPrivateAPI.Models;
using InstagramPrivateAPI.Helpers;

namespace InstagramPrivateAPI.ExternalAPIAccess
{
    internal interface IGetQuiz
    {
        public string Uri { get; }
        public HttpClient HttpClient { get; set; }
        public IQuestionAnswerModel QuestionAnswer { get; set; }
        public Task<IQuestionAnswerModel> GetDataAsync(IQuestionAnswerModel questionAnswerModel);
        
    }
}
