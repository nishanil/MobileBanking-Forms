using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileBanking
{	
	public partial class HomePage : ContentPage
	{	
		public HomePage ()
		{
			InitializeComponent ();

			BindingContext = new HomePageViewModel (Navigation);
			ShowLoginDialog ();

			Title = "Mobile Banking";
		}

		async void ShowLoginDialog()
		{
			var page = new LoginPage();

			await Navigation.PushModalAsync(page);
		}
	}
}

