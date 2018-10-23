using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMVC.DTO
{
	class DatosUsuarioDTO
	{

		public double Operando1 { get; set; }
		public double Operando2 { get; set; }

		public char Operacion { get; set; }

		public DatosUsuarioDTO(double oper1, double oper2, char simOper)
		{
			this.Operando1 = oper1;
			this.Operando2 = oper2;
			this.Operacion = simOper;
		}
	}
}
