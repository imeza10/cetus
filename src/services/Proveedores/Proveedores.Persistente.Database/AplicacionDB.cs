using Microsoft.EntityFrameworkCore;
using proveedores.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proveedores;


namespace Proveedores.Persistente.Database
{
    public class AplicacionDB : DbContext 
    {

        public AplicacionDB(DbContextOptions<AplicacionDB> options):base(options)
        { 
       
        
        }

        public DbSet<proveedor> Proveedores { get; set; }
    }
}
