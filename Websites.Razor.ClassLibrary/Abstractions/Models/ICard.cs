namespace Websites.Razor.ClassLibrary.Abstractions.Models
{
    interface ICard
    {
        string Name { get; }
        IEnumerable<ICardModel> GetModels();
    }
}
