using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class Venta
    {
        List<VentaItem> _items;
        Cliente _cliente;
        int _estado;
        int _codigo;
        public List<VentaItem> Items { get => _items; set => _items = value; }
        public Cliente Cliente { get => _cliente;set=> _cliente = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public double GetTotalPedido()
        {
            throw new NotImplementedException();
        }
    }
}
