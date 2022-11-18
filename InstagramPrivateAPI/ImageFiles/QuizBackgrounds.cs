using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace InstagramPrivateAPI.ImageFiles
{
    internal static class QuizBackgrounds
    {
        private static string? baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static Uri UnguessedBackground { get; } = new Uri(baseDir + @"\tempBackground.png");
        public static Uri GuessedBackground { get; } = new Uri(baseDir + @"\tempBackground.png");
    }
}
