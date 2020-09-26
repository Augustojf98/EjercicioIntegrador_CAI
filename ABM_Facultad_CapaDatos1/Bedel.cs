using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    class Bedel
    {
        private Empleado _empleado;
        private string _apodo;

        public string Apodo
        {
            set
            {
                this._apodo = value;
            }
        }

        public string GetNombreCompleto()
        {
            return _empleado.GetNombreCompleto();
        }
    }
}
