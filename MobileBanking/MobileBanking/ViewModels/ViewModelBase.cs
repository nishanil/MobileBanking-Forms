using System;
using Xamarin.Forms;

namespace MobileBanking
{
	public class ViewModelBase : ObservableObject
	{
		private INavigation navigation;
		public INavigation Navigation {
			get {return navigation; }
			set { navigation = value; OnPropertyChanged (); }
		}

		public string Title {
			get;
			set;
		}
	}
}

