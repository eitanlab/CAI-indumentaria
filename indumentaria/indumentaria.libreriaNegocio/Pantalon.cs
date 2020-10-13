using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class Pantalon : Indumentaria
    {
        private int _material;
        private bool _tieneBolsillos;
        public Pantalon(int codigo, string talle, double precio, int material, bool tieneBolsillos)
        {
            _tipo = new IndumentariaFormal();
            _codigo = codigo;
            _stock = 3;
            _talle = talle;
            _precio = precio;
            _material = material;
            _tieneBolsillos = tieneBolsillos;
        }
        public bool TieneBolsillos
        {
            get { return _tieneBolsillos; }
            set { _tieneBolsillos = value; }
        }
        public int Material
        {
            get { return _material; }
            set { _material = value; }
        }
        public override string GetDetalle()
        {
            return "Pantalón talle " + Talle + " - $" + Precio;
        }

    }
}
