using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace MobileBanking
{
	public class HomePageViewModel : ViewModelBase
	{
		public ICommand FundsTranferCommand {
			get;
			set;
		}
		public HomePageViewModel (INavigation navigation)
		{
			Navigation = navigation;
			FundsTranferCommand = new Command (async()=>{
				if(Navigation!=null)
					await Navigation.PushAsync(new FundsTransferPage());
			});
		}
	}
}

