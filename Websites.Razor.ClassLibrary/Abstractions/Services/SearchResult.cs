namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public class SearchResult
{
    public readonly IEnumerable<string> searchTerms;
    public readonly IEnumerable<string> Values;

    public SearchResult(
        IEnumerable<string> searchTerms, 
        IEnumerable<string> values)
    {
        this.searchTerms = searchTerms;
        Values = values;
    }
}