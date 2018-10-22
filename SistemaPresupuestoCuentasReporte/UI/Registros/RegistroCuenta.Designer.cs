namespace SistemaPresupuestoCuentasReporte.UI.Registros
{
    partial class RegistroCuenta 
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
            this.MontoNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarTipoCuenta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoCuentaComboBox = new System.Windows.Forms.ComboBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources.find;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 188);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources.delete;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuargar
            // 
            this.btnGuargar.FlatAppearance.BorderSize = 0;
            this.btnGuargar.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources.save;
            this.btnGuargar.Click += new System.EventHandler(this.btnGuargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources._new;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 31);
            // 
            // MontoNumericUpDown1
            // 
            this.MontoNumericUpDown1.DecimalPlaces = 2;
            this.MontoNumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoNumericUpDown1.Location = new System.Drawing.Point(117, 106);
            this.MontoNumericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.MontoNumericUpDown1.Name = "MontoNumericUpDown1";
            this.MontoNumericUpDown1.Size = new System.Drawing.Size(173, 22);
            this.MontoNumericUpDown1.TabIndex = 70;
            // 
            // btnAgregarTipoCuenta
            // 
            this.btnAgregarTipoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarTipoCuenta.FlatAppearance.BorderSize = 0;
            this.btnAgregarTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTipoCuenta.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources._new;
            this.btnAgregarTipoCuenta.Location = new System.Drawing.Point(210, 142);
            this.btnAgregarTipoCuenta.Name = "btnAgregarTipoCuenta";
            this.btnAgregarTipoCuenta.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarTipoCuenta.TabIndex = 69;
            this.btnAgregarTipoCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarTipoCuenta.Click += new System.EventHandler(this.btnAgregarTipoCuenta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Tipo Cuenta";
            // 
            // TipoCuentaComboBox
            // 
            this.TipoCuentaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoCuentaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoCuentaComboBox.FormattingEnabled = true;
            this.TipoCuentaComboBox.Location = new System.Drawing.Point(117, 142);
            this.TipoCuentaComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TipoCuentaComboBox.Name = "TipoCuentaComboBox";
            this.TipoCuentaComboBox.Size = new System.Drawing.Size(92, 24);
            this.TipoCuentaComboBox.TabIndex = 67;
            this.TipoCuentaComboBox.Click += new System.EventHandler(this.TipoCuentaComboBox_Click);
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(117, 67);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(234, 22);
            this.DescripcionTextBox.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Monto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Descripcion";
            // 
            // RegistroCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 258);
            this.Controls.Add(this.MontoNumericUpDown1);
            this.Controls.Add(this.btnAgregarTipoCuenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipoCuentaComboBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RegistroCuenta";
            this.Text = "RegistroCuenta";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.IDnumericUpDown, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.DescripcionTextBox, 0);
            this.Controls.SetChildIndex(this.TipoCuentaComboBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnAgregarTipoCuenta, 0);
            this.Controls.SetChildIndex(this.MontoNumericUpDown1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown MontoNumericUpDown1;
        private System.Windows.Forms.Button btnAgregarTipoCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipoCuentaComboBox;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}