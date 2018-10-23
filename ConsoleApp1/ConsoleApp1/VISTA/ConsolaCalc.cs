using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMVC.VISTA
{
	class ConsolaCalc
	{

		public void SalidaConsola(int imprimir, double resultado)
		{

			switch (imprimir)
			{

				case 1:
					Console.WriteLine("Elija operando 1: ");
					break;
				case 2:
					Console.WriteLine("Elija operando 2: ");
					break;
				case 3:
					Console.WriteLine("¡Imposible dividir entre cero!");
					break;
				case 4:
					Console.WriteLine("El resultado es: " + resultado);
					break;
				case 5:
					Console.WriteLine("Debe elegir una opción válida (1 al 7)");
					break;
				case 6:
					Console.WriteLine("¡Error Interno!");
					break;
			}
		}

		public void Menu()
		{

			Console.WriteLine("---CALCULADORA SIMPLE---" + "\n"
				+ "Elija operación a ejecutar: " + "\n"
				+ "1. Suma" + "\n"
				+ "2. Resta" + "\n"
				+ "3. Producto" + "\n"
				+ "4. Cociente" + "\n"
				+ "5. Resto" + "\n"
				+ "6. Historial de operaciones" + "\n"
				+ "7. Salir" + "\n");
		}

		public void MostrarHistorial()
		{

		}
	}
}
