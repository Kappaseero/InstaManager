namespace InstaManagerLibrary.Models
{
    internal interface IQuestionAnswerModel
    {
        int? Id { get; set; }
        string? Answer { get; set; }
        string[]? WrongAnswers { get; set; }
        string? Question { get; set; }
    }
}