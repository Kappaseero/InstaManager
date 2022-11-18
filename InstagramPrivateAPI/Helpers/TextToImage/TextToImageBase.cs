using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using System.Drawing;
using InstagramPrivateAPI.Models;

namespace InstagramPrivateAPI.Helpers
{
    internal abstract class TextToImageBase
    {
        public abstract byte[] CreateImage(Uri background, ITextModel textModel, string imageText);
    }
}