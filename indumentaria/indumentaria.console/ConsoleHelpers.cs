using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.console
{
    public class ConsoleHelpers
    {
        public static string PedirString(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            return Console.ReadLine();
        }
        public static int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            return int.Parse(Console.ReadLine());
        }
        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese " + msg);
            return double.Parse(Console.ReadLine());
        }
    }
}
