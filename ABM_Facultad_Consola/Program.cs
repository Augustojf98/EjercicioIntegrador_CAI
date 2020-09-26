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
            
            Console.WriteLine("Nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Apellido");
            var apellido = Console.ReadLine();
            Console.WriteLine("Edad");
            var edad = Console.ReadLine();
            Console.WriteLine("Codigo");
            var codigo = Console.ReadLine();
            

            Alumno alumno = new Alumno(nombre, apellido, int.Parse(edad));
            alumno.Codigo = int.Parse(codigo);

            Console.WriteLine(alumno.ToString());
            Console.Read();


        }
    }
}
