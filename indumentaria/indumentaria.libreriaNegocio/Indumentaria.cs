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
        protected int _codigo;
        protected int _stock;
        protected string _talle;
        protected double _precio;
        public TipoIndumentaria Tipo { get => _tipo; set => _tipo = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Talle { get => _talle; set => _talle = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public override string ToString() {
            return GetDetalle();
        }
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
            //return base.Equals(obj);
        }
        public abstract string GetDetalle();
    }
}
