using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramPrivateAPI.ExternalAPIAccess;
using InstagramPrivateAPI.Helpers;
using InstagramPrivateAPI.InstagramInteracter;
using InstagramApiSharp.API;
using InstagramPrivateAPI.Models;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes;
using InstagramPrivateAPI.InstagramInteracter.Posts;
using InstagramPrivateAPI.Helpers.Captions;
using InstagramPrivateAPI.Helpers.Deserializers;
using System.Drawing;


namespace InstagramPrivateAPI.Items
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

