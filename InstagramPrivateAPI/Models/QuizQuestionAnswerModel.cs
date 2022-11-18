using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.Models
{
    internal class QuizQuestionAnswerModel : IQuestionAnswerModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string[] WrongAnswers { get; set; }
        public string Answer { get; set; }

        internal QuizQuestionAnswerModel()
        {

        }
    }
}
