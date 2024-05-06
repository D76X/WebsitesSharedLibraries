namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface ICardModel
{
    string ImageSrc { get; }
    string PageRef { get; }
    string PageTitle { get; }
    string PageText { get; }
}