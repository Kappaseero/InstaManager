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
    internal class QuizTextToImageSK : ITextToImage
    {

        public QuizTextToImageSK(Uri background, string folderPath, IQuestionAnswerModel questionAnswerModel, ITextModel textModel)
        {
            Background = background;
            Font = textModel.FontName;
            TextColor = new SKColor(textModel.Red, textModel.Green, textModel.Blue, textModel.Alpha);
            FileName = questionAnswerModel.FileName;
            FolderPath = folderPath;
            FinalImagePath = CreateImage();
            Text = questionAnswerModel.Question;
        }
        private Uri Background { get; set; }
        private SKColor TextColor { get; set; }
        private string Font { get; set; }
        private string Text { get; set; }
        public Uri FinalImagePath { get; set; }

        //these 2 are used to created the FinalImagePath
        private string FolderPath { get; set; }
        private string FileName { get; set; }


        //Returns a Uri of a jpeg that is made with the background and text
        //provided to the constructor
        private Uri CreateImage()
        {
            try
            {


                var info = new SKImageInfo(1080, 1080);
                using (var surface = SKSurface.Create(info))
                using (SKCanvas canvas = surface.Canvas)
                {

                    using (FileStream fs = File.OpenRead(Background.AbsolutePath))
                    using (SKBitmap bitmap = SKBitmap.Decode(fs))
                    {
                        canvas.DrawBitmap(bitmap, 0, 0);
                    }

                    using (SKPaint textPaint = new SKPaint())
                    using (SKTypeface tf = SKTypeface.FromFamilyName(Font))
                    {
                        string text = Text;
                        textPaint.TextAlign = SKTextAlign.Center;
                        textPaint.Color = TextColor;
                        textPaint.IsAntialias = true;
                        textPaint.TextSize = info.Width / 10;
                        textPaint.Typeface = tf;
                        SKTextWrapping(info, textPaint, canvas, text);


                    }

                    using (SKImage image = surface.Snapshot())
                    using (SKData data = image.Encode(SKEncodedImageFormat.Jpeg, 100))
                    using (var stream = File.OpenWrite(Path.Combine(FolderPath, FileName)))
                    {
                        data.SaveTo(stream);
                        return new Uri(Path.Combine(FolderPath, FileName));
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
