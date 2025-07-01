using Utils;
using Websites.Razor.ClassLibrary.Abstractions;
using Websites.Razor.ClassLibrary.Abstractions.Models;
using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Models;

public class CardModel :
    ICardModel,
    ITaggable,
    ISearchable
{
    public CardModel(
        string imageSrc,
        string pageRef,
        string pageTitle,
        string pageText,
        IEnumerable<ITag>? tags = null)
    {
        ImageSrc = imageSrc;
        PageRef = pageRef;
        PageTitle = pageTitle;
        PageText = pageText;
        Language = PageRef.GetSubStringAfterLastChar('/');
        Tags = tags ?? [];
    }

    public string ImageSrc { get; }
    public string PageRef { get; }
    public string PageTitle { get; }
    public string PageText { get; }
    public string Language { get; }
    public IEnumerable<ITag> Tags { get; }

    public ISearchable[]? Searchables => null;

    public ISearchResult GetResult(string searchTerm)
    {
        if (ImageSrc.Contains(searchTerm) ||
            PageRef.Contains(searchTerm) ||
            PageTitle.Contains(searchTerm) ||
            PageText.Contains(searchTerm))
        {
            return SearchResult.MatchResult(
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
