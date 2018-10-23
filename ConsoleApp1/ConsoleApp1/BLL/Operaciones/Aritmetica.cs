using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMVC.BLL.Operaciones
{
	class Aritmetica
	{

		public double SumarDosOperandos(double op1, double op2)
		{

			double resultado = op1 + op2;

			return resultado;
		}

		public double RestarDosOperandos(double op1, double op2)
		{

			double resultado = op1 - op2;

			return resultado;
		}

		public double MultiplicarDosOperandos(double op1, double op2)
		{

			double resultado = op1 * op2;

			return resultado;
		}

		public double DividirDosOperandos(double op1, double op2)
		{

			//Control posible división entre 0
			if (op2 == 0.0)
			{
				double warning = double.MaxValue;
				return warning;

			}
			else
			{
				double resultado = op1 / op2;
				return resultado;
			}
		}

		public double RestoDosOperandos(double op1, double op2)
		{

			double resultado = op1 % op2;

			return resultado;
		}
	}
}
