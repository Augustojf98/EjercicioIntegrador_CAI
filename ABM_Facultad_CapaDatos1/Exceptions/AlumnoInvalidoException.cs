using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_CapaDatos.Exceptions
{
    public class AlumnoInexistenteException: Exception
    {
        public AlumnoInexistenteException(): base(string.Format("El alumno no existe"))
        {

        }
        public AlumnoInexistenteException(int codigo) : base(string.Format("El alumno {0} no existe", codigo))
        {

        }
    }

    public class AlumnoExistenteException : Exception
    {
        public AlumnoExistenteException() : base(string.Format("El alumno ya existe"))
        {

        }
        public AlumnoExistenteException(int codigo) : base(string.Format("El alumno {0} ya existe", codigo))
        {

        }
    }
}
