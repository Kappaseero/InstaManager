﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstaManagerLibrary.Models;

namespace InstaManagerLibrary.Helpers.Captions
{
    internal static class QuizCaption
    {
        public static string UnguessedCaption(IQuestionAnswerModel questionAnswerModel, DateTime dateTimeCreated, out int rightAnswerNumber)
        {
            List<string> answersList = questionAnswerModel.WrongAnswers.ToList();
            answersList.Add(questionAnswerModel.Answer);
            List<string> scrambledAnswersList = ListMethods.ScrambleList(answersList);

            //+1 because count below starts from 1 not 0
            rightAnswerNumber = scrambledAnswersList.IndexOf(questionAnswerModel.Answer) + 1;


            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(dateTimeCreated.Date.ToString() + ". ");
            stringBuilder.Append("Possible answers are:");
            int count = 1;
            foreach(string answer in scrambledAnswersList)
            {
                stringBuilder.Append($" {count}:{answer}.");
                count++;
            }
            stringBuilder.Append(" Type the answer as a number in the comments.");

            return stringBuilder.ToString();
        }

        public static string GuessedCaption(IQuestionAnswerModel questionAnswerModel, DateTime dateTimeCreated, DateTime dateTimeNextQuiz)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(dateTimeCreated.Date.ToString() + ".");
            stringBuilder.Append($" {questionAnswerModel.Answer} was the right answer.");

            return stringBuilder.ToString();
        }
    }
}
