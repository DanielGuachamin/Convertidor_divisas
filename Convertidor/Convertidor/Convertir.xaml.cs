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
    public partial class Convertir : ContentPage
    {
        double cm;
        double m;

        public Convertir()
        {
            InitializeComponent();
        }
        public void Calcular() { 
            cm=Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            reslbl.Text = m.ToString() +" m";
        }

        private void validar() {
            if (!string.IsNullOrEmpty(txtcm.Text)) { 
                Calcular();
            } 
            else 
            { 
                DisplayAlert("Error", "Ingrese una cantidad","OK"); }
        }
        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            //Navigation.PopAsync();
            Navigation.PushAsync(new MainPage());
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}