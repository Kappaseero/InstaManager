using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.Models
{
    internal class QuizQuestionAnswerModel : IQuestionAnswerModel
    {
        public string FileName { get; set; }
        public string Question { get; set; }
        public string[] WrongAnswers { get; set; }
        public string Answer { get; set; }

        internal QuizQuestionAnswerModel(int id, string question, string answer, string[] wrongAnswers)
        {
            FileName = $"quiz{id}.jpg";
            Question = question;
            Answer = answer;
            WrongAnswers = wrongAnswers;
        }
    }
}
