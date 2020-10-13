using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indumentaria.libreriaNegocio;

namespace indumentaria.console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool activo = true;
            string menu = "1. Listar indumentarias \n 2. \n 3. \n 4. \n 5. \n 6. \n X. Salir";
            TiendaRopa elNegocio = new TiendaRopa();
            
            do
            {
                Console.WriteLine(menu);
                    string opcionElegida = Console.ReadLine();
                    if(opcionElegida == "X")
                    {
                        activo = false;
                        continue;
                    }
                    switch (opcionElegida)
                    {
                        case "1":
                            ListarIndumentarias(elNegocio);
                            break;
                        default:
                            Console.WriteLine("La opción elegida no existe, intente nuevamente");
                            break;
                    }
            } while (activo == true);
            Console.WriteLine("Gracias por hacer negocios con nosotros");
        }
        static void ListarIndumentarias(TiendaRopa tienda) {
            string listado = "";
            List<Indumentaria> inventario = tienda.Listar();
            inventario.ForEach(inventarioItem => listado += inventarioItem.GetDetalle() + "\n");
            Console.WriteLine(listado);
        }
    }
}
