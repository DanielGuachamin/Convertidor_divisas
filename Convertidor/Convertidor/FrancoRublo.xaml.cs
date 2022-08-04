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
    public partial class FrancoRublo : ContentPage
    {
        double rubloRuso;
        double francoSuizo;

        public FrancoRublo()
        {
            InitializeComponent();
        }
        public void Calcular()
        {
            rubloRuso = Convert.ToDouble(txt.Text);
            francoSuizo = Math.Round((rubloRuso * 0.0153243), 2);
            reslbl.Text = francoSuizo.ToString() + " Fr";
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