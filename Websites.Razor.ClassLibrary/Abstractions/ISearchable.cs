using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Abstractions
{
    public interface ISearchable
    { 
        ISearchResult GetResult(string searchTerm);
    }
}
