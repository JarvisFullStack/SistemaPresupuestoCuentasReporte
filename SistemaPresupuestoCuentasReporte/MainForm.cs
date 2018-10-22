using SistemaPresupuestoCuentasReporte.UI.Consultas;
using SistemaPresupuestoCuentasReporte.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPresupuestoCuentasReporte
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
        }

        private void presupuestoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroPresupuesto registroPresupuesto = new RegistroPresupuesto();
            registroPresupuesto.Show();
        }

        private void presupuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaPresupuesto consultaPresupuesto = new ConsultaPresupuesto();
            consultaPresupuesto.Show();
        }
    }
}
