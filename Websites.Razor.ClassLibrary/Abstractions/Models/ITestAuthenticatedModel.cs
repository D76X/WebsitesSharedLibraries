namespace Websites.Razor.ClassLibrary.Abstractions.Models;

public interface ITestAuthenticatedModel : IDisposable
{
    public event Action OnStateHasChanged;
    string SelectedLanguage { get; }
    bool IsEnglish { get; }
    bool IsDeutsch { get; }
    bool IsItalian { get; }
}

public interface ITestAuthorizedModel : IDisposable
{
    public event Action OnStateHasChanged;
    string SelectedLanguage { get; }
    bool IsEnglish { get; }
    bool IsDeutsch { get; }
    bool IsItalian { get; }
}