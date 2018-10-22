using SistemaPresupuestoCuentasReporte.BLL;
using SistemaPresupuestoCuentasReporte.Entidades;
using SistemaPresupuestoCuentasReporte.UI.FormBase;
using SistemaPresupuestoCuentasReporte.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPresupuestoCuentasReporte.UI.Consultas
{
    public partial class ConsultaPresupuesto : ConsultaBase
    {
        PresupuestoRepositorio repositorio;
        List<Presupuesto> lista;
        public ConsultaPresupuesto()
        {
            
            InitializeComponent();
            List<String> listaComboBox = new List<String>();
            listaComboBox.Add("Todos");
            listaComboBox.Add("Id");
            listaComboBox.Add("Descripcion");
            listaComboBox.Add("Monto");
            FiltroComboBox.DataSource = listaComboBox;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            repositorio = new PresupuestoRepositorio();
            //Lista de presupuestos
            lista = new List<Presupuesto>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://todos
                        lista = repositorio.GetList(x => true);
                        break;
                    case 1://ID

                        int id = 0;
                        try
                        {
                            id = Convert.ToInt32(CriterioTextBox.Text);
                            lista = repositorio.GetList(x => x.Id == id);
                        }
                        catch (FormatException) { MessageBox.Show("Introduzca un criterio valido en base al filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                        break;
                    case 2://Descripcion
                        lista = repositorio.GetList(x => x.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                    case 3://Monto
                        Double sueldo = 0.0;
                        try
                        {
                            sueldo = Convert.ToDouble(CriterioTextBox.Text);
                            lista = repositorio.GetList(x => x.Monto == sueldo);
                        }
                        catch (FormatException) { MessageBox.Show("Introduzca un criterio valido en base al filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                        break;
                   
                }

                lista = lista.Where(x => x.Fecha.Date >= DesdeDateTimePicker.Value.Date && x.Fecha <= HastaDateTimePicker.Value.Date).ToList(); ;
            }
            else
            {
                lista = repositorio.GetList(x => true);
            }
            foreach(var item in lista)
            {
                item.Cuentas.Count();
            }
            BaseDataGridView.DataSource = null;
            BaseDataGridView.DataSource = lista;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Imposible imprimir");
                return;
            }

            ReporteViewer reporte = new ReporteViewer(lista);
            reporte.ShowDialog();
        }
    }
}
