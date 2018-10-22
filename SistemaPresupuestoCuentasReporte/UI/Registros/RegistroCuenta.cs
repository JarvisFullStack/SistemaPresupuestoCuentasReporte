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
    public partial class RegistroCuenta : RegistroBase
    {
        RepositorioBase<Cuenta> repositorio;
        public RegistroCuenta()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            if ((int)MontoNumericUpDown1.Value <= 0)
            {
                errorProvider.SetError(MontoNumericUpDown1, "Debe agregar un valor!");
            }
            if(!((int)TipoCuentaComboBox.SelectedValue >= 0))
            {
                errorProvider.SetError(TipoCuentaComboBox, "Debe tener un tipo de cuenta seleccionado");
            }
            if(!ValidarGuardar(this.Controls, errorProvider))
            {
                MessageBox.Show("Error al intentar guardar el registro");
                return;
            }
            else
            {
                int id = (int)IDnumericUpDown.Value;
                if (id > 0)
                {
                    if (repositorio.Buscar(id) != null)
                    {
                        if (repositorio.Modificar(LlenaClase()))
                        {
                            MessageBox.Show("Registro modificado correctamente!");
                            return;

                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede modificar el registro");
                        return;
                    }
                }
                else
                {
                    if (repositorio.Guardar(LlenaClase()))
                    {
                        MessageBox.Show("Registro Guardado correctamente!!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar guardar el registro***");
                        return;
                    }
                }
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(this.Controls);
        }
        public Cuenta LlenaClase()
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Descripcion = DescripcionTextBox.Text;
            cuenta.Monto = Convert.ToDouble(MontoNumericUpDown1.Value);
            cuenta.TipoId = Convert.ToInt32(TipoCuentaComboBox.SelectedValue);
            return cuenta;

        } 

        public void LlenarComboBox()
        {           
            RepositorioBase<TipoCuenta> repositorioTipoCuenta = new RepositorioBase<TipoCuenta>();
            TipoCuentaComboBox.DataSource = repositorioTipoCuenta.GetList(x => true);
            TipoCuentaComboBox.ValueMember = "Id";
            TipoCuentaComboBox.DisplayMember = "Descripcion";
        }

        private void btnAgregarTipoCuenta_Click(object sender, EventArgs e)
        {
            RegistroTipoCuenta rTipoCuenta = new RegistroTipoCuenta();
            rTipoCuenta.ShowDialog();
            LlenarComboBox();
        }

        private void TipoCuentaComboBox_Click(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Cuenta>();
            int numero = Convert.ToInt32(IDnumericUpDown.Value);
            if (numero > 0)
            {
                Cuenta cuenta = repositorio.Buscar(numero);
                if (cuenta == null)
                {
                    MessageBox.Show("Registro no existente...");

                }
                else
                {
                    LlenaCampo(cuenta);
                    if (repositorio.Eliminar(cuenta.Id))
                    {
                        MessageBox.Show("Registro eliminado correctamente!");
                        Limpiar(this.Controls);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Error el intentar eliminar el registro");
                    }

                }

            }
            else
            {
                MessageBox.Show("Debe introducir un ID valido!");
            }
        }

        public void LlenaCampo(Cuenta cuenta)
        {
            IDnumericUpDown.Value = cuenta.Id;
            DescripcionTextBox.Text = cuenta.Descripcion;
            MontoNumericUpDown1.Value = Convert.ToDecimal(cuenta.Monto);
            TipoCuentaComboBox.SelectedValue = cuenta.TipoId;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Cuenta>();
            int numero = Convert.ToInt32(IDnumericUpDown.Value);
            Cuenta cuenta = repositorio.Buscar(numero);
            if (cuenta != null)
            {
                LlenaCampo(cuenta);
                MessageBox.Show("Registro encontrado!!!");
                return;
            }
            else
            {
                MessageBox.Show("Registro no encontrado***");
                return;
            }
        }
    }
}
