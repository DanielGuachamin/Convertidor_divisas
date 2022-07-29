using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Convertidor;



namespace Convertidor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             MainPage = new NavigationPage(new MainPage());
            //MainPage = new Convertir();
            
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
