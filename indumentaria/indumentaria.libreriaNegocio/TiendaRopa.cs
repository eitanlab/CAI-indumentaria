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
        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
            _ultimoCodigo = 0;
        }

        public List<Indumentaria> Inventario { get => _inventario; }
        public List<Venta> Ventas { get => _ventas; set => _ventas = value; }
        public int UltimoCodigo { get => _ultimoCodigo; set => _ultimoCodigo = value; }
        public int GetProximoCodigo(){
            _ultimoCodigo += 1;
            return _ultimoCodigo;
        }
        public void Agregar(Indumentaria indumentaria)
        {
            _inventario.Add(indumentaria);
        }
        public void Modificar(Indumentaria indumentaria, double nuevoPrecio)
        {
            if (indumentaria != null)
            {
                indumentaria.Precio = nuevoPrecio;
            }
            throw new IndumentariaNoEncontradaException();
        }
        public void Quitar(Indumentaria indumentaria)
        {
            if(indumentaria != null)
            {
                _inventario.Remove(indumentaria);
            }
            throw new IndumentariaNoEncontradaException();
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
