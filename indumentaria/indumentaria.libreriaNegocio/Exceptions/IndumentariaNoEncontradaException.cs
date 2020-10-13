using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio.Exceptions
{
    public class IndumentariaNoEncontradaException : Exception
    {
        public IndumentariaNoEncontradaException() : base ("Indumentaria no encontrada") { }
    }
}
