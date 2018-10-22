namespace SistemaPresupuestoCuentasReporte.UI.Consultas
{
    partial class ConsultaPresupuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.presupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Size = new System.Drawing.Size(283, 29);
            this.label5.Text = "Consulta de Presupuesto";
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.FlatAppearance.BorderSize = 0;
            // 
            // BuscarButton
            // 
            this.BuscarButton.FlatAppearance.BorderSize = 0;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // presupuestoBindingSource
            // 
            this.presupuestoBindingSource.DataSource = typeof(SistemaPresupuestoCuentasReporte.Entidades.Presupuesto);
            // 
            // ConsultaPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 499);
            this.Name = "ConsultaPresupuesto";
            this.Text = "ConsultaPresupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.presupuestoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource presupuestoBindingSource;
    }
}