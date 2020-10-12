using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public abstract class Indumentaria
    {
        TipoIndumentaria _tipo;
        int _codigo;
        int _stock;
        string _talle;
        double _precio;
        public TipoIndumentaria Tipo { get => _tipo; set => _tipo = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Talle { get => _talle; set => _talle = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public override string ToString() {
            throw new NotImplementedException();
        }
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
            //return base.Equals(obj);
        }
        public abstract string GetDetalle();
    }
}
