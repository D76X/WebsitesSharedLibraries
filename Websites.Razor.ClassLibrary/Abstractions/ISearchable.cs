using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Abstractions
{
    public interface ISearchable
    { 
        ISearchable[]? Searchables { get; }
        ISearchResult GetResult(string searchTerm);
    }
}
