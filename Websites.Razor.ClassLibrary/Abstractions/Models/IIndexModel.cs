namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface IIndexModel: IDisposable
{
    public event Action? OnStateHasChanged;
    public ICardModel GetCard(string cardId);
    public string TestString { get; set; }
}