using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    class VentaItem
    {
        Indumentaria _prenda;
        int _cantidad;
        public Indumentaria Prenda { get => _prenda; set => _prenda = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public double GetTotal()
        {
            throw new NotImplementedException();
        }
    }
}
