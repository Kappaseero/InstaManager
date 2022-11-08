namespace InstagramPrivateAPI.Models
{
    internal interface IQuestionAnswerModel
    {
        string Answer { get; set; }
        string FileName { get; set; }
        public string Question { get; set; }
    }
}