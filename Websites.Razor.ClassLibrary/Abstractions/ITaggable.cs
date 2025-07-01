using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Abstractions;

public interface ITaggable
{
    IEnumerable<ITag> Tags { get; }
}