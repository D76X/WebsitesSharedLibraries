using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Abstractions.Services;

public interface ITagCatalog
{
    IEnumerable<ITag> Tags { get; }
}