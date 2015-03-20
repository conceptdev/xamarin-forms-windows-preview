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

namespace Roget1911.WinApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage 
    {
        public MainPage()
        {
            this.InitializeComponent();

            #region copy xml into a place where PCLStorage can find it!
            CopyInfoIntoWorkingFolder("roget15aHierarchy.xml");
            CopyInfoIntoWorkingFolder("roget15aCategories.xml");
            #endregion

            LoadApplication(new Roget1911.App());
        }

        private async Task CopyInfoIntoWorkingFolder(string fileName)
        {
            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(
                 new Uri("ms-appx:///Assets/" + fileName));

            await file.CopyAsync(ApplicationData.Current.LocalFolder, fileName);
        }

    }
}
