using Websites.Razor.ClassLibrary.Abstractions.Models;
using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Services
{
    public class CardService : ICardService
    {
        private readonly ILanguageService _languageService;
        private readonly ICardCatalog _cardCatalog;

        public CardService(
            ILanguageService languageService,
            ICardCatalog cardCatalog)
        {
            _languageService = languageService;
            _cardCatalog = cardCatalog;
        }

        public ICardModel GetCard(string cardId) =>
            _cardCatalog.GetCardModel(
                cardId,
                _languageService.SelectedLanguage);

        public IEnumerable<ICardModel> GetCards(IEnumerable<string> cardIds)
        {
            throw new NotImplementedException();
        }
    }
}
