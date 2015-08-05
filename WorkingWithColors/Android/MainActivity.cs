using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;


namespace WorkingWithColors.Android
{
	[Activity (Label = "WorkingWithColors.Android.Android", MainLauncher = true)]
	public class MainActivity : FormsApplicationActivity // superclass new in 1.3
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication(new App()); // new in 1.3
		}
	}
}

