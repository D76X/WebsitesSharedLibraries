using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Abstractions.Services
{
    public interface ICardService
    {
        ICardModel GetCard(string cardId);
    }
}
