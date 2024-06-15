namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public interface ISearchService
{
    event EventHandler<IEnumerable<SearchResult>>? SearchResultsChanged;

    //IEnumerable<SearchResult> GetResults(IEnumerable<string> searchTerms);
    IEnumerable<SearchResult> GetResults(string searchTerm);
    IEnumerable<SearchResult> SearchResults { get; }
}