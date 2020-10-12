using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public sealed class Directivo: Empleado
    {
        public Directivo(int legajo, string nombre, string apellido, DateTime fechaNac, DateTime fechaIngr, double ultimoSalario)
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
            return string.Format("Sr. Director {0}", this._apellido);
        }
    }
}
