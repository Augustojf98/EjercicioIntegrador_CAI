using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_CapaDatos.Exceptions
{
    public class FechaIngresoInvalidaException: Exception
    {
        public FechaIngresoInvalidaException(): base("La fecha de ingreso ingresada es inválida")
        {

        }

        public FechaIngresoInvalidaException(DateTime fechaIngresada, string mensaje) : base(string.Format("La fecha de ingreso {0} es inválida : {1}", fechaIngresada.ToString("MM/dd/yyyy"), mensaje))
        {

        }
    }
}
