using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class Camisa
    {
        private bool _tieneEstampado;
        private int _tipoManga;
        public bool TieneEstampado
        {
            get { return _tieneEstampado; }
            set { _tieneEstampado = value; }
        }
        public int TipoManga
        {
            get { return _tipoManga; }
            set { _tipoManga = value; }
        }

    }
}
