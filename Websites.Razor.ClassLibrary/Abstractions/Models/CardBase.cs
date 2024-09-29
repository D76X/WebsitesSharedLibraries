using Websites.Razor.ClassLibrary.Abstractions.Services;


namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public abstract class CardBase :
    ICard,
    ISearchable

{
    private readonly SearchableBase _searchableBase;

    protected CardBase(string name)
    {
        Name = name;
        _searchableBase = new SearchableBase(
            Name,
            () => GetModels().OfType<ISearchable>().ToArray());
        
    }

    public abstract IEnumerable<ICardModel> GetModels();

    public string Name { get; protected set; }
    public ISearchable[]? Searchables => _searchableBase.Searchables;
    public ISearchResult GetResult(string searchTerm) => _searchableBase.GetResult(searchTerm);
}