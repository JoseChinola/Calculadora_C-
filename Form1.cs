using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForms
{
    public enum Operacion
    {
        Nodefinida = 0,
        Suma = 1,
        Resta = 2,
        Division = 3,
        Multiplicacion = 4,
        Modulo = 5
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.Nodefinida;
        bool unNumeroLeido = false;
        public Form1()
        {
            InitializeComponent();

            
        }


        private void LeerNumero(string numero)
        {
            unNumeroLeido = true;
            if (txtResultado.Text == "0" && txtResultado.Text != null)
            {
                txtResultado.Text = numero;
            }
            else

            {
                txtResultado.Text += numero;
            }
        }

        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case Operacion.Suma:
                    resultado = valor1 + valor2;
                    break;
                case Operacion.Resta:
                    resultado = valor1 - valor2;
                    break;
                case Operacion.Division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0", "Ok");
                        
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case Operacion.Multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case Operacion.Modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }

        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(txtResultado.Text);
            lblHistorial.Text = txtResultado.Text + operador;
            txtResultado.Text = "0";
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            unNumeroLeido = true;
            if(txtResultado.Text == "0")
            {
                return;
            }
            else
            {
                txtResultado.Text += "0";
            }
            
        }

        private void lblHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");

        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");

        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            lblHistorial.Text = "";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if(valor2 == 0 && unNumeroLeido )
            {
                valor2 = Convert.ToDouble(txtResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                unNumeroLeido = false;
                txtResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Length > 1)
            {
                string ttresultado = txtResultado.Text;
                ttresultado = ttresultado.Substring(0, ttresultado.Length - 1);

                if (ttresultado.Length == 1 && ttresultado.Contains("-"))
                {
                    txtResultado.Text = "0";
                }
                else
                {
                    txtResultado.Text = ttresultado;
                }

                
            }
            else
            {
                txtResultado.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Contains("."))
            {
                return;
            }

            txtResultado.Text += ".";
        }
    }
}
