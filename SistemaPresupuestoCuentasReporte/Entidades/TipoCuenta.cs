using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPresupuestoCuentasReporte.Entidades
{
    public class TipoCuenta
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public TipoCuenta()
        {
            Id = 0;
            Descripcion = string.Empty;
        }
    }
}
