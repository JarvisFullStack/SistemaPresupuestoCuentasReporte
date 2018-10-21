using SistemaPresupuestoCuentasReporte.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPresupuestoCuentasReporte.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Presupuesto> Presupuesto { get; set; }
        public DbSet<Cuenta> Cuenta { get; set; }
        public DbSet<TipoCuenta> TipoCuenta { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}
