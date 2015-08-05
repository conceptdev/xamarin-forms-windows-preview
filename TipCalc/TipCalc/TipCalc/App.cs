using System;
using Xamarin.Forms;

namespace TipCalc
{
	public class App : Application // superclass new in 1.3
	{
		public App ()
		{
            var x = new TipCalcPage();
            MainPage = (Page)x;
        }
    }
}
