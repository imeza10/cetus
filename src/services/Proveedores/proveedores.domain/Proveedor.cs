using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proveedores.domain
{
   public class Proveedor
    {
        public int ID { get; set; }
        public string TipoId { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set;}
        public string NombreContacto { get; set; }
        public int NumeroContacto { get; set; }
        public string Estado { get; set; }
    }
}
