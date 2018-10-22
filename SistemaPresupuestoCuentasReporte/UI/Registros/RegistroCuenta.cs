using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPresupuestoCuentasReporte.UI.Registros
{
    public partial class RegistroCuenta : RegistroBase
    {
        public RegistroCuenta()
        {
            InitializeComponent();
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            ValidarGuardar(this.Controls, errorProvider);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(this.Controls);
        }
    }
}
