using Websites.Razor.ClassLibrary.Abstractions.Models;
using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Abstractions.Extensions
{
    public static class SearchResultExtensions
    {

        public static IEnumerable<ISearchResult> Flatten(this ISearchResult sr)
        {
            var thisOne = sr is NullSearchResult
                ? new NullSearchResult(
                    sr.SearchTerm,
                    sr.Value,
                    sr.TypeStr,
                    sr.Type,
                    null)
                : new SearchResult(
                    sr.SearchTerm,
                    sr.Value,
                    sr.TypeStr,
                    sr.Type,
                    true);

            var results = new List<ISearchResult>() { thisOne };

            foreach (var result in sr.SearchResults)
            {
                var flattened = result.Flatten();
                results.AddRange(flattened);
            }

            return results;
        }

    }
}
