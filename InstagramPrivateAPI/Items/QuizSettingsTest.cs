using InstagramApiSharp.API;
using InstagramApiSharp.Classes.Models;
using InstagramPrivateAPI.ExternalAPIAccess;
using InstagramPrivateAPI.Helpers;
using InstagramPrivateAPI.Helpers.Deserializers;
using InstagramPrivateAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InstagramPrivateAPI.ImageFiles;
using InstagramAccess;
using Microsoft.Extensions.Configuration;
using System.Drawing;


namespace InstagramPrivateAPI.Items
{
    public class QuizSettingsTest : QuizSettingsBase
    {
        //this class is for testing purposes
        public QuizSettingsTest()
        {
            Image.Height = 1080;
            Image.Width = 1080;
        }
        internal override byte[] UnguessedBackground => BackgroundImages.tempBackground;
        internal override byte[] GuessedBackground => BackgroundImages.tempBackground;
        internal override TextToImageBase TextToImage => new TextToImageSK();
        internal override QuizDeserializer Deserializer => new OpenTDBQuizDeserializer();
        internal override IQuestionAnswerModel QuestionAnswer => new QuizQuestionAnswerModel();
        internal override ITextModel TextModel => new TextModel();
        internal override InstaImageUpload Image => new InstaImageUpload();
        internal override DateTime DateTimeNextQuiz => DateTime.Today;
        internal override IGetQuiz GetQuiz => new GetQuizOpenTDB();
    }
}
