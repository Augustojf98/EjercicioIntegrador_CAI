using System;
using System.Collections.Generic;

namespace ABM_Facultad_CapaDatos
{
    public abstract class Empleado : Persona
    {
        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;

        public override string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return this._fechaIngreso;
            }
            set
            {
                this._fechaIngreso = value;
            }
        }


        public void AgregarSalario(double bruto)
        {
            Salario salario = new Salario(bruto, DateTime.Now);
            this._salarios.Add(salario);
        }

        public Salario UltimoSalario
        {
            get
            {
                int ultimoSalario = this._salarios.Count - 1;

                return this._salarios[ultimoSalario];
            }
        }

        public List<Salario> Salarios
        {
            get
            {
                return this._salarios;
            }
            set
            {
                this._salarios = value;
            }
        }

        public override string GetCredencial()
        {
            return string.Format("{0} - {1} salario $ {2}", this._legajo, this.GetNombreCompleto(), this.UltimoSalario.GetSalarioNeto());
        }

        public override string ToString()
        {
            return this.GetCredencial();
        }
    }
}
