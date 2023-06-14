namespace TiendaInventario
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.lbTaInv = new System.Windows.Forms.Label();
            this.datagridInventario = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbClaProd = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.CBProd = new System.Windows.Forms.ComboBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tBCantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTaInv
            // 
            this.lbTaInv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTaInv.AutoSize = true;
            this.lbTaInv.BackColor = System.Drawing.Color.Transparent;
            this.lbTaInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTaInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTaInv.Location = new System.Drawing.Point(295, 23);
            this.lbTaInv.Name = "lbTaInv";
            this.lbTaInv.Size = new System.Drawing.Size(168, 39);
            this.lbTaInv.TabIndex = 0;
            this.lbTaInv.Text = "Inventario";
            this.lbTaInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagridInventario
            // 
            this.datagridInventario.AllowUserToAddRows = false;
            this.datagridInventario.AllowUserToDeleteRows = false;
            this.datagridInventario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datagridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.datagridInventario.Location = new System.Drawing.Point(72, 211);
            this.datagridInventario.Name = "datagridInventario";
            this.datagridInventario.ReadOnly = true;
            this.datagridInventario.Size = new System.Drawing.Size(645, 272);
            this.datagridInventario.TabIndex = 1;
            this.datagridInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridInventario_CellContentClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lbClaProd
            // 
            this.lbClaProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClaProd.AutoSize = true;
            this.lbClaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClaProd.ForeColor = System.Drawing.Color.Navy;
            this.lbClaProd.Location = new System.Drawing.Point(82, 130);
            this.lbClaProd.Name = "lbClaProd";
            this.lbClaProd.Size = new System.Drawing.Size(137, 20);
            this.lbClaProd.TabIndex = 2;
            this.lbClaProd.Text = "Clave Producto";
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.ForeColor = System.Drawing.Color.Black;
            this.btAgregar.Location = new System.Drawing.Point(544, 146);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(138, 37);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // CBProd
            // 
            this.CBProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBProd.FormattingEnabled = true;
            this.CBProd.Location = new System.Drawing.Point(265, 132);
            this.CBProd.Name = "CBProd";
            this.CBProd.Size = new System.Drawing.Size(129, 21);
            this.CBProd.TabIndex = 5;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lbCantidad.Location = new System.Drawing.Point(136, 175);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(83, 20);
            this.lbCantidad.TabIndex = 6;
            this.lbCantidad.Text = "Cantidad";
            // 
            // tBCantidad
            // 
            this.tBCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBCantidad.Location = new System.Drawing.Point(265, 175);
            this.tBCantidad.Name = "tBCantidad";
            this.tBCantidad.ShortcutsEnabled = false;
            this.tBCantidad.Size = new System.Drawing.Size(129, 20);
            this.tBCantidad.TabIndex = 7;
            this.tBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBCantidad_KeyPress);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(816, 495);
            this.Controls.Add(this.tBCantidad);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.CBProd);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lbClaProd);
            this.Controls.Add(this.datagridInventario);
            this.Controls.Add(this.lbTaInv);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaInv;
        private System.Windows.Forms.DataGridView datagridInventario;
        private System.Windows.Forms.Label lbClaProd;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ComboBox CBProd;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox tBCantidad;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}