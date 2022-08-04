﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo;

namespace Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Convertir();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
