using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using System.Drawing;
using InstaManagerLibrary.Models;

namespace InstaManagerLibrary.Helpers
{
    internal abstract class TextToImageBase
    {
        public abstract byte[] CreateImage(byte[] background, ITextModel textModel, string imageText);
    }
}