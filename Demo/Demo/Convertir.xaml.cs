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
        double pesoColombiano;
        double pesoChileno;

        public Convertir()
        {
            InitializeComponent();
            
            ceoPicker.Items.Add(" Dolar ");
            ceoPicker.Items.Add(" Euro ");
            ceoPicker.Items.Add(" Libra esterlina");

            ceoPicker.Items.Add(" Peso colombiando");
            ceoPicker.Items.Add(" Peso chileno");

            ceoPicker2.Items.Add(" Dolar ");
            ceoPicker2.Items.Add(" Euro ");
            ceoPicker2.Items.Add(" Libra esterlina ");

            ceoPicker2.Items.Add(" Peso colombiando");
            ceoPicker2.Items.Add(" Peso chileno");
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

            reslbl.Text = dolar.ToString() + " USD";

        }

        public void pesoColombiano_Dolar()
        {
            pesoColombiano = Convert.ToDouble(txtcm.Text);

            dolar = pesoColombiano * 0.000233;

            reslbl.Text = dolar.ToString() + " USD";

        }

        public void dolar_pesoColombiano()
        {
            dolar = Convert.ToDouble(txtcm.Text);

            pesoColombiano = dolar / 0.000233;

            reslbl.Text = pesoColombiano.ToString() + " pesos colombianos";

        }

        public void pesoColombiano_Libra()
        {
            pesoColombiano = Convert.ToDouble(txtcm.Text);

            ester = pesoColombiano * 0.000191;

            reslbl.Text = ester.ToString() + " GBP";

        }

        public void libra_pesoColombiano()
        {
            ester = Convert.ToDouble(txtcm.Text);

            pesoColombiano = ester / 0.000191;

            reslbl.Text = pesoColombiano.ToString() + " pesos colombianos";

        }

        public void pesoColombiano_Euro()
        {
            pesoColombiano = Convert.ToDouble(txtcm.Text);

            euro = pesoColombiano * 0.000227;

            reslbl.Text = euro.ToString() + " EUR";

        }

        public void euro_pesoColombiano()
        {
            euro = Convert.ToDouble(txtcm.Text);

            pesoColombiano = euro / 0.000227;

            reslbl.Text = pesoColombiano.ToString() + " pesos colombianos";

        }

        public void pesoChileno_Dolar()
        {
            pesoColombiano = Convert.ToDouble(txtcm.Text);

            dolar = pesoColombiano * 0.001109;

            reslbl.Text = dolar.ToString() + " USD";

        }

        public void dolar_pesoChileno()
        {
            dolar = Convert.ToDouble(txtcm.Text);

            pesoColombiano = dolar / 0.001109;

            reslbl.Text = pesoColombiano.ToString() + " pesos colombianos";

        }

        public void pesoChileno_Euro()
        {
            pesoChileno = Convert.ToDouble(txtcm.Text);

            euro = pesoChileno * 0.001082;

            reslbl.Text = euro.ToString() + " EUR";

        }

        public void euro_pesoChileno()
        {
            euro = Convert.ToDouble(txtcm.Text);

            pesoChileno = euro / 0.001082;

            reslbl.Text = pesoChileno.ToString() + " pesos chilenos";

        }

        public void pesoChileno_Libra()
        {
            pesoChileno = Convert.ToDouble(txtcm.Text);

            ester = pesoChileno * 0.000911;

            reslbl.Text = ester.ToString() + " GBP";

        }

        public void libra_pesoChileno()
        {
            ester = Convert.ToDouble(txtcm.Text);

            pesoChileno = ester / 0.000911;

            reslbl.Text = pesoChileno.ToString() + " pesos chilenos";

        }

        public void pesoChileno_PesoColombiano()
        {
            pesoChileno = Convert.ToDouble(txtcm.Text);

            pesoColombiano = pesoChileno * 4.761377;

            reslbl.Text = pesoColombiano.ToString() + " pesos colombianos";

        }

        public void pesoColombiano_pesoChileno()
        {
            pesoColombiano = Convert.ToDouble(txtcm.Text);

            pesoChileno = pesoColombiano / 4.761377;

            reslbl.Text = pesoChileno.ToString() + " pesos chilenos";

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
            else if (selectOpe == 3 && selectOpe2 == 0)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoColombiano_Dolar();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 0 && selectOpe2 == 3)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    dolar_pesoColombiano();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 3 && selectOpe2 == 2)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoColombiano_Libra();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 2 && selectOpe2 == 3)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    libra_pesoColombiano();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 3 && selectOpe2 == 1)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoColombiano_Euro();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 1 && selectOpe2 == 3)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    euro_pesoColombiano();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 4 && selectOpe2 == 0)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoChileno_Dolar();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 0 && selectOpe2 == 4)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    dolar_pesoChileno();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 4 && selectOpe2 == 1)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoChileno_Euro();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 1 && selectOpe2 == 4)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    euro_pesoChileno();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 4 && selectOpe2 == 2)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoChileno_Libra();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 2 && selectOpe2 == 4)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    libra_pesoChileno();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 4 && selectOpe2 == 3)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoChileno_PesoColombiano();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
            else if (selectOpe == 3 && selectOpe2 == 4)
            {
                if (!string.IsNullOrEmpty(txtcm.Text))
                {
                    pesoColombiano_pesoChileno();
                }
                else
                {
                    DisplayAlert("Error", "Ingrese una cantidad", "OK");
                }
            }
        }
    }
}