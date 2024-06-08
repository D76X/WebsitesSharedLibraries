using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Services
{
    public class SearchService: ISearchService
    {
        public static string? SearchTerm = null;

        public IEnumerable<SearchResult> GetResults(string searchTerm)
        {
            var searchResults = new List<SearchResult>();
            var searchResult = new SearchResult(new[] { searchTerm }, new[] { "found!" });
            searchResults.Add(searchResult);
            return searchResults;
        }

        public IEnumerable<SearchResult> GetResults(IEnumerable<string> searchTerms)
        {
            throw new NotImplementedException();

        }
    }
}
