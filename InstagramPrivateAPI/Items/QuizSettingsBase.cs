using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstaManagerLibrary.ExternalAPIAccess;
using InstaManagerLibrary.Helpers;
using InstaManagerLibrary.InstagramInteracter;
using InstagramApiSharp.API;
using InstaManagerLibrary.Models;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes;
using InstaManagerLibrary.InstagramInteracter.Posts;
using InstaManagerLibrary.Helpers.Captions;
using InstaManagerLibrary.Helpers.Deserializers;
using System.Drawing;


namespace InstaManagerLibrary.Items
{
    public abstract class QuizSettingsBase
    {
        internal abstract byte[] GuessedBackground { get; }
        internal abstract byte[] UnguessedBackground { get; }
        internal abstract QuizDeserializer Deserializer { get; }
        internal abstract IGetQuiz GetQuiz { get; }
        internal abstract IQuestionAnswerModel QuestionAnswer { get; }
        internal abstract ITextModel TextModel { get; }
        internal abstract InstaImageUpload Image { get; }
        internal abstract TextToImageBase TextToImage { get; }
        internal abstract DateTime DateTimeNextQuiz { get; }
    }
}

