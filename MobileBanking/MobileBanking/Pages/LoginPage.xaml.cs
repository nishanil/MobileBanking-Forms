using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileBanking
{	
	public partial class LoginPage : ContentPage
	{	
		public LoginPage ()
		{
			InitializeComponent ();
			BackgroundColor = Color.Blue.ToFormsColor ();
			BindingContext = new LoginPageViewModel (Navigation);
		}
	}
}

