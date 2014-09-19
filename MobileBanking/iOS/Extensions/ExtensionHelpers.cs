using System;
using MonoTouch.UIKit;

namespace MobileBanking
{
	public static class ExtensionHelpers
	{
		public static UIColor ToUIColor (this Color color)
		{
			return UIColor.FromRGB ((float)color.R, (float)color.G, (float)color.B);
		} 
	}
}

