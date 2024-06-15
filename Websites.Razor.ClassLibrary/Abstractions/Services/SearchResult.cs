namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public class SearchResult
{
    public readonly IEnumerable<string> SearchTerms;
    public readonly IEnumerable<string> Values;

    public SearchResult(
        IEnumerable<string> searchTerms, 
        IEnumerable<string> values)
    {
        SearchTerms = searchTerms;
        Values = values;
    }
}