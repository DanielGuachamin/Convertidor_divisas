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
    public partial class CanadienseLibra : ContentPage
    {
        double libraEster;
        double dolarCanad;

        public CanadienseLibra()
        {
            InitializeComponent();
        }
        public void Calcular()
        {
            libraEster = Convert.ToDouble(txt.Text);
            dolarCanad = Math.Round((libraEster * 0.640728), 2);
            reslbl.Text = dolarCanad.ToString() + " $";
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