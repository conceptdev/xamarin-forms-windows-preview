using System;
using Xamarin.Forms;

namespace WorkingWithFiles
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
            if (Device.OS == TargetPlatform.Windows && Device.Idiom == TargetIdiom.Phone) 
            { // HACK: TabbedPage isn't working on Windows Phone 81
                MainPage = new LoadResourceText();
                //MainPage = new LoadResourceXml();
                //MainPage = new SaveAndLoadText();
                return;
            }

			var tabs = new TabbedPage ();
            tabs.Children.Add (new LoadResourceText {Title = "Resource", Icon = "txt.png" });
            tabs.Children.Add (new LoadResourceXml {Title = "Resource", Icon = "xml.png"});
            tabs.Children.Add (new SaveAndLoadText {Title = "Save/Load", Icon = "saveload.png"});
            MainPage = tabs;
		}
	}
}

