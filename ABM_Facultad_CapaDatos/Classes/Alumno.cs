using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public sealed class Alumno : Persona
    {
        private int _codigo;

        public override string GetCredencial()
        {
            return string.Format("Código: {0} - {1}", this._codigo, this.GetNombreCompleto());
        }

        public Alumno(int codigo, string nombre, string apellido, DateTime fechaNac)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fechaNac;
        }

        public int Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        public override string ToString()
        {
            return GetCredencial();
        }

    }
}
