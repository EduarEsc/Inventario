namespace TiendaInventario
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.lbTaPro = new System.Windows.Forms.Label();
            this.datagritProductos = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tBProducto = new System.Windows.Forms.TextBox();
            this.lbProd = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.lbCodi = new System.Windows.Forms.Label();
            this.tBCodi = new System.Windows.Forms.TextBox();
            this.tBPrec = new System.Windows.Forms.TextBox();
            this.lbPrec = new System.Windows.Forms.Label();
            this.lbCate = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagritProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTaPro
            // 
            this.lbTaPro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTaPro.AutoSize = true;
            this.lbTaPro.BackColor = System.Drawing.Color.Transparent;
            this.lbTaPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTaPro.Location = new System.Drawing.Point(390, 39);
            this.lbTaPro.Name = "lbTaPro";
            this.lbTaPro.Size = new System.Drawing.Size(181, 37);
            this.lbTaPro.TabIndex = 0;
            this.lbTaPro.Text = " Productos";
            this.lbTaPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagritProductos
            // 
            this.datagritProductos.AllowUserToAddRows = false;
            this.datagritProductos.AllowUserToDeleteRows = false;
            this.datagritProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datagritProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagritProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.datagritProductos.Location = new System.Drawing.Point(56, 208);
            this.datagritProductos.Name = "datagritProductos";
            this.datagritProductos.ReadOnly = true;
            this.datagritProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagritProductos.Size = new System.Drawing.Size(836, 315);
            this.datagritProductos.TabIndex = 1;
            this.datagritProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagritProductos_CellContentClick);
            this.datagritProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagritProductos_CellDoubleClick);
            // 
            // Editar
            // 
            this.Editar.FillWeight = 50F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // tBProducto
            // 
            this.tBProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBProducto.Location = new System.Drawing.Point(169, 175);
            this.tBProducto.Name = "tBProducto";
            this.tBProducto.ShortcutsEnabled = false;
            this.tBProducto.Size = new System.Drawing.Size(100, 20);
            this.tBProducto.TabIndex = 2;
            this.tBProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBProducto_KeyPress);
            // 
            // lbProd
            // 
            this.lbProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbProd.AutoSize = true;
            this.lbProd.Location = new System.Drawing.Point(100, 178);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(53, 13);
            this.lbProd.TabIndex = 3;
            this.lbProd.Text = "Producto:";
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(325, 175);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(66, 13);
            this.lbDesc.TabIndex = 4;
            this.lbDesc.Text = "Descripcion:";
            // 
            // tBDesc
            // 
            this.tBDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBDesc.Location = new System.Drawing.Point(397, 171);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.ShortcutsEnabled = false;
            this.tBDesc.Size = new System.Drawing.Size(100, 20);
            this.tBDesc.TabIndex = 5;
            this.tBDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDesc_KeyPress);
            // 
            // lbCodi
            // 
            this.lbCodi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCodi.AutoSize = true;
            this.lbCodi.Location = new System.Drawing.Point(537, 175);
            this.lbCodi.Name = "lbCodi";
            this.lbCodi.Size = new System.Drawing.Size(43, 13);
            this.lbCodi.TabIndex = 6;
            this.lbCodi.Text = "Codigo:";
            // 
            // tBCodi
            // 
            this.tBCodi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBCodi.Location = new System.Drawing.Point(586, 172);
            this.tBCodi.Name = "tBCodi";
            this.tBCodi.ShortcutsEnabled = false;
            this.tBCodi.Size = new System.Drawing.Size(81, 20);
            this.tBCodi.TabIndex = 7;
            this.tBCodi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCodi_KeyPress);
            // 
            // tBPrec
            // 
            this.tBPrec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBPrec.Location = new System.Drawing.Point(756, 172);
            this.tBPrec.Name = "tBPrec";
            this.tBPrec.ShortcutsEnabled = false;
            this.tBPrec.Size = new System.Drawing.Size(100, 20);
            this.tBPrec.TabIndex = 8;
            this.tBPrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPrec_KeyPress);
            // 
            // lbPrec
            // 
            this.lbPrec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPrec.AutoSize = true;
            this.lbPrec.Location = new System.Drawing.Point(710, 178);
            this.lbPrec.Name = "lbPrec";
            this.lbPrec.Size = new System.Drawing.Size(40, 13);
            this.lbPrec.TabIndex = 9;
            this.lbPrec.Text = "Precio:";
            // 
            // lbCate
            // 
            this.lbCate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCate.AutoSize = true;
            this.lbCate.Location = new System.Drawing.Point(98, 146);
            this.lbCate.Name = "lbCate";
            this.lbCate.Size = new System.Drawing.Size(55, 13);
            this.lbCate.TabIndex = 10;
            this.lbCate.Text = "Categoria:";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(756, 101);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(113, 39);
            this.btRegistrar.TabIndex = 12;
            this.btRegistrar.Text = "Agregar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Actualizar";
            this.dataGridViewImageColumn1.Image = global::TiendaInventario.Properties.Resources._1Actualizar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::TiendaInventario.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // CBCategoria
            // 
            this.CBCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Location = new System.Drawing.Point(169, 138);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(121, 21);
            this.CBCategoria.TabIndex = 13;
            this.CBCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBCategoria_KeyPress);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 525);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lbCate);
            this.Controls.Add(this.lbPrec);
            this.Controls.Add(this.tBPrec);
            this.Controls.Add(this.tBCodi);
            this.Controls.Add(this.lbCodi);
            this.Controls.Add(this.tBDesc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.tBProducto);
            this.Controls.Add(this.datagritProductos);
            this.Controls.Add(this.lbTaPro);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.datagritProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaPro;
        private System.Windows.Forms.DataGridView datagritProductos;
        private System.Windows.Forms.TextBox tBProducto;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.Label lbCodi;
        private System.Windows.Forms.TextBox tBCodi;
        private System.Windows.Forms.TextBox tBPrec;
        private System.Windows.Forms.Label lbPrec;
        private System.Windows.Forms.Label lbCate;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}