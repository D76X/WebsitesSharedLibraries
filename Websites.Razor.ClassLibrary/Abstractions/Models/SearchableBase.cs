using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public class SearchableBase : ISearchable
{
    private ISearchable[]? _searchables;
    private readonly Func<IEnumerable<ISearchable>> _getSearchables;
    public readonly string Name;

    public SearchableBase(
        string name,
        Func<IEnumerable<ISearchable>> getSearchables)
    {
        Name = name;
        _getSearchables = getSearchables;
    }

    public ISearchable[]? Searchables
    {
        get
        {
            if (_searchables != null) return _searchables;
            _searchables = _getSearchables()?.ToArray() ?? Array.Empty<ISearchable>();
            return _searchables;
        }
    }

    public ISearchResult GetResult(string searchTerm)
    {
        var searchResults = new List<ISearchResult>();
        
        if (Searchables != null)
        {
            foreach (var searchable in Searchables)
            {
                var result = searchable.GetResult(searchTerm);
                searchResults.Add(result);
            }
        }

        var searchResult = (searchResults.Any(i => i.IsMatch))
            ? SearchResult.MatchResult(
                searchTerm,
                this,
                Name,
                this.GetType(),
                searchResults.ToArray())
            : SearchResult.NullResult(
                searchTerm,
                this,
                Name,
                this.GetType());

        return searchResult;
    }
}