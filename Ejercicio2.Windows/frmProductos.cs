using Ejercicio2.Datos;
using Ejercicio2.Entidades;
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

        private RepositorioProductos? repo;

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
            frmProductosAE frm = new frmProductosAE(repo);
            DialogResult dr = frm.ShowDialog(this);
        }
    }
}
