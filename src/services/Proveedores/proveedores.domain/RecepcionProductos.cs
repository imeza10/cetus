using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proveedores.domain
{
    public class RecepcionProductos
    {
        public string FechaHoraRecepcion { get; set; }
        public string Producto { get; set; }
        public string Proveedor { get; set; }
        public string Factura { get; set; }
        public string Cantidad { get; set; }
        public string Lote { get; set; }
        public string Invima { get; set; }
        public string FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
    }
}
