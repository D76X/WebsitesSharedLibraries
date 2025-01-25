using Websites.Razor.ClassLibrary.Abstractions.Models;
using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Abstractions.Extensions
{
    public static class SearchResultExtensions
    {

        public static IEnumerable<ISearchResult> Flatten(this ISearchResult sr)
        {
            ISearchResult thisOne;
            switch (sr)
            {
                case NullSearchResult t1:
                    thisOne = new NullSearchResult(
                        sr.SearchTerm,
                        sr.Value,
                        sr.TypeStr,
                        sr.Type,
                        null);
                    break;

                case MatchSearchResult t2:
                    thisOne = new MatchSearchResult(
                        sr.SearchTerm,
                        sr.Value,
                        sr.TypeStr,
                        sr.Type,
                        null);
                    break;

                default:
                    thisOne = new SearchResult(
                        sr.SearchTerm,
                        sr.Value,
                        sr.TypeStr,
                        sr.Type,
                        null);
                    break;
            }

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
