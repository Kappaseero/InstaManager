namespace InstagramPrivateAPI.Models
{
    internal interface IQuestionAnswerModel
    {
        int Id { get; set; }
        string Answer { get; set; }
        string[] WrongAnswers { get; set; }
        public string Question { get; set; }
    }
}