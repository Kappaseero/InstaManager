namespace InstaManagerLibrary.Models
{
    internal interface ITextModel
    {
        byte Alpha { get; set; }
        byte Blue { get; set; }
        string FontName { get; set; }
        int FontSize { get; set; }
        byte Green { get; set; }
        byte Red { get; set; }
    }
}