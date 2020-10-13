using indumentaria.libreriaNegocio;
using System;
using System.Collections.Generic;

namespace indumentaria.console
{
    class Program
    {
        static void Main(string[] args)
        {
            bool activo = true;
            string menu = "1. Listar indumentarias \n 2. Agregar indumentaria \n 3. Modificar indumentaria \n 4. Eliminar indumentaria \n 5. \n 6. \n X. Salir";
            TiendaRopa elNegocio = new TiendaRopa();

            do
            {
                Console.WriteLine(menu);
                string opcionElegida = Console.ReadLine();
                if (opcionElegida.ToUpper() == "X")
                {
                    activo = false;
                    continue;
                }
                switch (opcionElegida.ToUpper())
                {
                    case "1":
                        ListarIndumentarias(elNegocio);
                        break;
                    case "2":
                        AgregarIndumentaria(elNegocio);
                        break;
                    case "3":
                        ModificarIndumentaria(elNegocio);
                        break;
                    case "4":
                        EliminarIndumentaria(elNegocio);
                        break;
                    default:
                        Console.WriteLine("La opción elegida no existe, intente nuevamente");
                        break;
                }
            } while (activo == true);
            Console.WriteLine("Gracias por hacer negocios con nosotros");
        }
        static void ListarIndumentarias(TiendaRopa tienda)
        {
            try
            {
                string listado = "";
                List<Indumentaria> inventario = tienda.Listar();
                inventario.ForEach(inventarioItem => listado += inventarioItem.GetDetalle() + "\n");
                Console.WriteLine(listado);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void AgregarIndumentaria(TiendaRopa tienda)
        {
            string varianteIndumentaria = ConsoleHelpers.PedirString("una opción: \n Pantalon(P) \n Camisa(C) \n");
            if (varianteIndumentaria.ToUpper() == "P")
            {
                int codigo = tienda.GetProximoCodigo();
                TipoIndumentaria tipo = new IndumentariaCasual();
                string talle = ConsoleHelpers.PedirString("un talle");
                double precio = ConsoleHelpers.PedirDouble("el precio");
                int material = ConsoleHelpers.PedirInt("un material (Códigos \n Algodón(1) \n Polyester(2)");
                Indumentaria nuevaIndumentaria = new Pantalon(codigo, talle, precio, material, true);
                tienda.Agregar(nuevaIndumentaria);
            }
            else if (varianteIndumentaria == "C")
            {
                int codigo = tienda.GetProximoCodigo();
                TipoIndumentaria tipo = new IndumentariaFormal();
                string talle = ConsoleHelpers.PedirString("un talle");
                double precio = ConsoleHelpers.PedirDouble("el precio");
                int tipoManga = ConsoleHelpers.PedirInt("un tipo de manga (Códigos \n Corta(1) \n Larga(2)");
                Indumentaria nuevaIndumentaria = new Camisa(codigo, talle, precio, false, tipoManga);
                tienda.Agregar(nuevaIndumentaria);
            }
            else
            {
                Console.WriteLine("No existe la indumentaria elegida");
            }
        }
        static void ModificarIndumentaria(TiendaRopa tienda)
        {
            int codigo = ConsoleHelpers.PedirInt("codigo de indumentaria a modificar");
            try
            {
                Indumentaria indumentaria = tienda.Inventario.Find(indumentariaItem => indumentariaItem.Codigo == codigo);
                double nuevoPrecio = ConsoleHelpers.PedirDouble("el nuevo precio");
                tienda.Modificar(indumentaria, nuevoPrecio);
            }
            catch (Exception Ex)
            {
                Console.WriteLine("No se pudo modificar la indumentaria. Mensaje: " + Ex.Message);
            }
            
        }
        static void EliminarIndumentaria(TiendaRopa tienda)
        {
            int codigo = ConsoleHelpers.PedirInt("codigo de indumentaria a eliminar");
            
            try
            {
                Indumentaria indumentaria = tienda.Inventario.Find(indumentariaItem => indumentariaItem.Codigo == codigo);
                tienda.Quitar(indumentaria);
            } catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error con mensaje: " + ex.Message);
            }
        }
    }
}
