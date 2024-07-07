﻿namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public class NullSearchResult : SearchResult
{
    public NullSearchResult(
        string searchTerm, 
        object value, 
        string typeStr, 
        Type type, 
        IEnumerable<ISearchResult>? searchResults = null) 
        : base(searchTerm, value, typeStr, type, searchResults) { }
}

public class SearchResult : ISearchResult
{
    private readonly List<ISearchResult> _searchResults = new List<ISearchResult>();

    public string SearchTerm { get; }
    public object Value { get; }
    public string TypeStr { get; }
    public Type Type { get; }
    public IEnumerable<ISearchResult> SearchResults => _searchResults;
    
    public static SearchResult NullResult(
        string searchTerm,
        object value,
        string typeStr,
        Type type) => 
        new NullSearchResult(
            searchTerm,
            value,
            typeStr,
            type,
        null);

    public SearchResult(
        string searchTerm,
        object value,
        string typeStr,
        Type type,
        IEnumerable<ISearchResult>? searchResults = null)
    {
        SearchTerm = searchTerm;
        Value = value;
        TypeStr = typeStr;
        Type = type;
        searchResults?.ToList().ForEach(v => _searchResults.Add(v));
    }

    public void Add(ISearchResult? searchResult)
    {
        if(searchResult == null) return;
        _searchResults.Add(searchResult);
    }

    public IEnumerable<ISearchResult> Flatten()
    {

        var thisOne = (this is NullSearchResult)
            ? new NullSearchResult(
                this.SearchTerm,
                this.Value,
                this.TypeStr,
                this.Type,
                null)
            : new SearchResult(
                this.SearchTerm,
                this.Value,
                this.TypeStr,
                this.Type,
                null);

        var results = new List<ISearchResult>(){ thisOne };
        
        foreach (var result in SearchResults)
        {
            var flattened = result.Flatten();
            results.AddRange(flattened);
        }

        return results;
    }

    public static bool operator !=(SearchResult obj1, SearchResult obj2) => !(obj1 == obj2);
    public static bool operator ==(SearchResult obj1, SearchResult obj2)
    {
        if (ReferenceEquals(obj1, obj2))
            return true;
        if (ReferenceEquals(obj1, null))
            return false;
        if (ReferenceEquals(obj2, null))
            return false;
        return obj1.Equals(obj2);
    }

    public bool Equals(SearchResult other)
    {
        if (ReferenceEquals(other, null))
            return false;
        if (ReferenceEquals(this, other))
            return true;
        
        return SearchTerm.Equals(other.SearchTerm)
               && Value.Equals(other.Value)
               && TypeStr.Equals(other.TypeStr)
               && Type == other.Type;
    }
    public override bool Equals(object obj) => Equals(obj as SearchResult);

    public override int GetHashCode()
    {
        unchecked
        {
            int hashCode = SearchTerm.GetHashCode();
            hashCode = (hashCode * 397) ^ Value.GetHashCode();
            hashCode = (hashCode * 397) ^ TypeStr.GetHashCode();
            hashCode = (hashCode * 397) ^ Type.GetHashCode();
            return hashCode;
        }
    }
}
