using System;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.Threading;

[assembly: Xamarin.Forms.Dependency(typeof(UsingResxLocalization.WinApp.Localize))]

namespace UsingResxLocalization.WinApp
{
    public class Localize : UsingResxLocalization.ILocalize
    {
        public void SetLocale()
        {
            //
        }

        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            return System.Globalization.CultureInfo.CurrentUICulture;
        }
    }
}

