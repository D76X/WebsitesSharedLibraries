using Websites.Razor.ClassLibrary.Abstractions;
using Websites.Razor.ClassLibrary.Abstractions.Models;
using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Models;

public class CardModel :
    ICardModel,
    ISearchable
{
    public CardModel(
        string imageSrc,
        string pageRef,
        string pageTitle,
        string pageText)
    {
        ImageSrc = imageSrc;
        PageRef = pageRef;
        PageTitle = pageTitle;
        PageText = pageText;
    }

    public string ImageSrc { get; }
    public string PageRef { get; }
    public string PageTitle { get; }
    public string PageText { get; }

    public ISearchResult GetResult(string searchTerm)
    {
        if (ImageSrc.Contains(searchTerm) ||
            PageRef.Contains(searchTerm) ||
            PageTitle.Contains(searchTerm) ||
            PageText.Contains(searchTerm))
        {
            return new SearchResult(
                searchTerm,
                this,
                nameof(CardModel),
                this.GetType());
        }

        return SearchResult.NullResult(
                searchTerm,
                this,
                nameof(CardModel),
                this.GetType());
    }
}
