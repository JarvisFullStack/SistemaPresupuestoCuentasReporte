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
    public partial class RegistroBase : Form
    {
        public RegistroBase()
        {
            InitializeComponent();
        }

        

        public bool ValidarGuardar(Control.ControlCollection Controls, ErrorProvider Provider)
        {
            bool paso = true;
            foreach(Control control in Controls)
            {
                if (control is GroupBox)
                {
                    //ValidarGuardar(((Form.ControlCollection)((GroupBox)control).Controls), Provider);
                    if (!((GroupBox)control).Text.Contains("~"))
                    {
                        ValidarGuardar((((GroupBox)control).Controls), Provider);
                    }
                    
                }

                if (control is TextBox || control is RichTextBox)
                {
                    if (!((TextBoxBase)control).Text.Contains("~")){
                        if (String.IsNullOrWhiteSpace(((TextBoxBase)control).Text))
                        {
                            paso = false;
                            Provider.SetError(control, "Debe llenar este campo");
                        }
                    }
                    
                }
            }

            return paso;
        }

        public void Limpiar(Control.ControlCollection Controls)
        {
            foreach(Control control in Controls)
            {
                if(control is GroupBox)
                {
                    Limpiar(((GroupBox)control).Controls);
                }
                if(control is TextBox || control is RichTextBox)
                {
                    ((TextBoxBase)control).Text = "";
                }

                if(control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }

                if(control is ComboBox)
                {
                    ((ComboBox)control).ResetText();
                }

            }

            return;
        }

       
    }
}
