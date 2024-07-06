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
    public partial class FrmPeriodo_Contabilidad : Form
    {
        public FrmPeriodo_Contabilidad()
        {
            InitializeComponent();
            Cargar();
        }

        private void Cargar() 
        { 
           this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FrmPeriodo_Contabilidad_Load(object sender, EventArgs e)
        {

        }

        private void BntCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
