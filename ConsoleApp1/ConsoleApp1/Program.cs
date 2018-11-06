using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMVC
{
	class Program
	{
		static void Main(string[] args)
		{
			#region calculadoraXconsola
			/*
			//INICIALIZACIONES
			int opcion = -1;
			double resultado = 0;

			double operando1 = 0;
			double operando2 = 0;

			VISTA.ConsolaCalc salidaConsola = new VISTA.ConsolaCalc();

			//Menú usuario (Bucle que acaba sólo al elegir "salida" -opción 6-)
			do
			{

				BLL.ControladorBLL controlador = new BLL.ControladorBLL();
				salidaConsola.Menu();
				opcion = Int32.Parse(Console.ReadLine().Trim()); //Recoge opción elegida por usuario

				//Lógica según opción elegida
				switch (opcion)
				{
					case 1: //suma

						salidaConsola.SalidaConsola(1, 0);
						operando1 = Int32.Parse(Console.ReadLine().Trim());

						salidaConsola.SalidaConsola(2, 0);
						operando2 = Int32.Parse(Console.ReadLine().Trim());

						// llamada a ControladorBLL para gestión operación (retorna resultado)
						resultado = controlador.gestionOperacion(operando1, operando2, '+');

						if (resultado == double.MinValue)
						{
							salidaConsola.SalidaConsola(6, 0);
						}
						else
						{
							salidaConsola.SalidaConsola(4, resultado);
						}

						break;

					case 2: //resta

						salidaConsola.SalidaConsola(1, 0);
						operando1 = Int32.Parse(Console.ReadLine().Trim());

						salidaConsola.SalidaConsola(2, 0);
						operando2 = Int32.Parse(Console.ReadLine().Trim());

						// llamada a ControladorBLL para gestión operación (retorna resultado)
						resultado = controlador.gestionOperacion(operando1, operando2, '-');

						if (resultado == double.MinValue)
						{
							salidaConsola.SalidaConsola(6, 0);
						}
						else
						{
							salidaConsola.SalidaConsola(4, resultado);
						}
						break;

					case 3: //producto

						salidaConsola.SalidaConsola(1, 0);
						operando1 = Int32.Parse(Console.ReadLine().Trim());

						salidaConsola.SalidaConsola(2, 0);
						operando2 = Int32.Parse(Console.ReadLine().Trim());

						// llamada a ControladorBLL para gestión operación (retorna resultado)
						resultado = controlador.gestionOperacion(operando1, operando2, '*');

						if (resultado == double.MinValue)
						{
							salidaConsola.SalidaConsola(6, 0);
						}
						else
						{
							salidaConsola.SalidaConsola(4, resultado);
						}
						break;

					case 4: //cociente

						salidaConsola.SalidaConsola(1, 0);
						operando1 = Double.Parse(Console.ReadLine().Trim());

						salidaConsola.SalidaConsola(2, 0);
						operando2 = Double.Parse(Console.ReadLine().Trim());

						// llamada a ControladorBLL para gestión operación (retorna resultado)
						resultado = controlador.gestionOperacion(operando1, operando2, '/');
						if (resultado == double.MaxValue)
						{
							salidaConsola.SalidaConsola(3, 0);
						}
						else
						{

							if (resultado == double.MinValue)
							{
								salidaConsola.SalidaConsola(6, 0);

							}
							else
							{
								salidaConsola.SalidaConsola(4, resultado);
							}
						}
						break;

					case 5: //resto

						salidaConsola.SalidaConsola(1, 0);
						operando1 = Int32.Parse(Console.ReadLine().Trim());

						salidaConsola.SalidaConsola(2, 0);
						operando2 = Int32.Parse(Console.ReadLine().Trim());

						// llamada a ControladorBLL para gestión operación (retorna resultado)
						resultado = controlador.gestionOperacion(operando1, operando2, '%');

						if (resultado == double.MinValue)
						{
							salidaConsola.SalidaConsola(6, 0);
						}
						else
						{
							salidaConsola.SalidaConsola(4, resultado);
						}
						break;

					case 6: //historial

						//llamada a VISTA para enseñar historial (método mostrar historial)

						break;

					case 7: //salir
						break;

					default: //si el número introducido no es una de las opciones
						salidaConsola.SalidaConsola(5, 0);
						break;
				}

			} while (opcion != 6);

	*/

			#endregion

			//ConsoleApp1.VO.InterfazCalcMVC interfaz = new ConsoleApp1.VO.InterfazCalcMVC();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ConsoleApp1.VO.InterfazCalcMVC());
		}
	}
}
