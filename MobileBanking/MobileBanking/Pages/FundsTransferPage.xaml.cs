using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileBanking
{	
	public partial class FundsTransferPage : ContentPage
	{	
		public FundsTransferPage ()
		{
			InitializeComponent ();
			Title = "Funds";
			BindingContext = new FundsTransferViewModel (Navigation, this);
		}
	}
}

