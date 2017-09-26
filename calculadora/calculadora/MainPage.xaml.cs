using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {
        double dato1;
        double dato2;
        double resultado;
        string operacion;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Porcentaje(object sender, EventArgs e)
        {
            operacion = "%";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void sqrt(object sender, EventArgs e)
        {
            operacion = "SQRT";
            
            if (dato1 == -dato1)
            {
                caja.Text = "no hay raiz negativa";
            }
            else
            {
                dato1 = double.Parse(caja.Text);
                resultado = dato1; 
                caja.Text = Math.Sqrt(dato1).ToString();
            }

        }

        private void Cuadrado(object sender, EventArgs e)
        {
            operacion = "^2";
            dato1 = double.Parse(caja.Text);
            resultado = dato1;
            caja.Text = Math.Pow(dato1, 2).ToString();
        }

        private void Unox(object sender, EventArgs e)
        {

            ///operacion = "1/x";
            ///dato1 = double.Parse(caja.Text);
            ///resultado = 1 / dato1;
            ///caja.Text = resultado.ToString();

        }

        private void CE(object sender, EventArgs e)
        {
            caja.Text = "";

        }
        private void C(object sender, EventArgs e)
        {
            caja.Text = "";
        }

        private void Siete(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "7";
        }

        private void Ocho(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "8";
        }

        private void Nueve(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "9";
        }

        private void Cuatro(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "4";
        }

        private void Cinco(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "5";
        }

        private void Seis(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "6";
        }

        private void Uno(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "1";
        }

        private void Dos(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "2";
        }

        private void Tres(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "3";
        }

        private void Masmen(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "-";
        }

        private void Suma(object sender, EventArgs e)
        {
            operacion = "+";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";

        }

        private void Cero(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "0";
        }

        private void Punto(object sender, EventArgs e)
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

        private void Igual(object sender, EventArgs e)
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
                        caja.Text = "numero multiplicado por cero es 0";
                    }
                    else
                    {
                        caja.Text = "";
                        resultado = dato1 * dato2;
                        caja.Text = resultado.ToString();
                    }
      
                    break;
                case "/":
                    if (dato2 == 0)
                    {
                        caja.Text = "no se puede dividir entre 0";
                    }
                    else
                    {
                        caja.Text = "";
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
        private void Divicion(object sender, EventArgs e)
        {
            operacion = "/";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void Multiplicacion(object sender, EventArgs e)
        {
            operacion = "x";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void R(object sender, EventArgs e)
        {
            caja.Text = "";
        }

        private void Resta(object sender, EventArgs e)
        {
            operacion = "-";
            dato1 = double.Parse(caja.Text);
            caja.Text = "";
        }
    } 
        
}

