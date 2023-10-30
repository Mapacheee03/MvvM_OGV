using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MvvM_Implementacion_OGV.Vistas;

namespace MvvM_Implementacion_OGV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Page1());
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
