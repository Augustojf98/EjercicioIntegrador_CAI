using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_CapaDatos.Exceptions
{
    public class EmpleadoInexistenteException: Exception
    {
        public EmpleadoInexistenteException() : base(string.Format("El empleado no existe"))
        {

        }
        public EmpleadoInexistenteException(int legajo) : base(string.Format("El empleado {0} no existe", legajo))
        {

        }
    }

    public class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException() : base(string.Format("El empleado ya existe"))
        {

        }
        public EmpleadoExistenteException(int legajo) : base(string.Format("El empleado {0} ya existe", legajo))
        {

        }
    }
}
