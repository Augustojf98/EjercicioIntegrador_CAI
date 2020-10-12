using System;
using System.Collections.Generic;
using System.Text;

namespace ABM_Facultad_CapaDatos
{
    public class Facultad
    {
        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public List<Alumno> Alumnos
        {
            get
            {
                return this._alumnos;
            }
        }

        public List<Empleado> Empleados
        {
            get
            {
                return this._empleados;
            }
        }

        public int CantidadSedes
        {
            get
            {
                return this._cantidadSedes;
            }
            set
            {
                this._cantidadSedes = value;
            }
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

        public void AgregarAlumno(int codigo, string nombre, string apellido, DateTime fechaNac)
        {
            if (BuscarAlumnoPorCodigo(codigo) == null)
            {
                if(fechaNac < DateTime.Now)
                {
                    if ((DateTime.Now - fechaNac).Days/365 < 21)
                    {
                        this._alumnos.Add(new Alumno(codigo, nombre, apellido, fechaNac));
                    }
                    else
                    {
                        throw new Exceptions.FechaNacInvalidaException(fechaNac, "El alumno no puede ser mayor de 21 años.");
                    }
                }
                else
                {
                    throw new Exceptions.FechaNacInvalidaException(fechaNac, "La fecha de nacimiento no puede ser mayor a la fecha actual.");
                }
            }
            else
            {
                throw new Exceptions.AlumnoExistenteException(codigo);
            }
        }

        public void AgregarEmpleado(int legajo, string nombre, string apellido, string apodo, DateTime fechaNac, DateTime fechaIngr, double ultimoSalario, string tipoEmpleado)
        {
            if (BuscarEmpleadoPorLegajo(legajo) == null)
            {
                if (fechaNac < DateTime.Now)
                {
                    if (fechaIngr > fechaNac)
                    {
                        if ((DateTime.Now - fechaNac).Days / 365 >= 18 || (DateTime.Now - fechaNac).Days / 365 < 100)
                        {
                            if ((fechaIngr - fechaNac).Days / 365 > 18)
                            {
                                switch (tipoEmpleado)
                                {
                                    case "d":
                                        this._empleados.Add(new Directivo(legajo, nombre, apellido, fechaNac, fechaIngr, ultimoSalario));
                                        break;
                                    case "b":
                                        this._empleados.Add(new Bedel(legajo, nombre, apellido, apodo, fechaNac, fechaIngr, ultimoSalario));
                                        break;
                                    case "p":
                                        this._empleados.Add(new Docente(legajo, nombre, apellido, fechaNac, fechaIngr, ultimoSalario));
                                        break;
                                }
                            }
                            else
                            {
                                throw new Exceptions.FechaIngresoInvalidaException(fechaIngr, "No se puede trabajar con menos de 18 años.");
                            }
                        }
                        else
                        {
                            throw new Exceptions.FechaNacInvalidaException(fechaNac, "Para ser empleado, hay que tener al menos 18 y menos de 100 años.");
                        }
                    }
                    else
                    {
                        throw new Exceptions.FechaIngresoInvalidaException(fechaIngr, "La fecha de ingreso no puede ser mayor a la de nacimiento.");
                    }
                }
                else
                {
                    throw new Exceptions.FechaNacInvalidaException(fechaNac, "La fecha de nacimiento no puede ser mayor a la fecha actual.");
                }
            }
            else
            {
                throw new Exceptions.EmpleadoExistenteException(legajo);
            }
        }

        public void EliminarEmpleado(int legajo)
        {
            if (this._empleados.Count > 0)
            {
                if (BuscarEmpleadoPorLegajo(legajo) != null)
                {
                    Empleado empleado = BuscarEmpleadoPorLegajo(legajo);
                    this._empleados.Remove(empleado);
                }
                else
                {
                    throw new Exceptions.EmpleadoInexistenteException(legajo);
                }
            }
            else
            {
                throw new Exceptions.SinEmpleadosException();
            }
        }

        public void EliminarAlumno(int codigo)
        {
            if (this._alumnos.Count > 0)
            {
                if (BuscarAlumnoPorCodigo(codigo) != null)
                {
                    Alumno alumno = BuscarAlumnoPorCodigo(codigo);
                    this._alumnos.Remove(alumno);
                }
                else
                {
                    throw new Exceptions.AlumnoInexistenteException(codigo);
                }
            }
            else
            {
                throw new Exception("No hay alumnos cargados en el sistema");
            }
        }

        public Facultad(string nombre, int cantidadSedes)
        {
            this._nombre = nombre;
            this._cantidadSedes = cantidadSedes;
            this._alumnos = new List<Alumno>();
            this._empleados = new List<Empleado>();
        }

        private Alumno BuscarAlumnoPorCodigo(int codigo)
        {
            foreach(Alumno alumno in _alumnos)
            {
                if(alumno.Codigo == codigo)
                {
                    return alumno;
                }
                return null;
            }
            return null;
        }

        private Empleado BuscarEmpleadoPorLegajo(int legajo)
        {
            foreach (Empleado empleado in _empleados)
            {
                if (empleado.Legajo == legajo)
                {
                    return empleado;
                }
                return null;
            }
            return null;
        }
    }
}
