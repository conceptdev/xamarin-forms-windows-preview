using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace WorkingWithGestures
{	
	public partial class TapInsideFrameXaml : ContentPage
	{
        int tapCount = 0;
		public TapInsideFrameXaml ()
		{
			InitializeComponent ();

			// The TapViewModel contains the TapCommand which is wired up in Xaml
			BindingContext = new TapViewModel ();
		}
	}
}

