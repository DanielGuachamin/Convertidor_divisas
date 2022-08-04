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
    public partial class NeolanRupia : ContentPage
    {
        double rupiaIndia;
        double dolarNeoze;

        public NeolanRupia()
        {
            InitializeComponent();
        }
        public void Calcular()
        {
            rupiaIndia = Convert.ToDouble(txt.Text);
            dolarNeoze = Math.Round((rupiaIndia * 0.0201695), 2);
            reslbl.Text = dolarNeoze.ToString() + " NZ$";
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