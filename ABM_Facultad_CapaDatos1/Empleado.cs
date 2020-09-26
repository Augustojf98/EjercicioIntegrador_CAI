using System;
using System.Collections.Generic;

namespace ABM_Facultad_CapaDatos
{
    public abstract class Empleado
    {
        private Persona _persona;
        private int _legajo;
        private List<decimal> _salario;

        public string GetNombreCompleto()
        {
            return this._persona.GetNombreCompleto();
        }
        
    }
}
