namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface ISeriesModel : IDisposable
{
    public ICardModel GetCard(string cardId);
}