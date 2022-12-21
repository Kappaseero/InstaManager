using InstagramPrivateAPI.Items;

namespace InstaManagerUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //quiz item
            QuizSettingsBase quizSettings = new QuizSettingsTest();
            QuizItem quizItem = new QuizItem(quizSettings);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static InstagramPrivateAPI.InstaMain? InstaMain { get; set; }
        public static HttpClient Client { get; set; } = new HttpClient();
        public static QuizSettingsBase QuizSettings { get; set; } = new QuizSettingsTest();
        public static QuizItem Quiz { get; set; } = new QuizItem(QuizSettings);
    }
}