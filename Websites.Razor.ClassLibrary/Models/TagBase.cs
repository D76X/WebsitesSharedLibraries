using Websites.Razor.ClassLibrary.Abstractions.Models;

namespace Websites.Razor.ClassLibrary.Models;

public class TagBase: ITag
{
    public string Name { get; }

    public TagBase(string name)
    {
        Name = name;
    }
}