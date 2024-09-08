using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Abstractions.Services
{
    public interface ICardCatalog
    {
        IEnumerable<ICardModel> GetModels();
        ICardModel GetModel(string cardId, string? language);
    }
}
