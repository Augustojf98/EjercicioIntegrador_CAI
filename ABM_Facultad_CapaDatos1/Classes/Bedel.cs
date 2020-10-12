using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public class Bedel : Empleado
    {
        private string _apodo;

        public Bedel(int legajo, string nombre, string apellido, string apodo, DateTime fechaNac, DateTime fechaIngr, double ultimoSalario)
        {
            this.Legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
            this._apodo = apodo;
            this._fechaNac = fechaNac;
            this.FechaIngreso = fechaIngr;
            this.Salarios = new List<Salario>();
            this.AgregarSalario(ultimoSalario);
        }

        public string Apodo
        {
            get
            {
                return this._apodo;
            }
            set
            {
                this._apodo = value;
            }
        }

        public override string GetNombreCompleto()
        {
            return string.Format("Bedel {0}", this._apodo);
        }
    }
}
