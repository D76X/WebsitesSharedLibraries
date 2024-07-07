using Microsoft.AspNetCore.Components;
using Websites.Razor.ClassLibrary.Abstractions.Models;
using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Components
{
    public class SearchBoxModel : ISearchBoxModel
    {
        public string? SearchTerm { get ; set ; }
    }

    public class SearchBoxBase: ComponentBase
    {
        [Inject]
        public required ISearchService SearchService { get; set; }

        [Parameter] public ISearchBoxModel? Model { get; set; } = new SearchBoxModel();

        public string SearchTerm
        {
            get => Model!.SearchTerm;
            set => Model!.SearchTerm = value;
        }

        protected void Search()
        {
            var results = SearchService.GetResult(SearchTerm);
        }
    }
}
