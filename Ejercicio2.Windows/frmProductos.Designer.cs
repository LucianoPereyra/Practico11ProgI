namespace Ejercicio2.Windows
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            toolStrip1 = new ToolStrip();
            tsbAgregar = new ToolStripButton();
            tsBorrar = new ToolStripButton();
            tsbBuscar = new ToolStripButton();
            tsbOrdenar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            panel = new Panel();
            panelGrilla = new Panel();
            dataGridView1 = new DataGridView();
            ColArroz = new DataGridViewTextBoxColumn();
            colPasta = new DataGridViewTextBoxColumn();
            colCarne = new DataGridViewTextBoxColumn();
            colBebidas = new DataGridViewTextBoxColumn();
            colAceites = new DataGridViewTextBoxColumn();
            colSnacks = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsBorrar, tsbBuscar, tsbOrdenar, tsbEditar, tsbActualizar, toolStripSeparator1, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(710, 38);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbAgregar
            // 
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
            tsbAgregar.ImageScaling = ToolStripItemImageScaling.None;
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(53, 35);
            tsbAgregar.Text = "Agregar";
            tsbAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbAgregar.Click += tsbAgregar_Click;
            // 
            // tsBorrar
            // 
            tsBorrar.Image = (Image)resources.GetObject("tsBorrar.Image");
            tsBorrar.ImageTransparentColor = Color.Magenta;
            tsBorrar.Name = "tsBorrar";
            tsBorrar.Size = new Size(43, 35);
            tsBorrar.Text = "Borrar";
            tsBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsBorrar.Click += tsBorrar_Click;
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = (Image)resources.GetObject("tsbBuscar.Image");
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(46, 35);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.Image = (Image)resources.GetObject("tsbOrdenar.Image");
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(54, 35);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 35);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = (Image)resources.GetObject("tsbActualizar.Image");
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 35);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = (Image)resources.GetObject("tsbSalir.Image");
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(33, 35);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // panel
            // 
            panel.Dock = DockStyle.Bottom;
            panel.Location = new Point(0, 364);
            panel.Name = "panel";
            panel.Size = new Size(710, 44);
            panel.TabIndex = 1;
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dataGridView1);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 38);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(710, 326);
            panelGrilla.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColArroz, colPasta, colCarne, colBebidas, colAceites, colSnacks });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(710, 326);
            dataGridView1.TabIndex = 0;
            // 
            // ColArroz
            // 
            ColArroz.HeaderText = "Arroz";
            ColArroz.Name = "ColArroz";
            ColArroz.ReadOnly = true;
            // 
            // colPasta
            // 
            colPasta.HeaderText = "Pasta";
            colPasta.Name = "colPasta";
            colPasta.ReadOnly = true;
            // 
            // colCarne
            // 
            colCarne.HeaderText = "Carne";
            colCarne.Name = "colCarne";
            colCarne.ReadOnly = true;
            // 
            // colBebidas
            // 
            colBebidas.HeaderText = "Bebidas";
            colBebidas.Name = "colBebidas";
            colBebidas.ReadOnly = true;
            // 
            // colAceites
            // 
            colAceites.HeaderText = "Aceites";
            colAceites.Name = "colAceites";
            colAceites.ReadOnly = true;
            // 
            // colSnacks
            // 
            colSnacks.HeaderText = "Snacks";
            colSnacks.Name = "colSnacks";
            colSnacks.ReadOnly = true;
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 408);
            Controls.Add(panelGrilla);
            Controls.Add(panel);
            Controls.Add(toolStrip1);
            Name = "frmProductos";
            Text = "frmProductos";
            Load += frmProductos_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsBorrar;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbOrdenar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbSalir;
        private Panel panel;
        private Panel panelGrilla;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColArroz;
        private DataGridViewTextBoxColumn colPasta;
        private DataGridViewTextBoxColumn colCarne;
        private DataGridViewTextBoxColumn colBebidas;
        private DataGridViewTextBoxColumn colAceites;
        private DataGridViewTextBoxColumn colSnacks;
    }
}