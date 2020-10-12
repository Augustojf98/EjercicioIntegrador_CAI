using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Facultad_Consola.Helpers
{
    public static class ConsolaHelper
    {
        public static string PedirString(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            string s = Console.ReadLine();

            return s;
        }

        public static int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            int s = int.Parse(Console.ReadLine());

            return s;
        }

        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            double s = double.Parse(Console.ReadLine());

            return s;
        }

        public static DateTime PedirFecha(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            DateTime s = DateTime.Parse(Console.ReadLine());

            return s;
        }

        public static bool EsOpcionValida(string opcionSeleccionada, string opcionesValidas)
        {
            try
            {
                if (string.IsNullOrEmpty(opcionSeleccionada) || opcionSeleccionada.Length > 1 || !opcionesValidas.ToUpper().Contains((string)opcionSeleccionada.ToUpper()))
                    return false;
                else
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
