using BLL.Periodo;
using Entity.Periodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Contabilidad.Catalogos
{
    public partial class FrmPeriodo_CRUD : Form
    {
        private ClsPeriodo ObjPeriodo = null;
        private readonly ClsPeriodoLn ObjPeriodoLn = new ClsPeriodoLn();

        public FrmPeriodo_CRUD()
        {
            InitializeComponent();
            Configuracion_controles();
        }

        private void Configuracion_controles()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TxtPeriodo.Focus();
           
        }

        private void FrmPeriodo_Contabilidad_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.DtpFechaInicialPeriodo.Focus();
        }

        private void DtpFechaInicialPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.DtpFechaFinalPeriodo.Focus();
        }

        private void DtpFechaFinalPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.CboEstadoPeriodo.Focus();
        }

        private void CboEstadoPeriodo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.DtpFechaInicialContabilizacion.Focus();
        }

        private void DtpFechaInicialContabilizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.DtpFechaFinalContabilizacion.Focus();
        }

        private void DtpFechaFinalContabilizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.DtpFechaInicialVencimiento.Focus();
        }

        private void DtpFechaInicialVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.DtpFechaFinalVencimiento.Focus();
        }

        private void DtpFechaFinalVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                this.BtnGuardar.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ObjPeriodo = new ClsPeriodo();
            {
                ObjPeriodo.Periodo = this.TxtPeriodo.Text;
                //ObjPeriodo.FechaInicioPeriodo = this.DtpFechaInicialPeriodo.Value;
                //ObjPeriodo.FechaFinalPeriodo = this.DtpFechaFinalPeriodo.Value;
                //ObjPeriodo.EstadoPeriodo = this.CboEstadoPeriodo.Text;
                //ObjPeriodo.FechaInicioContabilidad = this.DtpFechaInicialContabilizacion.Value;
                //ObjPeriodo.FechaFinalContabilidad = this.DtpFechaFinalContabilizacion.Value;
                //ObjPeriodo.FechaInicioVencimiento = this.DtpFechaInicialVencimiento.Value;
                //ObjPeriodo.FechaFinalVencimiento = this.DtpFechaFinalVencimiento.Value;
            }
            ObjPeriodoLn.Create(ref ObjPeriodo);
            if (ObjPeriodo.MensajeError == null)
            {
                MessageBox.Show("El ID:"+ObjPeriodo.ValorScalar+", fue agregado correctamente.");
            }
            else
            {
                MessageBox.Show(ObjPeriodo.MensajeError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
