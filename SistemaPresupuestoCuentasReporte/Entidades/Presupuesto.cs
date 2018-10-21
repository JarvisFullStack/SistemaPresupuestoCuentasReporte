using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPresupuestoCuentasReporte.Entidades
{
    public class Presupuesto
    {
        [Key]
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public double Monto { get; set; }
        public DateTime Fecha { get; set; }
        public virtual List<Cuenta> Cuentas { get; set; }

        public Presupuesto()
        {
            Id = 0;
            Descripcion = string.Empty;
            Monto = 0.0;
            Fecha = DateTime.Now;
        }

    }
}
