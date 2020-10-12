using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_CapaDatos.Exceptions
{
    public class FechaNacInvalidaException: Exception
    {
        public FechaNacInvalidaException() : base("La fecha de nacimiento ingresada es inválida")
        {

        }

        public FechaNacInvalidaException(DateTime fechaIngresada, string mensaje) : base(string.Format("La fecha de nacimiento {0} es inválida: {1}", fechaIngresada.ToString("MM/dd/yyyy"), mensaje))
        {

        }
    }
}
