using System;
using Xamarin.Forms;

namespace WorkingWithPopups
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
            if (Device.Idiom == TargetIdiom.Phone && Device.OS == TargetPlatform.Windows)
            { // HACK: TabbedPage not working on Windows Phone
                MainPage = new AlertPage();
                return;
            }
			var tabs = new TabbedPage ();
			tabs.Children.Add(new AlertPage { Title = "Alerts", Icon="csharp.png"});
			tabs.Children.Add(new ActionSheetPage {Title = "ActionSheets", Icon="csharp.png"});
			MainPage = tabs;
		}
	}
}

