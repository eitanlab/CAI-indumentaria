﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio
{
    public abstract class TipoIndumentaria
    {
        protected string _origen;
        protected double _porcentajeAlgodon;
        public double ProcentajeAlgodon { get => _porcentajeAlgodon; set => _porcentajeAlgodon = value; }
        public string Origen { get => _origen; set => _origen = value; }
    }
}
