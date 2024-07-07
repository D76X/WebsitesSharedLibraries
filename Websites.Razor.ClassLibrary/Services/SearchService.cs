using Websites.Razor.ClassLibrary.Abstractions;
using Websites.Razor.ClassLibrary.Abstractions.Services;
using SearchResultClass = Websites.Razor.ClassLibrary.Abstractions.Services.SearchResult;

namespace Websites.Razor.ClassLibrary.Services
{
    public class SearchService: 
        ISearchService
    {
        private readonly List<ISearchable> _searchables;

        public SearchService(ICardCatalog cardCatalog)
        {
            _searchResult = SearchResultClass.NullResult(
                SearchTerm,
                this,
                nameof(SearchService),
                this.GetType()); 
            ;
            _searchables = new List<ISearchable>();
            if (cardCatalog is ISearchable searchable) _searchables.Add(searchable);
        }

        public string? SearchTerm { get; private set; }

        private ISearchResult _searchResult;
        public ISearchResult SearchResult
        {
            get => _searchResult;
            set
            {
                _searchResult = value;
                OnSearchResult(value);
            }
        }
        
        public event EventHandler<ISearchResult>? SearchResultChanged;

        protected virtual void OnSearchResult(ISearchResult e) =>
            SearchResultChanged?.Invoke(this, e);

        public ISearchResult GetResult(string searchTerm)
        {
            var searchResult = new SearchResult(
                searchTerm,
                this,
                nameof(SearchService),
                this.GetType());

            foreach (var searchable in _searchables)
            {
                var result = searchable.GetResult(searchTerm);
                searchResult.Add(result);
            }

            SearchResult = searchResult;

            return searchResult;
        }
    }
}
