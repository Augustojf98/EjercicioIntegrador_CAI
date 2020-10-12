using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_CapaDatos.Exceptions
{
    public class SinAlumnosException : Exception
    {
        public SinAlumnosException() : base(string.Format("No hay alumnos cargados en el sistema."))
        {

        }
    }
}
