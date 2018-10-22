using SistemaPresupuestoCuentasReporte.BLL;
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

namespace SistemaPresupuestoCuentasReporte.UI.Registros
{
    public partial class RegistroPresupuesto : RegistroBase
    {

        public List<Cuenta> Cuentas { get; set; }
        RepositorioBase<Presupuesto> repositorio;

        public RegistroPresupuesto()
        {
            InitializeComponent();
            Cuentas = new List<Cuenta>();
            LlenarComboBox();
        }

        public void LlenarComboBox()
        {
            RepositorioBase<Cuenta> cuentaRepositorio = new RepositorioBase<Cuenta>();
            CuentaComboBox.DataSource = cuentaRepositorio.GetList(x => true);
            CuentaComboBox.ValueMember = "Id";
            CuentaComboBox.DisplayMember = "Descripcion";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(this.Controls);
            dataGridViewCuentas.DataSource = null;

        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Presupuesto>();
            if (!ValidarGuardar(this.Controls, errorProvider))
            {
                return;
            }

            if (this.Cuentas.Count == 0)
            {
                errorProvider.SetError(CuentaComboBox, "No existen cuentas agregadas***");
                CuentaComboBox.Focus();
                return;
            }

            int numero = (int)IDnumericUpDown.Value;
            if (numero > 0)
            {
                if (repositorio.Buscar(LlenaClase().Id) == null)
                {
                    if (repositorio.Modificar(LlenaClase()))
                    {
                        MessageBox.Show("Modificado correctamente!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar***");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Error no se puede modificar un registro que no existe!");
                    return;
                }
            }
            else
            {
                if (repositorio.Guardar(LlenaClase()))
                {
                    MessageBox.Show("Guardado Correctamente!");
                    return;
                }
                else
                {
                    MessageBox.Show("Error al guardar");
                    return;

                }
            }

        }
        private void LlenaCampos(Presupuesto presupuesto)
        {
            IDnumericUpDown.Value = presupuesto.Id;
            DescripcionTextBox.Text = presupuesto.Descripcion;
            FechaTimePicker.Value = presupuesto.Fecha;
            ValorTextBox.Text = Convert.ToString(presupuesto.Monto);

            this.Cuentas = presupuesto.Cuentas;
            CargarGrid();
        }

        private void CargarGrid()
        {
            dataGridViewCuentas.DataSource = null;
            dataGridViewCuentas.DataSource = this.Cuentas;
        }

        private Presupuesto LlenaClase()
        {
            Presupuesto presupuesto = new Presupuesto();
            presupuesto.Id = Convert.ToInt32(IDnumericUpDown.Value);
            presupuesto.Descripcion = DescripcionTextBox.Text;
            presupuesto.Fecha = FechaTimePicker.Value;
            presupuesto.Monto = Convert.ToDouble(ValorTextBox.Text);
            presupuesto.Cuentas = this.Cuentas;
            return presupuesto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCuentas.DataSource != null)
            {
                this.Cuentas = (List<Cuenta>)dataGridViewCuentas.DataSource;
            }
            Cuenta c = new RepositorioBase<Cuenta>().Buscar((int)CuentaComboBox.SelectedValue);
            
               
            this.Cuentas.Add(c);
            errorProvider.Clear();
            CargarGrid();
        }

        private void btnEliminarFila_Click(object sender, EventArgs e)
        {
            if (dataGridViewCuentas.Rows.Count > 0 && dataGridViewCuentas.CurrentRow != null)
            {
                this.Cuentas.RemoveAt(dataGridViewCuentas.CurrentRow.Index);
                CargarGrid();
            } 
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            RegistroCuenta registroDeCuentas = new RegistroCuenta();
            registroDeCuentas.Show();
            LlenarComboBox();
        }
    }
}
