using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_General.Principal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Cargar();
        }

        private void Cargar() 
        {
            this.ControlBox = false;
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAcceso_Click(object sender, EventArgs e)
        {
            FrmPrincipal_General Principal = new FrmPrincipal_General();
            Principal.Show();
        }
    }
}
