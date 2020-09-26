using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;

        public string GetNombreCompleto()
        {
            return this._nombre + " " + this._apellido;
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                this._edad = value;
            }
        }

    }
}
