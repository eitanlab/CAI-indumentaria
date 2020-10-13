using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class IndumentariaCasual : TipoIndumentaria
    {
        public IndumentariaCasual()
        {
            _origen = "Argentina";
            _porcentajeAlgodon = 15;
        }
    }
}
