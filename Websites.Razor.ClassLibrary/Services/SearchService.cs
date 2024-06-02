using Websites.Razor.ClassLibrary.Abstractions.Models;
using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Services
{
    public class SearchService: ISearchService
    {
        public IEnumerable<SearchResult> SearchResults(IEnumerable<string> searchTerms)
        {
            throw new NotImplementedException();
        }
    }
}
