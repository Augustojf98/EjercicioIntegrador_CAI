using ABM_Facultad_CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultad facultad = new Facultad("FCE-UBA", 1);

            string menu = "\n1) Agregar alumno\n2) Agregar empleado\n3) Listar alumnos\n4) Listar empleados\n5) Editar alumno\n6) Editar empleado" +
                "\n7) Eliminar alumno\n8) Eliminar empleado\nX) Cerrar programa";

            bool sigueActivo = true;

            do
            {
                Console.WriteLine("Bienvenido a " + facultad.Nombre + "\n");
                try
                {
                    Console.WriteLine(menu + "\n");

                    string opcionSeleccionada = Helpers.ConsolaHelper.PedirString("una opción del menú:");

                    if(Helpers.ConsolaHelper.EsOpcionValida(opcionSeleccionada, "12345678X"))
                    {
                        switch (opcionSeleccionada)
                        {
                            case "x":
                                sigueActivo = false;
                                break;
                            case "1":
                                AgregarAlumno(facultad);
                                break;
                            case "2":
                                AgregarEmpleado(facultad);
                                break;
                            case "3":
                                ListarAlumnos(facultad);
                                break;
                            case "4":
                                ListarEmpleados(facultad);
                                break;
                            case "5":
                                break;
                            case "6":
                                break;
                            case "7":
                                EliminarAlumno(facultad);
                                break;
                            case "8":
                                EliminarEmpleado(facultad);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error en la aplicación. " + ex.Message + " Por favor intente nuevamente.");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (sigueActivo);

            Console.WriteLine("Muchas gracias por utilizar la aplicación.");

            Console.ReadKey();

        }

        private static void AgregarAlumno(Facultad facultad)
        {
            try
            {
                int c = Helpers.ConsolaHelper.PedirInt("código del alumno");
                string n = Helpers.ConsolaHelper.PedirString("nombre del alumno");
                string a = Helpers.ConsolaHelper.PedirString("apellido del alumno");
                DateTime fn = Helpers.ConsolaHelper.PedirFecha("fecha de nacimiento del alumno (MM/dd/yyyy)");

                facultad.AgregarAlumno(c, n, a, fn);
                Console.WriteLine(string.Format("Se agregó correctamente al alumno con el código {0} al sistema", c));
            }
            catch(ABM_Facultad_CapaDatos.Exceptions.AlumnoExistenteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AgregarEmpleado(Facultad facultad)
        {
            try
            {
                int c = Helpers.ConsolaHelper.PedirInt("legajo del empleado");
                string te = Helpers.ConsolaHelper.PedirString("tipo de empleado (Directivo - D | Bedel - B | Docente - P)");
                string n = Helpers.ConsolaHelper.PedirString("nombre del empleado");
                string a = Helpers.ConsolaHelper.PedirString("apellido del empleado");
                string apodo = string.Empty;
                DateTime fn = Helpers.ConsolaHelper.PedirFecha("fecha de nacimiento del empleado (MM/dd/yyyy)");
                DateTime fi = Helpers.ConsolaHelper.PedirFecha("fecha de ingreso del empleado (MM/dd/yyyy)");
                double us = Helpers.ConsolaHelper.PedirDouble("último salario");

                if(te == "b")
                {
                    apodo = Helpers.ConsolaHelper.PedirString("apodo del bedel");
                }

                facultad.AgregarEmpleado(c, n, a, apodo, fn, fi, us, te);
                Console.WriteLine(string.Format("Se agregó correctamente al empleado con el código {0} al sistema", c));
            }
            catch (ABM_Facultad_CapaDatos.Exceptions.EmpleadoExistenteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListarEmpleados(Facultad facultad)
        {
            try
            {
                if (facultad.Empleados.Count > 0)
                {
                    foreach (Empleado empleado in facultad.Empleados)
                    {
                        Console.WriteLine(empleado.ToString());
                    }
                }
                else
                {
                    throw new ABM_Facultad_CapaDatos.Exceptions.SinEmpleadosException();
                }
            }
            catch (ABM_Facultad_CapaDatos.Exceptions.SinEmpleadosException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListarAlumnos(Facultad facultad)
        {
            try
            {
                if(facultad.Alumnos.Count > 0)
                {
                    foreach (Alumno alumno in facultad.Alumnos)
                    {
                        Console.WriteLine(alumno.ToString());
                    }
                }
                else
                {
                    throw new ABM_Facultad_CapaDatos.Exceptions.SinAlumnosException();
                }
            }
            catch (ABM_Facultad_CapaDatos.Exceptions.SinAlumnosException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void EliminarAlumno(Facultad facultad)
        {
            try
            {
                if (facultad.Alumnos.Count > 0)
                {

                    ListarAlumnos(facultad);

                    int c = Helpers.ConsolaHelper.PedirInt("código del alumno");
                    facultad.EliminarAlumno(c);
                    Console.WriteLine(string.Format("Se ha eliminado al alumno con el código {0}.", c));
                }
                else
                {
                    throw new ABM_Facultad_CapaDatos.Exceptions.SinAlumnosException();
                }
            }
            catch (ABM_Facultad_CapaDatos.Exceptions.AlumnoInexistenteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ABM_Facultad_CapaDatos.Exceptions.SinAlumnosException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void EliminarEmpleado(Facultad facultad)
        {
            try
            {
                if (facultad.Empleados.Count > 0)
                {
                    ListarEmpleados(facultad);

                    int c = Helpers.ConsolaHelper.PedirInt("legajo del empleado");
                    facultad.EliminarEmpleado(c);
                    Console.WriteLine(string.Format("Se ha eliminado al empleado con el legajo {0}.", c));
                }
                else
                {
                    throw new ABM_Facultad_CapaDatos.Exceptions.SinEmpleadosException();
                }
            }
            catch (ABM_Facultad_CapaDatos.Exceptions.EmpleadoInexistenteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ABM_Facultad_CapaDatos.Exceptions.SinEmpleadosException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
