namespace Websites.Razor.ClassLibrary.Abstractions.Models
{
    interface ICard
    {
        string TypeStr { get; }
        IEnumerable<ICardModel> GetModels();
    }
}
