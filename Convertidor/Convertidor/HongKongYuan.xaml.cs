using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Convertidor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HongKongYuan : ContentPage
    {
        double hongKong;
        double yuanChino;

        public HongKongYuan()
        {
            InitializeComponent();
        }
        public void Calcular()
        {
            hongKong = Convert.ToDouble(txt.Text);
            yuanChino = hongKong * 0.859070;
            reslbl.Text = yuanChino.ToString() + " ¥";
        }

        private void Validar()
        {
            if (!string.IsNullOrEmpty(txt.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }
        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validar();
        }
    }
}