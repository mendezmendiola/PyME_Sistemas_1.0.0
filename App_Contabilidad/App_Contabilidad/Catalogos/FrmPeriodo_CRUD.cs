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
    }
}
