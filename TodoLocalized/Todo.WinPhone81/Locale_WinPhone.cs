using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(TodoLocalized.WinPhone.Locale_WinPhone))]

namespace TodoLocalized.WinPhone
{
    public class Locale_WinPhone : TodoLocalized.ILocale
    {
        /// <remarks>
        /// Not sure if we can cache this info rather than querying every time
        /// </remarks>
        public string GetCurrent()
        {
            var lang = System.Globalization.CultureInfo.CurrentUICulture.Name;
            var culture = System.Globalization.CultureInfo.CurrentCulture.Name;
            return lang;
        }


        public void SetLocale()
        {
           
            //System.Globalization.CultureInfo ci;
            //try
            //{
            //    ci = new System.Globalization.CultureInfo(netLocale);
            //}
            //catch
            //{
            //    ci = new System.Globalization.CultureInfo(GetCurrent());
            //}
            Debug.WriteLine("culture: " + System.Globalization.CultureInfo.CurrentCulture.Name);
            Debug.WriteLine("ui:      " + System.Globalization.CultureInfo.CurrentUICulture.Name);
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;
            
        }
    }
}
