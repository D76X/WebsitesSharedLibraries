namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public interface ISearchService
{
    //IEnumerable<SearchResult> GetResults(IEnumerable<string> searchTerms);
    IEnumerable<SearchResult> GetResults(string searchTerm);
}