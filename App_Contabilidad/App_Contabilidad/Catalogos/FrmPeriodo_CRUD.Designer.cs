namespace App_Contabilidad.Catalogos
{
    partial class FrmPeriodo_CRUD
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
            this.GpbPeriodo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CboEstadoPeriodo = new System.Windows.Forms.ComboBox();
            this.DtpFechaFinalPeriodo = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicialPeriodo = new System.Windows.Forms.DateTimePicker();
            this.TxtPeriodo = new System.Windows.Forms.TextBox();
            this.GpbOperacion = new System.Windows.Forms.GroupBox();
            this.DtpFechaFinalVencimiento = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaFinalContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DtpFechaInicialVencimiento = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaInicialContabilizacion = new System.Windows.Forms.DateTimePicker();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.GpbPeriodo.SuspendLayout();
            this.GpbOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbPeriodo
            // 
            this.GpbPeriodo.Controls.Add(this.label4);
            this.GpbPeriodo.Controls.Add(this.label3);
            this.GpbPeriodo.Controls.Add(this.label2);
            this.GpbPeriodo.Controls.Add(this.label1);
            this.GpbPeriodo.Controls.Add(this.CboEstadoPeriodo);
            this.GpbPeriodo.Controls.Add(this.DtpFechaFinalPeriodo);
            this.GpbPeriodo.Controls.Add(this.DtpFechaInicialPeriodo);
            this.GpbPeriodo.Controls.Add(this.TxtPeriodo);
            this.GpbPeriodo.Location = new System.Drawing.Point(21, 33);
            this.GpbPeriodo.Name = "GpbPeriodo";
            this.GpbPeriodo.Size = new System.Drawing.Size(378, 229);
            this.GpbPeriodo.TabIndex = 17;
            this.GpbPeriodo.TabStop = false;
            this.GpbPeriodo.Text = "Periodo Contable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Fecha inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Periodo:";
            // 
            // CboEstadoPeriodo
            // 
            this.CboEstadoPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CboEstadoPeriodo.FormattingEnabled = true;
            this.CboEstadoPeriodo.Location = new System.Drawing.Point(163, 157);
            this.CboEstadoPeriodo.Name = "CboEstadoPeriodo";
            this.CboEstadoPeriodo.Size = new System.Drawing.Size(164, 28);
            this.CboEstadoPeriodo.TabIndex = 14;
            this.CboEstadoPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboEstadoPeriodo_KeyPress);
            // 
            // DtpFechaFinalPeriodo
            // 
            this.DtpFechaFinalPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinalPeriodo.Location = new System.Drawing.Point(163, 125);
            this.DtpFechaFinalPeriodo.Name = "DtpFechaFinalPeriodo";
            this.DtpFechaFinalPeriodo.Size = new System.Drawing.Size(164, 26);
            this.DtpFechaFinalPeriodo.TabIndex = 2;
            this.DtpFechaFinalPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaFinalPeriodo_KeyPress);
            // 
            // DtpFechaInicialPeriodo
            // 
            this.DtpFechaInicialPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicialPeriodo.Location = new System.Drawing.Point(163, 93);
            this.DtpFechaInicialPeriodo.Name = "DtpFechaInicialPeriodo";
            this.DtpFechaInicialPeriodo.Size = new System.Drawing.Size(164, 26);
            this.DtpFechaInicialPeriodo.TabIndex = 1;
            this.DtpFechaInicialPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaInicialPeriodo_KeyPress);
            // 
            // TxtPeriodo
            // 
            this.TxtPeriodo.Location = new System.Drawing.Point(161, 55);
            this.TxtPeriodo.Multiline = true;
            this.TxtPeriodo.Name = "TxtPeriodo";
            this.TxtPeriodo.Size = new System.Drawing.Size(166, 30);
            this.TxtPeriodo.TabIndex = 0;
            this.TxtPeriodo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPeriodo_KeyPress);
            // 
            // GpbOperacion
            // 
            this.GpbOperacion.Controls.Add(this.DtpFechaFinalVencimiento);
            this.GpbOperacion.Controls.Add(this.DtpFechaFinalContabilizacion);
            this.GpbOperacion.Controls.Add(this.label10);
            this.GpbOperacion.Controls.Add(this.label9);
            this.GpbOperacion.Controls.Add(this.label5);
            this.GpbOperacion.Controls.Add(this.label6);
            this.GpbOperacion.Controls.Add(this.label7);
            this.GpbOperacion.Controls.Add(this.label8);
            this.GpbOperacion.Controls.Add(this.DtpFechaInicialVencimiento);
            this.GpbOperacion.Controls.Add(this.DtpFechaInicialContabilizacion);
            this.GpbOperacion.Location = new System.Drawing.Point(21, 280);
            this.GpbOperacion.Name = "GpbOperacion";
            this.GpbOperacion.Size = new System.Drawing.Size(631, 149);
            this.GpbOperacion.TabIndex = 18;
            this.GpbOperacion.TabStop = false;
            this.GpbOperacion.Text = "Fecha Operacion:";
            // 
            // DtpFechaFinalVencimiento
            // 
            this.DtpFechaFinalVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinalVencimiento.Location = new System.Drawing.Point(443, 95);
            this.DtpFechaFinalVencimiento.Name = "DtpFechaFinalVencimiento";
            this.DtpFechaFinalVencimiento.Size = new System.Drawing.Size(164, 26);
            this.DtpFechaFinalVencimiento.TabIndex = 21;
            this.DtpFechaFinalVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaFinalVencimiento_KeyPress);
            // 
            // DtpFechaFinalContabilizacion
            // 
            this.DtpFechaFinalContabilizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFinalContabilizacion.Location = new System.Drawing.Point(443, 59);
            this.DtpFechaFinalContabilizacion.Name = "DtpFechaFinalContabilizacion";
            this.DtpFechaFinalContabilizacion.Size = new System.Drawing.Size(164, 26);
            this.DtpFechaFinalContabilizacion.TabIndex = 2;
            this.DtpFechaFinalContabilizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaFinalContabilizacion_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Hasta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hasta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Desde:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Vencimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contabilizacion:";
            // 
            // DtpFechaInicialVencimiento
            // 
            this.DtpFechaInicialVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicialVencimiento.Location = new System.Drawing.Point(214, 95);
            this.DtpFechaInicialVencimiento.Name = "DtpFechaInicialVencimiento";
            this.DtpFechaInicialVencimiento.Size = new System.Drawing.Size(164, 26);
            this.DtpFechaInicialVencimiento.TabIndex = 20;
            this.DtpFechaInicialVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaInicialVencimiento_KeyPress);
            // 
            // DtpFechaInicialContabilizacion
            // 
            this.DtpFechaInicialContabilizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicialContabilizacion.Location = new System.Drawing.Point(214, 60);
            this.DtpFechaInicialContabilizacion.Name = "DtpFechaInicialContabilizacion";
            this.DtpFechaInicialContabilizacion.Size = new System.Drawing.Size(164, 26);
            this.DtpFechaInicialContabilizacion.TabIndex = 1;
            this.DtpFechaInicialContabilizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DtpFechaInicialContabilizacion_KeyPress);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(1155, 566);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(124, 48);
            this.BtnCerrar.TabIndex = 100;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(504, 211);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(124, 48);
            this.BtnEliminar.TabIndex = 22;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(504, 103);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(124, 48);
            this.BtnGuardar.TabIndex = 19;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(504, 157);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(124, 48);
            this.BtnModificar.TabIndex = 20;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // FrmPeriodo_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1303, 637);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GpbOperacion);
            this.Controls.Add(this.GpbPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeriodo_CRUD";
            this.Load += new System.EventHandler(this.FrmPeriodo_Contabilidad_Load);
            this.GpbPeriodo.ResumeLayout(false);
            this.GpbPeriodo.PerformLayout();
            this.GpbOperacion.ResumeLayout(false);
            this.GpbOperacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GpbPeriodo;
        private System.Windows.Forms.DateTimePicker DtpFechaInicialPeriodo;
        private System.Windows.Forms.TextBox TxtPeriodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboEstadoPeriodo;
        private System.Windows.Forms.DateTimePicker DtpFechaFinalPeriodo;
        private System.Windows.Forms.GroupBox GpbOperacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DtpFechaInicialVencimiento;
        private System.Windows.Forms.DateTimePicker DtpFechaInicialContabilizacion;
        private System.Windows.Forms.DateTimePicker DtpFechaFinalContabilizacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpFechaFinalVencimiento;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
    }
}