using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    class Docente
    {
        private Empleado _empleado;

        public string GetNombreCompleto()
        {
            return _empleado.GetNombreCompleto();
        }
    }
}
