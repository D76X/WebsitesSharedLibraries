using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Websites.Razor.ClassLibrary.Components
{
	public class LanguageSelectorBase: ComponentBase
	{
		protected string SelectedCountryCode = "GB";

		protected const string CountryCodeUk = "GB";
		protected const string CountryCodeGermany = "DE";
		protected const string CountryCodeItaly = "IT";

		protected void OnChange(ChangeEventArgs e)
		{

		}

		protected void OnClick(MouseEventArgs e)
		{

		}

		protected void OnSelect(EventArgs e)
		{

		}

		protected void OnClickItem(MouseEventArgs e)
		{

		}
	}
}
