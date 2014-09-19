using System;
using Xamarin.Forms;

namespace MobileBanking
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new NavigationPage(new  HomePage());
		}
	}
}

