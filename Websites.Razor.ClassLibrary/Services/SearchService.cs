using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Services
{
    public class SearchService: ISearchService
    {
        public static string? SearchTerm = null;

        public IEnumerable<SearchResult> SearchResults(IEnumerable<string> searchTerms)
        {
            throw new NotImplementedException();

        }
    }
}
