namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface ISeriesModel : IDisposable
{
    public IEnumerable<ICardModel> GetCards(IEnumerable<ITag> tags);
}