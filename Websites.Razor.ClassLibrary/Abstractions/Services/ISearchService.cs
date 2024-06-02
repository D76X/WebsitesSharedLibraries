namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public interface ISearchService
{
    IEnumerable<SearchResult> SearchResults(IEnumerable<string> searchTerms);
}