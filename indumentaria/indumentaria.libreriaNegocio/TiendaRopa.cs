using indumentaria.libreriaNegocio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class TiendaRopa
    {
        List<Indumentaria> _inventario;
        List<Venta> _ventas;
        int _ultimoCodigo;

        //public List<Indumentaria> Inventario { get => _inventario; set => _inventario = value; }
        public List<Venta> Ventas { get => _ventas; set => _ventas = value; }
        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }
        public int GetProximoCodigo(){
            return _ultimoCodigo + 1;
        }
        public void Agregar(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }
        public void Modificar(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }
        public void Quitar(Indumentaria indumentaria)
        {
            throw new NotImplementedException();
        }
        public void IngresarVenta(Venta venta)
        {
            throw new NotImplementedException();
        }
        public List<Indumentaria> Listar()
        {
            if (_inventario.Count <= 0)
            {
                throw new TiendaVaciaException();
            }

            return _inventario;
        }
        public List<Venta> ListarVentas() {
            throw new NotImplementedException();
        }
        public void DevolverVenta(Venta venta)
        {
            throw new NotImplementedException();
        }
    }
}
