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
	public partial class Page2 : ContentPage
	{

		public Page2 ()
		{
			InitializeComponent ();
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            var intensityLabel = new Label { Text = "Intensity" };
            var medicineLabel = new Label { Text = "Medicine" };
            var intensityValue = new Label { Text = "Strong" };
            var medicineValue = new Label { Text = "V" };
            grid.Children.Add(intensityValue, 0, 1);
            grid.Children.Add(medicineValue, 0, 2);
            grid.Children.Add(intensityLabel, 1, 1);
            grid.Children.Add(medicineLabel, 1, 2);
            var image = new Image { Source = "waterfront.jpg" };

        }


        async Task Handle_SlideCompletedAsync(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Page5());
        }

    }

}