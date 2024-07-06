using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using App_Contabilidad.Principal;


namespace App_General.Principal
{
    public partial class FrmPrincipal_General : Form
    {
        public FrmPrincipal_General()
        {
            InitializeComponent();
            Cargar();
        }


        private void Cargar()
        {
            this.WindowState = FormWindowState.Maximized;

        }          
        
        private void FrmPrincipal_General_Load(object sender, EventArgs e)
        {
                Form Formulario = new FrmLogin();
                Formulario.Close();
            
        }

        private void contabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario = new FrmPrincipal_Contabilidad();
            // Formulario.MdiParent = this;
            Formulario.Show();

        }
    }
}
