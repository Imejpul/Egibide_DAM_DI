using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1.VO
{
	public partial class InterfazCalcMVC : Form
	{
		public InterfazCalcMVC()
		{
			InitializeComponent();
		}

		//Inicializaciones
		CalculadoraMVC.BLL.ControladorBLL controlador = new CalculadoraMVC.BLL.ControladorBLL();

		string textoPantalla = string.Empty;
		bool comaIntroducida = false;
		bool borrar = false;
		bool resultadoDado = false;

		double operando1;
		double operando2;
		char operacion;
		double resultado;

		//Propias

			private bool comprobarSiOperacionIntroducida(string llamadaDe)
		{
			
			int indice = textBox1.GetFirstCharIndexOfCurrentLine();
			Point punto = textBox1.GetPositionFromCharIndex(textBox1.GetFirstCharIndexOfCurrentLine());
			char primerCaracter = textBox1.GetCharFromPosition(punto);


			if (primerCaracter.Equals('+') ||
				primerCaracter.Equals('-') ||
				primerCaracter.Equals('*') ||
				primerCaracter.Equals('/'))
			{
				if (llamadaDe.Equals("numero"))
				{
					textBox1.Text = string.Empty;					
				}
				return true;

			} else
			{
				return false;
			}
		}

		private bool comprobarSiNumeroDespuesComa()
		{
			if (!textBox1.Text.Equals(""))
			{
				char ultimoCaracter = textBox1.Text.Last();

				if (ultimoCaracter.Equals(','))
				{
					return false;
				}
				else
				{
					return true;
				}
			} else
			{
				return false;
			}
			

			
		}

		//OPERACIONES

		private void button1_Click(object sender, EventArgs e) //boton +
		{
			if (!resultadoDado && comprobarSiNumeroDespuesComa() && !comprobarSiOperacionIntroducida(" "))
			{
				operando1 = Double.Parse(textBox1.Text);
				operacion = '+';

				textBox1.Text = string.Empty;
				textBox1.Text += "+";
			}
						
		}

		private void botonResta_Click(object sender, EventArgs e)
		{
			if (!resultadoDado && comprobarSiNumeroDespuesComa() && !comprobarSiOperacionIntroducida(" "))
			{
				operando1 = Double.Parse(textBox1.Text);
				operacion = '-';

				textBox1.Text = string.Empty;
				textBox1.Text += "-";
			}
			
		}

		private void botonProducto_Click(object sender, EventArgs e)
		{
			if (!resultadoDado && comprobarSiNumeroDespuesComa() && !comprobarSiOperacionIntroducida(" "))
			{
				operando1 = Double.Parse(textBox1.Text);
				operacion = '*';

				textBox1.Text = string.Empty;
				textBox1.Text += "*";
			}
		}

		private void botonDivision_Click(object sender, EventArgs e)
		{
			if (!resultadoDado && comprobarSiNumeroDespuesComa() && !comprobarSiOperacionIntroducida(" "))
			{
				operando1 = Double.Parse(textBox1.Text);
				operacion = '/';

				textBox1.Text = string.Empty;
				textBox1.Text += "/";
			}
		}


		//NÚMEROS

		private void botonCero_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "0";
			}
		}

		private void botonUno_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "1";
			}
		}

		private void botonDos_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "2";
			}
		}

		private void botonTres_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "3";
			}
		}

		private void botonCuatro_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "4";
			}
		}

		private void botonCinco_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "5";
			}
		}

		private void botonSeis_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "6";
			}
		}

		private void botonSiete_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "7";
			}
		}

		private void botonOcho_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "8";
			}
		}

		private void botonNueve_Click(object sender, EventArgs e)
		{
			comprobarSiOperacionIntroducida("numero");
			if (!resultadoDado)
			{
				textBox1.Text += "9";
			}
		}

		//OTROS (COMA, IGUAL..)

		private void botonComa_Click(object sender, EventArgs e)
		{
			if (!comaIntroducida && !resultadoDado)
			{
				textBox1.Text += ",";
				comaIntroducida = true;
			}
			

		}

		
		private void botonC_igual_Click(object sender, EventArgs e) //boton doble función (borra o da el resultado)
		{
			if (comprobarSiNumeroDespuesComa())
			{
				if (!borrar && !comprobarSiOperacionIntroducida(" "))
				{
					//llamada a función gestionOperacion de ControladorBLL
					operando2 = Double.Parse(textBox1.Text);
					resultado = controlador.gestionOperacion(operando1, operando2, operacion);
					textBox1.Text = resultado.ToString();

					borrar = true;

					operando1 = 0;
					operando2 = 0;
					operacion = ' ';
					resultado = 0;
					resultadoDado = true;
				}
				else
				{
					textBox1.Text = string.Empty;
					borrar = false;
					resultadoDado = false;
					comaIntroducida = false;
				}
			}				
		}


	}
}
