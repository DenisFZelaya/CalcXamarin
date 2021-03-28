using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Calcular(object sender, EventArgs e)
        {
            if (n1.Text == "" && n2.Text == "")
            {
                resultado.Text = "Campos vacíos";
            }else
            {
                int N1 = Int32.Parse(n1.Text);
                int N2 = Int32.Parse(n2.Text);
                int Resultado = (N1 + N2);
                resultado.Text = Resultado.ToString();
            }
        }
    }
}
