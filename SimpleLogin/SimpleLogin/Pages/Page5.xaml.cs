﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleLogin.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
        
            Dictionary<string, Color> medicine = new Dictionary<string, Color>
            {
                { "Oki", Color.Aqua },
                { "Efedrina", Color.Black },
                { "Ibuprofene", Color.Blue },
                { "Metedrina", Color.Yellow },
                { "Aulin", Color.Gray },
                { "Isopimpenellina", Color.Green },
                { "Tachipirina", Color.Lime }, 
                { "Pevaril", Color.Navy }, 
                { "Agumentin", Color.Purple },
                { "Ketoprofene", Color.Silver },
                { "Teal", Color.Teal },
                { "Metadone", Color.White }
            };

		public Page5 ()
		{
            InitializeComponent();
            Label rotationLabel = new Label
            {
                Text = "ROTATING TEXT",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Label displayLabel = new Label
            {
                Text = "(uninitialized)",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Slider slider = new Slider
            {
                Maximum = 360
            };
            slider.ValueChanged += (sender, args) =>
            {
                rotationLabel.Rotation = slider.Value;
                displayLabel.Text = String.Format("The Slider value is {0}", args.NewValue);
            };

            Label header = new Label
            {
                Text = "Medicine",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Picker picker = new Picker
            {
                Title = "Medicine",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            foreach (string medicineName in medicine.Keys)
            {
                picker.Items.Add(medicineName);
            }

            var grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var btn0 = new Button { };
            var btn1 = new Button { };
            var btn2 = new Button { };
            var btn3 = new Button { };
            var btn4 = new Button { };
            var btn5 = new Button { };
            var btn6 = new Button { };
            var btn7 = new Button { };

            grid.Children.Add(slider, 0, 2);
            grid.Children.Add(btn0, 1, 0);
            grid.Children.Add(btn1, 1, 1);

            grid.Children.Add(btn2, 2, 0);
            grid.Children.Add(btn3, 2, 1);
            grid.Children.Add(btn4, 2, 2);

            grid.Children.Add(btn5, 3, 0);
            grid.Children.Add(btn6, 3, 1);
            grid.Children.Add(btn7, 3, 2);

            grid.Children.Add(picker, 4, 0);
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }


}