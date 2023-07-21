using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Websites.Razor.ClassLibrary.Components
{
	// https://stackoverflow.com/questions/5427414/editing-a-git-submodule
	public class LanguageSelectorBase: ComponentBase
	{
		protected const string CountryCodeUk = "GB";
		protected const string CountryCodeGermany = "DE";
		protected const string CountryCodeItaly = "IT";
		
		protected string SelectedCountryCode = CountryCodeUk;
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

			var selectedLanguage = countryCode == CountryCodeUk ? "en" : SelectedCountryCode.ToLower();
			await OnLanguageSelected.InvokeAsync(selectedLanguage);
		}

		protected override void OnInitialized()
		{
			base.OnInitialized();

			var currentUri = NavigationManager.Uri.Trim();

			if (currentUri.EndsWith("/en") || currentUri.Contains("/en/"))
			{
				SelectedCountryCode = CountryCodeUk;
				return;
			}

			if (currentUri.EndsWith("/de") || currentUri.Contains("/de/"))
			{
				SelectedCountryCode = CountryCodeGermany;
				return;
			}

			if (currentUri.EndsWith("/it") || currentUri.Contains("/it/"))
			{
				SelectedCountryCode = CountryCodeItaly;
				return;
			}

			SelectedCountryCode = CountryCodeUk;
		}
	}
}
