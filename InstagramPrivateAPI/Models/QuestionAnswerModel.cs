using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.Models
{
    internal class QuestionAnswerModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        internal QuestionAnswerModel(int id, string question, string answer)
        {
            Id = id;
            Question = question;
            Answer = answer;
        }
    }
}
