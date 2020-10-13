using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class IndumentariaFormal : TipoIndumentaria
    {
        public IndumentariaFormal()
        {
            _origen = "China";
            _porcentajeAlgodon = 25;
        }
    }
}
