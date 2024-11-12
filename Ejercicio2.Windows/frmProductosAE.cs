﻿using Ejercicio2.Datos;
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
    public partial class frmProductosAE : Form
    {
        private Producto? producto;
        private RepositorioProductos? repo;
        public frmProductosAE(RepositorioProductos repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (producto is null)
                {
                    producto = new Producto();
                }

                // Asignar los valores de los controles del formulario al objeto Producto
                producto.CodigoProducto = int.Parse(txtcodBarra.Text);
                producto.DescripcionProducto = cboNombreProducto.Text;
                producto.CantidadProducto = (int)cboCantidad.SelectedItem;
                producto.PrecioProducto = int.Parse(txtPrecio.Text);
                producto.categoriaProducto = (CategoriaProducto)Enum.Parse(typeof(CategoriaProducto), cboCategoria.SelectedItem.ToString());

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool validarDatos()
        {
            bool valido = true;

            int codBarra;
            if (!int.TryParse(txtcodBarra.Text, out codBarra) || codBarra <= 0)
                
            {
                valido = false;
                errorProvider1.SetError(txtcodBarra, "Codigo de barra mal ingresado");
            }
            if (string.IsNullOrEmpty(cboNombreProducto.Text))
            {
                valido = false;
                errorProvider1.SetError(cboNombreProducto, "Nombre del producto mal ingresado");
            }

            int precio;

            if (!int.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtPrecio, "El precio fue mal ingresado o es negativo");
            }
            if (cboCategoria.SelectedIndex == -1)
            {
                valido = false;
                errorProvider1.SetError(cboCategoria, "Categoria mal seleccionada");
            }

            return valido;
        }

        private void frmProductosAE_Load(object sender, EventArgs e)
        {
            CargarDatosComboCategorias(ref cboCategoria);
        }

        private void CargarDatosComboCategorias(ref ComboBox cboCategoria)
        {
            var categorias = Enum.GetValues(typeof(CategoriaProducto));
            cboCategoria.DataSource = categorias;
            cboCategoria.SelectedIndex = 0;
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
