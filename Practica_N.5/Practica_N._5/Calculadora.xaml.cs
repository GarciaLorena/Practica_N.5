using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_N._5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculadora : ContentPage
	{
        double dato1;
        double dato2;
        double resultado;
        string operacion;

        public Calculadora ()
		{

			InitializeComponent ();
		}
        private void Porcentaje_Clicked(object sender, EventArgs e)
        {
            operacion = "%";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void SQRT_Clicked(object sender, EventArgs e)
        {
            operacion = "SQRT";
            dato1 = double.Parse(caja.Text);
            resultado = dato1;
            caja.Text = Math.Sqrt(dato1).ToString();

        }

        private void Cuadrado_Clicked(object sender, EventArgs e)
        {
            operacion = "^2";
            dato1 = double.Parse(caja.Text);
            resultado = dato1;
            caja.Text = Math.Pow(dato1, 2).ToString();
        }

        private void Unosobrex_Clicked(object sender, EventArgs e)
        {

            operacion = "1/x";
            dato1 = double.Parse(caja.Text);
            resultado = 1 / dato1;
            caja.Text = resultado.ToString();

        }

        private void Ce_Clicked(object sender, EventArgs e)
        {
            caja.Text = "";

        }
        private void C_Clicked(object sender, EventArgs e)
        {
            caja.Text = "";
        }

        private void Siete_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "7";
        }

        private void Ocho_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "8";
        }

        private void Nueve_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "9";
        }

        private void Cuatro_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "4";
        }

        private void Cinco_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "5";
        }

        private void Seis_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "6";
        }



        private void Uno_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "1";
        }

        private void Dos_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "2";
        }

        private void Tres_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "3";
        }

        private void Masmenos_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "+/-";
        }

        private void Suma_Clicked(object sender, EventArgs e)
        {
            operacion = "+";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";

        }

        private void Cero_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "0";
        }

        private void Punto_Clicked(object sender, EventArgs e)
        {
            if (caja.Text == "")
            {
                caja.Text = caja.Text + ".";
            }
            else
            {
                caja.Text = ".";
            }

        }

        private void Igual_Clicked(object sender, EventArgs e)
        {

            dato2 = double.Parse(caja.Text);
            switch (operacion)
            {
                case "+":
                    resultado = dato1 + dato2;
                    caja.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = dato1 - dato2;
                    caja.Text = resultado.ToString();
                    break;
                case "x":
                    if (dato2 == 0)
                    {
                        caja.Text = "NUMERO NO SE PUEDE MULTIPLICAR POR 0";
                    }
                    else
                    {

                        resultado = dato1 * dato2;
                        caja.Text = resultado.ToString();
                    }

                    break;
                case "/":
                    if (dato2 == 0)
                    {
                        caja.Text = "NUMERO NO SE PUEDE DIVIDIR ENTRE 0";
                    }
                    else
                    {

                        resultado = dato1 / dato2;
                        caja.Text = resultado.ToString();
                    }

                    break;
                case "%":
                    resultado = dato1 * dato2 / 100;
                    caja.Text = resultado.ToString();
                    break;

            }
        }

        private void Divicion_Clicked(object sender, EventArgs e)
        {
            operacion = "/";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void Multiplicacion_Clicked(object sender, EventArgs e)
        {
            operacion = "x";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void R_Clicked(object sender, EventArgs e)
        {
            caja.Text = "";
        }

        private void Resta_Clicked(object sender, EventArgs e)
        {
            operacion = "-";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }
 }
}