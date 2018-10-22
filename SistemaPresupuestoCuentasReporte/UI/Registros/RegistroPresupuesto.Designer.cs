namespace SistemaPresupuestoCuentasReporte.UI.Registros
{
    partial class RegistroPresupuesto
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
            this.btnAgregarCuenta = new System.Windows.Forms.Button();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CuentaComboBox = new System.Windows.Forms.ComboBox();
            this.FechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCuentas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarFila = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources.find;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(-3, 397);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources.delete;
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
            // btnAgregarCuenta
            // 
            this.btnAgregarCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCuenta.FlatAppearance.BorderSize = 0;
            this.btnAgregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCuenta.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources._new;
            this.btnAgregarCuenta.Location = new System.Drawing.Point(213, 139);
            this.btnAgregarCuenta.Name = "btnAgregarCuenta";
            this.btnAgregarCuenta.Size = new System.Drawing.Size(23, 22);
            this.btnAgregarCuenta.TabIndex = 72;
            this.btnAgregarCuenta.UseVisualStyleBackColor = true;
            this.btnAgregarCuenta.Click += new System.EventHandler(this.btnAgregarCuenta_Click);
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTextBox.Location = new System.Drawing.Point(241, 139);
            this.ValorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(92, 22);
            this.ValorTextBox.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 70;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Cuentas";
            // 
            // CuentaComboBox
            // 
            this.CuentaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CuentaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CuentaComboBox.FormattingEnabled = true;
            this.CuentaComboBox.Location = new System.Drawing.Point(120, 139);
            this.CuentaComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.CuentaComboBox.Name = "CuentaComboBox";
            this.CuentaComboBox.Size = new System.Drawing.Size(92, 24);
            this.CuentaComboBox.TabIndex = 68;
            // 
            // FechaTimePicker
            // 
            this.FechaTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaTimePicker.Location = new System.Drawing.Point(120, 105);
            this.FechaTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.FechaTimePicker.Name = "FechaTimePicker";
            this.FechaTimePicker.Size = new System.Drawing.Size(91, 22);
            this.FechaTimePicker.TabIndex = 67;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(120, 64);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(234, 22);
            this.DescripcionTextBox.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Descripcion";
            // 
            // dataGridViewCuentas
            // 
            this.dataGridViewCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCuentas.Location = new System.Drawing.Point(-3, 178);
            this.dataGridViewCuentas.Name = "dataGridViewCuentas";
            this.dataGridViewCuentas.Size = new System.Drawing.Size(376, 193);
            this.dataGridViewCuentas.TabIndex = 73;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources._new;
            this.btnAgregar.Location = new System.Drawing.Point(337, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.TabIndex = 74;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarFila
            // 
            this.btnEliminarFila.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarFila.FlatAppearance.BorderSize = 0;
            this.btnEliminarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFila.Image = global::SistemaPresupuestoCuentasReporte.Properties.Resources.delete;
            this.btnEliminarFila.Location = new System.Drawing.Point(9, 375);
            this.btnEliminarFila.Name = "btnEliminarFila";
            this.btnEliminarFila.Size = new System.Drawing.Size(23, 22);
            this.btnEliminarFila.TabIndex = 75;
            this.btnEliminarFila.UseVisualStyleBackColor = true;
            this.btnEliminarFila.Click += new System.EventHandler(this.btnEliminarFila_Click);
            // 
            // RegistroPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 504);
            this.Controls.Add(this.btnEliminarFila);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewCuentas);
            this.Controls.Add(this.btnAgregarCuenta);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CuentaComboBox);
            this.Controls.Add(this.FechaTimePicker);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "RegistroPresupuesto";
            this.Text = "RegistroPresupuesto";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.IDnumericUpDown, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.DescripcionTextBox, 0);
            this.Controls.SetChildIndex(this.FechaTimePicker, 0);
            this.Controls.SetChildIndex(this.CuentaComboBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.ValorTextBox, 0);
            this.Controls.SetChildIndex(this.btnAgregarCuenta, 0);
            this.Controls.SetChildIndex(this.dataGridViewCuentas, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminarFila, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCuenta;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CuentaComboBox;
        private System.Windows.Forms.DateTimePicker FechaTimePicker;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCuentas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarFila;
    }
}