namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface IAboutModel: IDisposable
{
    public event Action OnStateHasChanged;
    string SelectedLanguage { get; }
    bool IsEnglish { get; }
    bool IsDeutsch { get; }
    bool IsItalian { get; }
}