using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPresupuestoCuentasReporte.Entidades
{
    public class Cuenta
    {
        [Key]
        public int Id { get; set; }
        public String Descripcion { get; set; }
        public int TipoId { get; set; }
        public double Monto { get; set; }

        public Cuenta()
        {
            Id = 0;
            Descripcion = string.Empty;
            TipoId = 0;
            Monto = 0.0;
        }
    }
}
