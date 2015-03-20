using System;
using Xamarin.Forms;

namespace Roget1911
{
	public class CategoryListPage : ContentPage
	{
		ListView listView;
		public CategoryListPage (RogetSection section)
		{
			NavigationPage.SetHasNavigationBar (this, true);
            if (Device.OS != TargetPlatform.Windows)
            { // HACK: this doesn't look right on Windows
                listView = new ListView { RowHeight = 40 };
            }
            else
            {
                listView = new ListView();
            }

			var cats = App.XmlData.Categories.GetRange (section.StartCategory, section.EndCategory);

			listView.ItemsSource = cats;
			listView.ItemTemplate = new DataTemplate (typeof (TextCell)) {
				Bindings = {
					{ TextCell.TextProperty, new Binding ("Name") }
				}
			};

			listView.ItemSelected += (sender, e) => {
				if (e.SelectedItem == null) return;
				listView.SelectedItem = null; // clear out for next rendering of list

				var cat = (RogetCategory)e.SelectedItem;
				var posPage = new PartsOfSpeechPage(cat);
				posPage.Title = cat.Name;
				Navigation.PushAsync(posPage);
			};

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {listView}
			};

		}
	}
}

