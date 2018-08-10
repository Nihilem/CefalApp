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
	public partial class Page4 : ContentPage
	{

		public Page4 ()
		{
			InitializeComponent ();
            var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            var btn0 = new Button {};
            var btn1 = new Button { };
            var btn2 = new Button { };
            var btn3 = new Button { };
            var btn4 = new Button { };
            var btn5 = new Button { };
            grid.Children.Add(btn0, 0, 0);
            grid.Children.Add(btn1, 0, 1);
            grid.Children.Add(btn2, 0, 2);
            grid.Children.Add(btn3, 1, 0);
            grid.Children.Add(btn4, 1, 1);
            grid.Children.Add(btn5, 1, 2);
            var image = new Image { Source = "waterfront.jpg" };

        }
	}
}