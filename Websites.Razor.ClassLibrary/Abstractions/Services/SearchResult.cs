namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public class SearchResult
{
    public IEnumerable<string> searchTerms { get; }
    public IEnumerable<string> Values { get; }
}