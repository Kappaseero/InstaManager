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
    internal class TextToImageSK : TextToImageBase
    {

        public TextToImageSK()
        {
            
        }
       
        //Returns a byte array that is made with the background and text
        //provided to the constructor
        public override byte[] CreateImage(byte[] background, ITextModel textModel, string imageText)
        {
            SKColor sKColor = new SKColor(textModel.Red, textModel.Green, textModel.Blue, textModel.Alpha);


            try
            {


                var info = new SKImageInfo(1080, 1080);
                using (var memoryStream = new MemoryStream(background))
                using (var surface = SKSurface.Create(info))
                using (SKCanvas canvas = surface.Canvas)
                {;

                    using (SKBitmap bitmap = SKBitmap.Decode(memoryStream))
                    {
                        canvas.DrawBitmap(bitmap, 0, 0);
                    }

                    using (SKPaint textPaint = new SKPaint())
                    using (SKTypeface tf = SKTypeface.FromFamilyName(textModel.FontName))
                    {
                        string text = imageText;
                        textPaint.TextAlign = SKTextAlign.Center;
                        textPaint.Color = sKColor;
                        textPaint.IsAntialias = true;
                        textPaint.TextSize = info.Width / 10;
                        textPaint.Typeface = tf;
                        SKTextWrapping(info, textPaint, canvas, text);


                    }

                    using (SKImage image = surface.Snapshot())
                    using (SKData data = image.Encode(SKEncodedImageFormat.Jpeg, 100))
                    {
                        var result = data.ToArray();
                        return result;
                    }

                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //Inefficient and bad way to draw and scale the text to the canvas
        private void SKTextWrapping(SKImageInfo info, SKPaint paint, SKCanvas canvas, string text)
        {
            string[] words = text.Split(' ');
            StringBuilder currentString = new StringBuilder();

            float postWidth = info.Width / 10;
            float postHeight = info.Height / 10;
            int maxRows = info.Height / (int)paint.TextSize - 1;
            int currentRow = 1;
            bool tooManyRows;
            bool canDraw = false;
            bool hasDrawn = false;

            do
            {




                foreach (string word in words)
                {
                    if ((paint.MeasureText(currentString.ToString()) + paint.MeasureText(word)) * 1.1 < info.Width - postWidth)
                    {
                        currentString.Append(" " + word);
                    }
                    else
                    {
                        if (canDraw) canvas.DrawText(currentString.ToString(), info.Width / 2, postHeight * currentRow, paint);

                        currentRow++;
                        currentString.Clear();
                        currentString.Append(word);
                    }

                }
                if (canDraw)
                {
                    canvas.DrawText(currentString.ToString(), info.Width / 2, postHeight * currentRow, paint);
                    hasDrawn = true;
                }

                currentString.Clear();

                tooManyRows = currentRow > maxRows;

                if (!tooManyRows) canDraw = true;

                currentRow = 1;

                if (tooManyRows)
                    paint.TextSize -= 10;


            } while (tooManyRows || !hasDrawn);
        }
    }
}
