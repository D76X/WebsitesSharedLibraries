using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Websites.Razor.ClassLibrary.Components
{
	// https://stackoverflow.com/questions/5427414/editing-a-git-submodule
	public class LanguageSelectorBase2 : ComponentBase
	{
		protected string SelectedCountryCode = "GB";
		protected string SelectedCountrySvg => $"{SelectedCountryCode.ToLower()}.svg";

		protected const string CountryCodeUk = "GB";
		protected const string CountryCodeGermany = "DE";
		protected const string CountryCodeItaly = "IT";

		[Inject]
		public NavigationManager NavigationManager { get; set; }

		[Parameter]
		public EventCallback<string> OnLanguageSelected { get; set; }

		protected void OnClickItem(string countryCode)
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
			//await OnLanguageSelected.InvokeAsync(selectedLanguage);
			NavigationManager.NavigateTo("/page1");
		}
	}
}
