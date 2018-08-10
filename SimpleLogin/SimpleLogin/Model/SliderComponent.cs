﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SimpleLogin.Model
{
    public class SliderComponent : ContentPage
    {
        public SliderComponent()
        {
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

            Title = "Basic Slider Code";
            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children =
            {
                rotationLabel,
                slider,
                displayLabel
            }
            };
        }
    }
}
