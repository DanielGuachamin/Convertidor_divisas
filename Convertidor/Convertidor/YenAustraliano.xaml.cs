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
    public partial class YenAustraliano : ContentPage
    {
        double dolarAustr;
        double yenes;

        public YenAustraliano()
        {
            InitializeComponent();
        }
        public void Calcular()
        {
            dolarAustr = Convert.ToDouble(txt.Text);
            yenes = dolarAustr * 93.1972;
            reslbl.Text = yenes.ToString() + " ¥";
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