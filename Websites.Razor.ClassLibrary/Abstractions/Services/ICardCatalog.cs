using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Abstractions.Services
{
    public interface ICardCatalog
    {
        ICardModel GetCard(string cardId, string? language);
    }
}
