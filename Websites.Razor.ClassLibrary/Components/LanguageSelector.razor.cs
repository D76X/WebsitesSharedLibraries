using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Websites.Razor.ClassLibrary.Components
{
	// https://stackoverflow.com/questions/5427414/editing-a-git-submodule
	public class LanguageSelectorBase: ComponentBase
	{
		protected const string CountryCodeUk = @"GB";
		protected const string CountryCodeGermany = @"DE";
		protected const string CountryCodeItaly = @"IT";

        public static string LanguageEn = @"en";
        public static string LanguageDe = @"de";
        public static string LanguageIt = @"it";

        public static string SelectedCountryCode = CountryCodeUk;
        public static string SelectedLanguage = LanguageEn;
		
        protected string SelectedCountrySvg => $"{SelectedCountryCode.ToLower()}.svg";
		
		[Inject]
		public NavigationManager NavigationManager { get; set; }

		[Parameter] 
		public EventCallback<string> OnLanguageSelected { get; set; }

		protected async Task OnClickItem(
			MouseEventArgs e, 
			string countryCode)
		{
			switch (countryCode)
			{
				case CountryCodeUk: 
					SelectedCountryCode = CountryCodeUk;
					break;
				case CountryCodeGermany:
					SelectedCountryCode = CountryCodeGermany;
					break;
				case CountryCodeItaly:
					SelectedCountryCode = CountryCodeItaly;
					break;
				default:
					break;
			}

			SelectedLanguage = countryCode == CountryCodeUk ? 
                LanguageEn : 
                SelectedCountryCode.ToLower();
			
            await OnLanguageSelected.InvokeAsync(SelectedLanguage);
		}

		protected override void OnInitialized()
		{
			base.OnInitialized();

			var currentUri = NavigationManager.Uri.Trim();

			if (currentUri.EndsWith($"/{LanguageEn}") || currentUri.Contains($"/{LanguageEn}/"))
			{
				SelectedCountryCode = CountryCodeUk;
                SelectedLanguage = LanguageEn;
				return;
			}

            if (currentUri.EndsWith($"/{LanguageDe}") || currentUri.Contains($"/{LanguageDe}/"))
            {
				SelectedCountryCode = CountryCodeGermany;
                SelectedLanguage = LanguageDe;
                return;
			}

            if (currentUri.EndsWith($"/{LanguageIt}") || currentUri.Contains($"/{LanguageIt}/"))
            {
				SelectedCountryCode = CountryCodeItaly;
                SelectedLanguage = LanguageIt;
                return;
			}

			SelectedCountryCode = CountryCodeUk;
            SelectedLanguage = LanguageEn;
        }
	}
}
