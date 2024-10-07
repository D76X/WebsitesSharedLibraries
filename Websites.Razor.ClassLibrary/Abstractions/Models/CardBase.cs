using Websites.Razor.ClassLibrary.Abstractions.Services;


namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public abstract class CardBase :
    ICard,
    ISearchable

{
    private readonly SearchableBase _searchableBase;

    protected CardBase(string typeStr)
    {
        TypeStr = typeStr;
        _searchableBase = new SearchableBase(
            typeStr,
            () => GetModels().OfType<ISearchable>().ToArray());
        
    }

    public abstract IEnumerable<ICardModel> GetModels();

    public string TypeStr { get; protected set; }
    public ISearchable[]? Searchables => _searchableBase.Searchables;
    public ISearchResult GetResult(string searchTerm) => _searchableBase.GetResult(searchTerm);
}