using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Convertir : ContentPage
    {
        double ester;
        double dolar;
        double euro;
       
        public Convertir()
        {
            InitializeComponent();
            
            ceoPicker.Items.Add(" Dolar ");
            ceoPicker.Items.Add(" Euro ");
            ceoPicker.Items.Add(" Libra esterlina");

            ceoPicker2.Items.Add(" Dolar ");
            ceoPicker2.Items.Add(" Euro ");
            ceoPicker2.Items.Add(" Libra esterlina ");


        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
            // Navigation.PushAsync(new MainPage());
        }


        public void Dolar_Euro()
        {
            dolar = Convert.ToDouble(txtcm.Text);

            euro = dolar * 1.01624;

            reslbl.Text = euro.ToString() + " EUR";

        }

        

        public void Euro_Dolar()
        {
            euro = Convert.ToDouble(txtcm.Text);

            dolar = euro / 0.98130;

            reslbl.Text = dolar.ToString() + " USD";

        }

        public void Dolar_Esterlina()
        {
            dolar = Convert.ToDouble(txtcm.Text);

            ester = dolar * 0.82354651;

            reslbl.Text = ester.ToString() + " GBP";

        }

        public void Esterlina_Dolar()
        {
            ester = Convert.ToDouble(txtcm.Text);

            dolar = ester * 1.2146601;

            reslbl.Text = dolar.ToString() + " USB";

        }


        private void ceoPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectOpe = ceoPicker.SelectedIndex;
            var selectOpe2 = ceoPicker2.SelectedIndex;

            if(selectOpe == selectOpe2)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    reslbl.Text = txtcm.Text;
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 0 && selectOpe2 == 1)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    Dolar_Euro();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
                
            }
            else if (selectOpe == 1 && selectOpe2 == 0)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    Euro_Dolar();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
                
            }
            else if (selectOpe == 0 && selectOpe2 == 2)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    Dolar_Esterlina();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 2 && selectOpe2 == 0)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    Esterlina_Dolar();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
        }
    }
}