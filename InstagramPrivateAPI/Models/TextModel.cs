using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramPrivateAPI.Models
{
    internal class TextModel : ITextModel
    {
        public TextModel(string fontName = "Arial", int fontSize = 100, byte red = 0, byte green = 0, byte blue = 0, byte alpha = 255)
        {
            FontName = fontName;
            FontSize = fontSize;
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public string FontName { get; set; }
        public int FontSize { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
    }
}
