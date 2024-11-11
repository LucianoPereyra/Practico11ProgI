using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2.Windows
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void tsBorrar_Click(object sender, EventArgs e)
        {

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            frmProductosAE frm = new frmProductosAE();
            DialogResult dr = frm.ShowDialog(this);
        }
    }
}
