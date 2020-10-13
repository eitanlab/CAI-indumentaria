using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class Camisa : Indumentaria
    {
        private bool _tieneEstampado;
        private int _tipoManga;
        public Camisa(int codigo, string talle, double precio,bool tieneEstampado,int tipoManga)
        {
            _codigo = codigo;
            _stock = 3;
            _talle = talle;
            _precio = precio;
            _tieneEstampado = tieneEstampado;
            _tipoManga = tipoManga;
        }
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
        public override string GetDetalle()
        {
            return "Camisa" + _tipoManga + " talle " + Talle + " - $" + Precio ;
        }
    }
}
