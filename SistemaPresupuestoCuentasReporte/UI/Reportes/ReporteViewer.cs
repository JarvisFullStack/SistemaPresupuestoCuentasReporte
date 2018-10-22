using SistemaPresupuestoCuentasReporte.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPresupuestoCuentasReporte.UI.Reportes
{
    public partial class ReporteViewer : Form
    {
        private List<Presupuesto> lista;
        public ReporteViewer(List<Presupuesto> lista)
        {
            this.lista = lista;
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            MyCrystalReportViewer.ReportSource = lista;
            MyCrystalReportViewer.Refresh();
        }
    }
}
