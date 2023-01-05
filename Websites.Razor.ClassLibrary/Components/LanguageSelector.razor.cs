using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Websites.Razor.ClassLibrary.Components
{
	public class LanguageSelectorBase: ComponentBase
	{
		protected string SelectedCountryCode = "GB";
		protected string SelectedCountrySvg => $"{SelectedCountryCode.ToLower()}.svg";

		protected const string CountryCodeUk = "GB";
		protected const string CountryCodeGermany = "DE";
		protected const string CountryCodeItaly = "IT";

		protected void OnClickItem(
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
		}
	}
}
