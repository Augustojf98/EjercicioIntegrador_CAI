using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public class Docente: Empleado
    {
        public Docente(int legajo, string nombre, string apellido, DateTime fechaNac, DateTime fechaIngr, double ultimoSalario)
        {
            this.Legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
            this._fechaNac = fechaNac;
            this.FechaIngreso = fechaIngr;
            this.Salarios = new List<Salario>();
            this.AgregarSalario(ultimoSalario);
        }

        public override string GetNombreCompleto()
        {
            return string.Format("Docente {0}", this._nombre);
        }
    }
}
