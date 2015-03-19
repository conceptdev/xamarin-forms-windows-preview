using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace EmployeeDirectory.WinApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            this.InitializeComponent();

            //HACK: this is super-dodgy, sorry!
          //  CopyInfoIntoWorkingFolder("XamarinDirectory.csv");
          //  CopyInfoIntoWorkingFolder("XamarinFavorites.xml");

            LoadApplication(new EmployeeDirectoryUI.App());
        }

        private async Task CopyInfoIntoWorkingFolder(string fileName)
        {
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(
                 new Uri("ms-appx:///Assets/" + fileName));

            await file.CopyAsync(ApplicationData.Current.LocalFolder, fileName);
        }
    }
}
