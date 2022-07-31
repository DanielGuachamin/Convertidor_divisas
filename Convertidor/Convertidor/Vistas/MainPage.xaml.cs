using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Convertidor
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Euro_Dolar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Convertir());
        }

        private void Button_Libra_Canad(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CanadienseLibra());
        }

        private void Button_Austra_Yen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new YenAustraliano());
        }

        private void Button_Rupia_Neoze(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NeolanRupia());
        }

        private void Button_Rublo_FrancoS(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FrancoRublo());
        }

        private void Button_HongK_Yuan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HongKongYuan());
        }
    }
}
