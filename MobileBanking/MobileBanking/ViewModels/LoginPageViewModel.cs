using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileBanking
{
	public class LoginPageViewModel : ViewModelBase
	{
		public ICommand LoginCommand {
			get;
			set;
		}

		public LoginPageViewModel (INavigation navigation)
		{
			Navigation = navigation;
			LoginCommand = new Command (async()=>{
				if(navigation!=null)
					await Navigation.PopModalAsync();
			});

		}
	}
}

