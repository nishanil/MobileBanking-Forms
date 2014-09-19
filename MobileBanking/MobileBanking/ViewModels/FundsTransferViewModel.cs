using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace MobileBanking
{
	public class FundsTransferViewModel : ViewModelBase
	{
		public ICommand CancelCommand {
			get;
			set;
		}
		public ICommand TransferCommand {
			get;
			set;
		}

		public FundsTransferViewModel (INavigation navigation, Page currentPage)
		{
			Navigation = navigation;
			CancelCommand = new Command(async () => await Navigation.PopAsync());
			TransferCommand = new Command(async () => await currentPage.DisplayAlert("Transfer", "Success", "Ok"));

		}
	}
}

