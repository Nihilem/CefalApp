using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleLogin.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{

		public Page1 ()
		{
			InitializeComponent ();
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            var entry0 = new Entry {};
            var label0 = new Label { Text = "Days without migrane" };
            var entry1 = new Entry {};
            var label1 = new Label { Text = "Hours of sleep" };
            var entry2 = new Entry {};
            var label2 = new Label { Text = "Phone usage time" };
            grid.Children.Add(label0, 0, 0);
            grid.Children.Add(entry0, 0, 1);
            grid.Children.Add(label1, 1, 0);
            grid.Children.Add(entry1, 1, 1);
            grid.Children.Add(label2, 2, 0);
            grid.Children.Add(entry2, 2, 1);
            var image = new Image { Source = "waterfront.jpg" };

        }
	}
}