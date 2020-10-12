using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected DateTime _fechaNac;

        public virtual string GetNombreCompleto()
        {
            return string.Format("{0} {1}", this._apellido, this._nombre);
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

        public DateTime FechaNac
        {
            get
            {
                return this._fechaNac;
            }
            set
            {
                this._fechaNac = value;
            }
        }

        public int Edad
        {
            get
            {
                long cantidadDias = DateTime.Now.Ticks - this._fechaNac.Ticks;
                TimeSpan cantDias = new TimeSpan(cantidadDias);
                return cantDias.Days/365;
            }
        }

        public abstract string GetCredencial();

    }
}
