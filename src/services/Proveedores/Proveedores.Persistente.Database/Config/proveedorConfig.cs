using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proveedores.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores.Persistente.Database.Config
{
    public class proveedorConfig
    {

        public proveedorConfig(EntityTypeBuilder<proveedor> entityTypeBuilder) {
            entityTypeBuilder.HasIndex(x => x.NumId);


        }
    }
}
