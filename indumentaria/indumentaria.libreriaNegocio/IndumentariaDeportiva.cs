using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public class IndumentariaDeportiva : TipoIndumentaria
    {
        public IndumentariaDeportiva()
        {
            _origen = "Paraguay";
            _porcentajeAlgodon = 50;
        }
    }
}
