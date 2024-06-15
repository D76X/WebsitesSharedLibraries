using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Services
{
    public class SearchService: ISearchService
    {
        public static string? SearchTerm = null;

        private IEnumerable<SearchResult>? _searchResults;
        
        public event EventHandler<IEnumerable<SearchResult>>? SearchResultsChanged;
        protected virtual void OnSearchResults(IEnumerable<SearchResult> e) => 
            SearchResultsChanged?.Invoke(this, e);

        public IEnumerable<SearchResult> SearchResults
        {
            get => _searchResults;

            set
            {
                _searchResults = value;
                OnSearchResults(value);
            }
        }

        public IEnumerable<SearchResult> GetResults(string searchTerm)
        {
            var searchResults = new List<SearchResult>();
            var searchResult = new SearchResult(new[] { searchTerm }, new[] { "found!" });
            searchResults.Add(searchResult);
            SearchResults = searchResults;
            return searchResults;
        }

        public IEnumerable<SearchResult> GetResults(IEnumerable<string> searchTerms)
        {
            throw new NotImplementedException();
        }
    }
}
