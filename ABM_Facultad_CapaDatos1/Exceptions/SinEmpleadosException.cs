using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_CapaDatos.Exceptions
{
    public class SinEmpleadosException : Exception
    {
        public SinEmpleadosException():base(string.Format("No hay empleados cargados en el sistema."))
        {

        }
    }
}
