using BLL.Periodo;
using Entity.Periodo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace App_Contabilidad.Catalogos
{
    public partial class FrmPeriodo_Vista : Form
    {
        private ClsPeriodo ObjPeriodo = null;
        private readonly ClsPeriodoLn ObjPeriodoLn = new ClsPeriodoLn();

        public FrmPeriodo_Vista()
        {
            InitializeComponent();
            CargarListaPeriodo();
        }

        private void CargarListaPeriodo()
        {
            ObjPeriodo = new ClsPeriodo();          
            ObjPeriodoLn.Index(ref ObjPeriodo);
            if (ObjPeriodo.MensajeError == null)
            {
                this.DgvPeriodo.DataSource = ObjPeriodo.DtResultados;
                //this.dataGridView1.DataSource = ObjPeriodo.DtResultados;
            }
            else
            {
               System.Windows.Forms.MessageBox.Show(ObjPeriodo.MensajeError, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmPeriodo_Vista_Load(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
