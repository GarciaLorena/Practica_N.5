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
	public partial class Formulario : ContentPage
	{
		public Formulario ()
		{
			InitializeComponent ();
		}


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Datos Ingresados", "Bienvenido" + Nombre.Text + "\n" + Apellidos.Text + " " + Direccion.Text + " \n" + Telefono.Text + "\n " + Carrera.Text + " \n" + Semestre.Text + " \n" + Matricula.Text + " \n" + Correo.Text + " \n" + Git_Hub.Text, " OK");
            ((NavigationPage)this.Parent).PushAsync(new Calculadora());
        }
    }
}