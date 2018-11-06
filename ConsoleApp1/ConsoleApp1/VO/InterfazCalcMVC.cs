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
		string textoPantalla = string.Empty;
		bool comaIntroducida = false;

		//OPERACIONES

		private void button1_Click(object sender, EventArgs e) //boton +
		{
			
		}

		private void botonResta_Click(object sender, EventArgs e)
		{

		}

		private void botonProducto_Click(object sender, EventArgs e)
		{

		}

		private void botonDivision_Click(object sender, EventArgs e)
		{

		}


		//NÚMEROS

		private void botonCero_Click(object sender, EventArgs e)
		{

			textBox1.Text += "0";
		}

		private void botonUno_Click(object sender, EventArgs e)
		{
			textBox1.Text += "1";
		}

		private void botonDos_Click(object sender, EventArgs e)
		{
			textBox1.Text += "2";
		}

		private void botonTres_Click(object sender, EventArgs e)
		{
			textBox1.Text += "3";
		}

		private void botonCuatro_Click(object sender, EventArgs e)
		{
			textBox1.Text += "4";
		}

		private void botonCinco_Click(object sender, EventArgs e)
		{
			textBox1.Text += "5";
		}

		private void botonSeis_Click(object sender, EventArgs e)
		{
			textBox1.Text += "6";
		}

		private void botonSiete_Click(object sender, EventArgs e)
		{
			textBox1.Text += "7";
		}

		private void botonOcho_Click(object sender, EventArgs e)
		{
			textBox1.Text += "8";
		}

		private void botonNueve_Click(object sender, EventArgs e)
		{
			textBox1.Text += "9";
		}

		//OTROS (COMA, IGUAL..)

		private void botonComa_Click(object sender, EventArgs e)
		{
			if (!comaIntroducida)
			{
				textBox1.Text += ",";
				comaIntroducida = true;
			}
			

		}

		private void botonC_igual_Click(object sender, EventArgs e)
		{

		}


		//TEXTBOX

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		//??

		private void InterfazCalcMVC_Load(object sender, EventArgs e)
		{

		}

		
	}
}
