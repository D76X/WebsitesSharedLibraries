using Websites.Razor.ClassLibrary.Abstractions.Services;

namespace Websites.Razor.ClassLibrary.Services
{
    public class LanguageService : ILanguageService
    {
        private string? _selectedLanguage;

        public string? SelectedLanguage
        {
            get => _selectedLanguage;

            set
            {
                _selectedLanguage = value;
                OnSelectLanguage(value);
            }
        }

        public event EventHandler<string>? SelectedLanguageChanged;

        protected virtual void OnSelectLanguage(string? e)
        {
            SelectedLanguageChanged?.Invoke(this, e);
        }
    }
}
