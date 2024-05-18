namespace Websites.Razor.ClassLibrary.Abstractions.Services
{
    public interface ILanguageService
    {
        string? SelectedLanguage { get; set; }
        event EventHandler<string>? SelectedLanguageChanged;
    }
}
