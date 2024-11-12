namespace Ejercicio2.Windows
{
    partial class frmProductosAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtcodBarra = new TextBox();
            txtPrecio = new TextBox();
            cboCategoria = new ComboBox();
            cboCantidad = new ComboBox();
            cboNombreProducto = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 89);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de barra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 54);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 16);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 184);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 4;
            label5.Text = "Precio del producto";
            // 
            // txtcodBarra
            // 
            txtcodBarra.Location = new Point(103, 86);
            txtcodBarra.Name = "txtcodBarra";
            txtcodBarra.Size = new Size(132, 23);
            txtcodBarra.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(119, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(132, 23);
            txtPrecio.TabIndex = 8;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "Arroz", "Pasta", "Carne", "Bebidas", "Aceites", "Snacks" });
            cboCategoria.Location = new Point(69, 13);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 9;
            // 
            // cboCantidad
            // 
            cboCantidad.FormattingEnabled = true;
            cboCantidad.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboCantidad.Location = new Point(66, 131);
            cboCantidad.Name = "cboCantidad";
            cboCantidad.Size = new Size(121, 23);
            cboCantidad.TabIndex = 10;
            // 
            // cboNombreProducto
            // 
            cboNombreProducto.FormattingEnabled = true;
            cboNombreProducto.Items.AddRange(new object[] { "Gallo(Arroz)", "LucchettiArroz)", "Vicente(Pasta)", "Matarazzo(Pasta)", "Vacuna(Carne)", "Porcina(Carne)", "Coca Cola(Bebidas)", "Fanta(Bebidas)", "Marolio(Aceites)", "Natura(Aceites)", "Saladix(Snacks)", "Lays(Snacks)" });
            cboNombreProducto.Location = new Point(130, 51);
            cboNombreProducto.Name = "cboNombreProducto";
            cboNombreProducto.Size = new Size(121, 23);
            cboNombreProducto.TabIndex = 11;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(9, 235);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(92, 45);
            btnOk.TabIndex = 12;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(119, 235);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 45);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmProductosAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 324);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cboNombreProducto);
            Controls.Add(cboCantidad);
            Controls.Add(cboCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtcodBarra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductosAE";
            Text = "frmProductosAE";
            Load += frmProductosAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtcodBarra;
        private TextBox txtPrecio;
        private ComboBox cboCategoria;
        private ComboBox cboCantidad;
        private ComboBox cboNombreProducto;
        private Button btnOk;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}