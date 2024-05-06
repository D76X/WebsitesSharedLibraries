namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface IIndexPage: IDisposable
{
    public ICardModel GetCard(string cardId);
}