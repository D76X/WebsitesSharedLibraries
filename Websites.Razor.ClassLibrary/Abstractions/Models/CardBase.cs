using Websites.Razor.ClassLibrary.Abstractions.Services;


namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public abstract class CardBase :
    ICard,
    ISearchable,
    ITaggable

{
    private readonly SearchableBase _searchableBase;

    protected CardBase(
        string typeStr,
        IEnumerable<ITag>? tags=null)
    {
        TypeStr = typeStr;

        _searchableBase = new SearchableBase(
            typeStr,
            () => GetModels().OfType<ISearchable>().ToArray());
        
        Tags = tags != null ? tags.ToArray() : [];
    }

    public abstract IEnumerable<ICardModel> GetModels();

    public string TypeStr { get; protected set; }
    public ISearchable[]? Searchables => _searchableBase.Searchables;
    public ISearchResult GetResult(string searchTerm) => _searchableBase.GetResult(searchTerm);
    public IEnumerable<ITag> Tags { get; } = [];
}