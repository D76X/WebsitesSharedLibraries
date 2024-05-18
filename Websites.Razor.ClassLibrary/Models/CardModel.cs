using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Models;

public class CardModel : ICardModel
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
}