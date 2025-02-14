﻿using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace AwesomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        void The_Actual_Hour(object sender, System.EventArgs e)
        {
            string lafecha = DateTime.Now.ToString("hh:mm:ss");
            ((Button)sender).Text = $"The actual date is: {lafecha}";
        }
    }
}
