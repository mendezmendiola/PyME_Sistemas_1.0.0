namespace App_Contabilidad.Catalogos
{
    partial class FrmPeriodo_Vista
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DgvPeriodo = new System.Windows.Forms.DataGridView();
            this.IDPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinalPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioContabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinalContabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinalVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Location = new System.Drawing.Point(1155, 566);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(124, 48);
            this.BtnCerrar.TabIndex = 101;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DgvPeriodo
            // 
            this.DgvPeriodo.AllowUserToAddRows = false;
            this.DgvPeriodo.AllowUserToDeleteRows = false;
            this.DgvPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPeriodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeriodo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPeriodo,
            this.Periodo,
            this.FechaInicioPeriodo,
            this.FechaFinalPeriodo,
            this.EstadoPeriodo,
            this.FechaInicioContabilidad,
            this.FechaFinalContabilidad,
            this.FechaInicioVencimiento,
            this.FechaFinalVencimiento,
            this.FechaCreacion});
            this.DgvPeriodo.Location = new System.Drawing.Point(21, 28);
            this.DgvPeriodo.Name = "DgvPeriodo";
            this.DgvPeriodo.ReadOnly = true;
            this.DgvPeriodo.RowHeadersWidth = 62;
            this.DgvPeriodo.RowTemplate.Height = 28;
            this.DgvPeriodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPeriodo.Size = new System.Drawing.Size(1258, 511);
            this.DgvPeriodo.TabIndex = 102;
            // 
            // IDPeriodo
            // 
            this.IDPeriodo.DataPropertyName = "IDPeriodo";
            this.IDPeriodo.HeaderText = "ID";
            this.IDPeriodo.MinimumWidth = 8;
            this.IDPeriodo.Name = "IDPeriodo";
            this.IDPeriodo.ReadOnly = true;
            this.IDPeriodo.Visible = false;
            this.IDPeriodo.Width = 150;
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "Periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 8;
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Width = 140;
            // 
            // FechaInicioPeriodo
            // 
            this.FechaInicioPeriodo.DataPropertyName = "FechaInicioPeriodo";
            this.FechaInicioPeriodo.HeaderText = "Inicio Periodo";
            this.FechaInicioPeriodo.MinimumWidth = 8;
            this.FechaInicioPeriodo.Name = "FechaInicioPeriodo";
            this.FechaInicioPeriodo.ReadOnly = true;
            this.FechaInicioPeriodo.Width = 145;
            // 
            // FechaFinalPeriodo
            // 
            this.FechaFinalPeriodo.DataPropertyName = "FechaFinalPeriodo";
            this.FechaFinalPeriodo.HeaderText = "Final Periodo";
            this.FechaFinalPeriodo.MinimumWidth = 8;
            this.FechaFinalPeriodo.Name = "FechaFinalPeriodo";
            this.FechaFinalPeriodo.ReadOnly = true;
            this.FechaFinalPeriodo.Width = 145;
            // 
            // EstadoPeriodo
            // 
            this.EstadoPeriodo.DataPropertyName = "EstadoPeriodo";
            this.EstadoPeriodo.HeaderText = "Habilitado";
            this.EstadoPeriodo.MinimumWidth = 8;
            this.EstadoPeriodo.Name = "EstadoPeriodo";
            this.EstadoPeriodo.ReadOnly = true;
            this.EstadoPeriodo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EstadoPeriodo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.EstadoPeriodo.Width = 150;
            // 
            // FechaInicioContabilidad
            // 
            this.FechaInicioContabilidad.DataPropertyName = "FechaInicioContabilidad";
            this.FechaInicioContabilidad.HeaderText = "Inicio Contabilidad";
            this.FechaInicioContabilidad.MinimumWidth = 8;
            this.FechaInicioContabilidad.Name = "FechaInicioContabilidad";
            this.FechaInicioContabilidad.ReadOnly = true;
            this.FechaInicioContabilidad.Width = 160;
            // 
            // FechaFinalContabilidad
            // 
            this.FechaFinalContabilidad.DataPropertyName = "FechaFinalContabilidad";
            this.FechaFinalContabilidad.HeaderText = "Final Contabilidad";
            this.FechaFinalContabilidad.MinimumWidth = 8;
            this.FechaFinalContabilidad.Name = "FechaFinalContabilidad";
            this.FechaFinalContabilidad.ReadOnly = true;
            this.FechaFinalContabilidad.Width = 160;
            // 
            // FechaInicioVencimiento
            // 
            this.FechaInicioVencimiento.DataPropertyName = "FechaInicioVencimiento";
            this.FechaInicioVencimiento.HeaderText = "Inicio Vencimiento";
            this.FechaInicioVencimiento.MinimumWidth = 8;
            this.FechaInicioVencimiento.Name = "FechaInicioVencimiento";
            this.FechaInicioVencimiento.ReadOnly = true;
            this.FechaInicioVencimiento.Width = 160;
            // 
            // FechaFinalVencimiento
            // 
            this.FechaFinalVencimiento.DataPropertyName = "FechaFinalVencimiento";
            this.FechaFinalVencimiento.HeaderText = "Final Vencimiento";
            this.FechaFinalVencimiento.MinimumWidth = 8;
            this.FechaFinalVencimiento.Name = "FechaFinalVencimiento";
            this.FechaFinalVencimiento.ReadOnly = true;
            this.FechaFinalVencimiento.Width = 160;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "FechaCreacion";
            this.FechaCreacion.MinimumWidth = 8;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Visible = false;
            this.FechaCreacion.Width = 150;
            // 
            // FrmPeriodo_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1304, 637);
            this.Controls.Add(this.DgvPeriodo);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPeriodo_Vista";
            this.Load += new System.EventHandler(this.FrmPeriodo_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView DgvPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinalPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioContabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinalContabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinalVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
    }
}