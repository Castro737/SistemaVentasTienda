using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasTienda
{
    using System.Data.Entity;

    public class SistemaVentasTiendaContext : DbContext
    {
        public SistemaVentasTiendaContext()
            : base("name=SistemaVentasTiendaDB") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
    }

}
