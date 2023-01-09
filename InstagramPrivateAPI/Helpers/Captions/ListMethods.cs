using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaManagerLibrary.Helpers.Captions
{
    internal static class ListMethods
    {
        public static List<string> ScrambleList(List<string> answersList)
        {
            Random rand = new Random();
            List<string> scrambledAnswersList = new List<string>();

            foreach (var answer in answersList)
            {
                scrambledAnswersList.Insert(rand.Next(0, scrambledAnswersList.Count + 1), answer);
            }

            return scrambledAnswersList;
        }
    }
}
