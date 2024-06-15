namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface IIndexPage: IDisposable
{
    public event Action? OnStateHasChanged;
    public ICardModel GetCard(string cardId);
    public string TestString { get; set; }
}