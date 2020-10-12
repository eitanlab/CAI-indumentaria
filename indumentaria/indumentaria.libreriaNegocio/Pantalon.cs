using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class Pantalon
    {
        private int _material;
        private int _tieneBolsillos;
        public int TieneBolsillos
        {
            get { return _tieneBolsillos; }
            set { _tieneBolsillos = value; }
        }
        public int Material
        {
            get { return _material; }
            set { _material = value; }
        }

    }
}
