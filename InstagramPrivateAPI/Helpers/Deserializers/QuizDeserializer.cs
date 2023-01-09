using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using InstaManagerLibrary.Models;

namespace InstaManagerLibrary.Helpers.Deserializers
{
    internal abstract class QuizDeserializer
    {
        internal abstract IQuestionAnswerModel? Deserialize(IQuestionAnswerModel model, string deserializable);

        private abstract class ApiSpecificClass
        {

        }
    }
}
