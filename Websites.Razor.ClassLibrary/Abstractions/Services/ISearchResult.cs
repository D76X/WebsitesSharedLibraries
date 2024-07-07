namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public interface ISearchResult
{
    string SearchTerm { get; }
    object Value { get; }
    string TypeStr { get; }
    Type Type { get; }
    IEnumerable<ISearchResult> SearchResults { get; }
    void Add(ISearchResult? searchResult);
    IEnumerable<ISearchResult> Flatten();
}