using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMVC.BLL
{
	class ControladorBLL
	{

		//método para llamar a clase aritmética pasando datos usuario (devuelve resultado)
		public double gestionOperacion(double operando1, double operando2, char operacion)
		{

			BLL.Operaciones.Aritmetica aritmetica = new BLL.Operaciones.Aritmetica();
			DTO.DatosUsuarioDTO datosUsuario = new DTO.DatosUsuarioDTO(operando1, operando2, operacion); ;
			double resultado;

			switch (datosUsuario.Operacion)
			{
				case '+':
					resultado = aritmetica.SumarDosOperandos(datosUsuario.Operando1, datosUsuario.Operando2);
					return resultado;

				case '-':
					resultado = aritmetica.RestarDosOperandos(datosUsuario.Operando1, datosUsuario.Operando2);
					return resultado;

				case '*':
					resultado = aritmetica.MultiplicarDosOperandos(datosUsuario.Operando1, datosUsuario.Operando2);
					return resultado;

				case '/':
					resultado = aritmetica.DividirDosOperandos(datosUsuario.Operando1, datosUsuario.Operando2);
					return resultado;

				case '%':
					resultado = aritmetica.RestoDosOperandos(datosUsuario.Operando1, datosUsuario.Operando2);
					return resultado;
			}

			return double.MinValue;
		}
	}
}
