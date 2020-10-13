﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indumentaria.libreriaNegocio.Exceptions
{
    public class TiendaVaciaException : Exception
    {
        public TiendaVaciaException() : base("La tienda no tiene productos para listar") { }
    }
}
