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

    public partial class RegistroTipoCuenta : RegistroBase
    {

        RepositorioBase<TipoCuenta> repositorio;
        public RegistroTipoCuenta()
        {
            repositorio = new RepositorioBase<TipoCuenta>();
            InitializeComponent();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(this.Controls);
        }

        private void btnGuargar_Click(object sender, EventArgs e)
        {
            if (!ValidarGuardar(this.Controls, errorProvider))
            {
                return;
            }

            TipoCuenta tipoCuenta = LlenaClase();
            if (repositorio.Guardar(tipoCuenta))
            {
                MessageBox.Show("Registro Guardado Correctamente!");
                return;
            }
            else
            {
                MessageBox.Show("Error al guardar el registro...");
                return;
            }


        }

        public TipoCuenta LlenaClase()
        {
            TipoCuenta tipoCuenta = new TipoCuenta();
            tipoCuenta.Descripcion = DescripcionTextBox.Text;
            return tipoCuenta;
        }

        public void LlenaCampo(TipoCuenta tipoCuenta)
        {
            IDnumericUpDown.Value = tipoCuenta.Id;
            DescripcionTextBox.Text = tipoCuenta.Descripcion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(IDnumericUpDown.Value);
            if (numero > 0)
            {
                TipoCuenta tipoCuenta = repositorio.Buscar(numero);
                if(tipoCuenta == null)
                {
                    MessageBox.Show("Registro no existente...");

                }
                else
                {
                    LlenaCampo(tipoCuenta);
                    if (repositorio.Eliminar(tipoCuenta.Id))
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(IDnumericUpDown.Value);
            TipoCuenta tipoCuenta = repositorio.Buscar(numero);
            if (tipoCuenta!=null)
            {
                LlenaCampo(tipoCuenta);
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
