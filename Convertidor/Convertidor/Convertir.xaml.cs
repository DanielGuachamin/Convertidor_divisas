using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Convertidor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double euro;
        double dolar;

        public Convertir()
        {
            InitializeComponent();
        }
        public void Calcular() {
            euro = Convert.ToDouble(txt.Text);
            dolar = Math.Round((euro * 1.02255), 2);
            reslbl.Text = dolar.ToString() +" $";
        }

        private void Validar() {
            if (!string.IsNullOrEmpty(txt.Text)) { 
                Calcular();
            } 
            else 
            { 
                DisplayAlert("Error", "Ingrese una cantidad","OK"); }
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