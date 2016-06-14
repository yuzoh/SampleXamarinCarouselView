using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SampleXamarinCarouselView
{
	public partial class SampleXamarinCarouselViewPage : ContentPage
	{
		class ViewModel : BindableObject
		{
			public ObservableCollection<ListData> ListData { get; set; }
		}

		class ListData
		{
			public String Title { get; set; }
		}

		public SampleXamarinCarouselViewPage()
		{
			InitializeComponent();

			ObservableCollection<ViewModel> items = new ObservableCollection<ViewModel>();
			ViewModel item;

			item = new ViewModel();
			item.ListData = new ObservableCollection<ListData>();
			item.ListData.Add(new ListData { Title = "test01" });
			item.ListData.Add(new ListData { Title = "test02" });
			item.ListData.Add(new ListData { Title = "test03" });
			items.Add(item);

			item = new ViewModel();
			item.ListData = new ObservableCollection<ListData>();
			item.ListData.Add(new ListData { Title = "test11" });
			item.ListData.Add(new ListData { Title = "test12" });
			item.ListData.Add(new ListData { Title = "test13" });
			items.Add(item);

			BindingContext = items;
		}

		void CarouselPositionSelected(object sender, SelectedPositionChangedEventArgs e)
		{
			CarouselView view = (CarouselView)sender;
			lbl1.TextColor = Color.Black;
			lbl2.TextColor = Color.Black;
			if (view.Position == 0)
			{
				lbl1.TextColor = Color.Red;
			}
			else 
			{
				lbl2.TextColor = Color.Red;
			}
		}

	}
}

