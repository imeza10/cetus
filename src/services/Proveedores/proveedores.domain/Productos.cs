﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proveedores.domain
{
    public class Productos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string NombreLaboratorio { get; set; }
        public bool Estado { get; set; }
        public Date FechaRegistro { get; set; }
    }
}
