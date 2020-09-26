using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public class Alumno
    {
        private Persona _persona;
        private int _codigo;

        public string Credencial
        {
            get
            {
                return "Código " + this._codigo + " " + this._persona.Apellido + ", " + this._persona.Nombre;
            }
        }

        public Alumno(string nombre, string apellido, int edad)
        {
            this._persona = new Persona();
            this._persona.Nombre = nombre;
            this._persona.Apellido = apellido;
            this._persona.Edad = edad;
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

        public string GetCredencial()
        {
            return Credencial;
        }

        public string ToString()
        {
            return GetCredencial();
        }

    }
}
