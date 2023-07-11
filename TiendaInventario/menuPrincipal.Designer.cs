namespace TiendaInventario
{
    partial class menuPrincipal
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
            this.labelRegresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btInventario = new System.Windows.Forms.Button();
            this.btProducto = new System.Windows.Forms.Button();
            this.btVenta = new System.Windows.Forms.Button();
            this.btCate = new System.Windows.Forms.Button();
            this.btPermisos = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRegresa
            // 
            this.labelRegresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRegresa.AutoSize = true;
            this.labelRegresa.Location = new System.Drawing.Point(79, 60);
            this.labelRegresa.Name = "labelRegresa";
            this.labelRegresa.Size = new System.Drawing.Size(35, 13);
            this.labelRegresa.TabIndex = 0;
            this.labelRegresa.Text = "label1";
            this.labelRegresa.Click += new System.EventHandler(this.labelRegresa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btInventario
            // 
            this.btInventario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btInventario.BackColor = System.Drawing.Color.SkyBlue;
            this.btInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btInventario.Location = new System.Drawing.Point(233, 105);
            this.btInventario.Name = "btInventario";
            this.btInventario.Size = new System.Drawing.Size(105, 30);
            this.btInventario.TabIndex = 2;
            this.btInventario.Text = "Inventario";
            this.btInventario.UseVisualStyleBackColor = false;
            this.btInventario.Click += new System.EventHandler(this.btInventario_Click);
            // 
            // btProducto
            // 
            this.btProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btProducto.Location = new System.Drawing.Point(233, 194);
            this.btProducto.Name = "btProducto";
            this.btProducto.Size = new System.Drawing.Size(105, 30);
            this.btProducto.TabIndex = 3;
            this.btProducto.Text = "Producto";
            this.btProducto.UseVisualStyleBackColor = false;
            this.btProducto.Click += new System.EventHandler(this.btProducto_Click);
            // 
            // btVenta
            // 
            this.btVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btVenta.Location = new System.Drawing.Point(233, 335);
            this.btVenta.Name = "btVenta";
            this.btVenta.Size = new System.Drawing.Size(105, 30);
            this.btVenta.TabIndex = 4;
            this.btVenta.Text = "Venta ";
            this.btVenta.UseVisualStyleBackColor = false;
            this.btVenta.Click += new System.EventHandler(this.btVenta_Click);
            // 
            // btCate
            // 
            this.btCate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btCate.BackColor = System.Drawing.Color.SkyBlue;
            this.btCate.Location = new System.Drawing.Point(233, 151);
            this.btCate.Name = "btCate";
            this.btCate.Size = new System.Drawing.Size(105, 28);
            this.btCate.TabIndex = 5;
            this.btCate.Text = "Categoria";
            this.btCate.UseVisualStyleBackColor = false;
            this.btCate.Click += new System.EventHandler(this.btCate_Click);
            // 
            // btPermisos
            // 
            this.btPermisos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btPermisos.Location = new System.Drawing.Point(233, 239);
            this.btPermisos.Name = "btPermisos";
            this.btPermisos.Size = new System.Drawing.Size(105, 28);
            this.btPermisos.TabIndex = 6;
            this.btPermisos.Text = "Permisos";
            this.btPermisos.UseVisualStyleBackColor = false;
            this.btPermisos.Click += new System.EventHandler(this.btPermisos_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(181, 44);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(210, 32);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Menu Principal";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUsuarios.Location = new System.Drawing.Point(233, 285);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(105, 30);
            this.btnUsuarios.TabIndex = 8;
            this.btnUsuarios.Text = "Usarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 411);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btPermisos);
            this.Controls.Add(this.btCate);
            this.Controls.Add(this.btVenta);
            this.Controls.Add(this.btProducto);
            this.Controls.Add(this.btInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRegresa);
            this.Name = "menuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInventario;
        private System.Windows.Forms.Button btProducto;
        private System.Windows.Forms.Button btVenta;
        private System.Windows.Forms.Button btCate;
        private System.Windows.Forms.Button btPermisos;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnUsuarios;
    }
}