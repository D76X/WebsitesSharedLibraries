using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Abstractions.Services
{
    public interface ICardCatalog
    {
        ICardModel GetCardModel(string cardId, string? language);
    }
}
