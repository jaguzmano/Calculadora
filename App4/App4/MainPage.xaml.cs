using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Suma(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(N1.Text);
            double n2 = Convert.ToDouble(N2.Text);
            double result = n1 + n2;
            Rst.Text = "Resultado: " + result.ToString();
        }
        private void Btn_Resta(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(N1.Text);
            double n2 = Convert.ToDouble(N2.Text);
            double result = n1 - n2;
            Rst.Text = "Resultado: " + result.ToString();
        }

        private void Btn_Multiplicar(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(N1.Text);
            double n2 = Convert.ToDouble(N2.Text);
            double result = n1 * n2;
            Rst.Text = "Resultado: " + result.ToString();
        }

        private void Btn_Dividir(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(N1.Text);
            double n2 = Convert.ToDouble(N2.Text);

            if (n2 != 0)
            {
                double rst = n1 / n2;
                Rst.Text = "Resultado: " + rst.ToString();
            }
            else
            {
                Rst.Text = "No se puede dividir por cero";
            }
        }
    }
}
