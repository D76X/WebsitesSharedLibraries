namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public interface ISearchService
{
    string? SearchTerm { get; }
    ISearchResult SearchResult { get; }
    ISearchResult GetResult(string searchTerm);
    event EventHandler<ISearchResult>? SearchResultChanged;
}
