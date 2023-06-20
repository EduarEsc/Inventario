namespace TiendaInventario.Alertas
{
    partial class AlertaInventario
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
            this.lbClaveProducto = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.tBCant = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.CBClaProd = new System.Windows.Forms.ComboBox();
            this.lbTaInv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClaveProducto
            // 
            this.lbClaveProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbClaveProducto.AutoSize = true;
            this.lbClaveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClaveProducto.Location = new System.Drawing.Point(50, 108);
            this.lbClaveProducto.Name = "lbClaveProducto";
            this.lbClaveProducto.Size = new System.Drawing.Size(146, 25);
            this.lbClaveProducto.TabIndex = 0;
            this.lbClaveProducto.Text = "Clave Producto";
            this.lbClaveProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(105, 175);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(91, 25);
            this.lbCantidad.TabIndex = 1;
            this.lbCantidad.Text = "Cantidad";
            this.lbCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBCant
            // 
            this.tBCant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBCant.Location = new System.Drawing.Point(262, 175);
            this.tBCant.Name = "tBCant";
            this.tBCant.Size = new System.Drawing.Size(121, 20);
            this.tBCant.TabIndex = 3;
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAgregar.BackColor = System.Drawing.Color.LimeGreen;
            this.btAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgregar.Location = new System.Drawing.Point(168, 240);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(112, 42);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // CBClaProd
            // 
            this.CBClaProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBClaProd.FormattingEnabled = true;
            this.CBClaProd.Location = new System.Drawing.Point(262, 108);
            this.CBClaProd.Name = "CBClaProd";
            this.CBClaProd.Size = new System.Drawing.Size(121, 21);
            this.CBClaProd.TabIndex = 6;
            // 
            // lbTaInv
            // 
            this.lbTaInv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTaInv.AutoSize = true;
            this.lbTaInv.BackColor = System.Drawing.Color.Transparent;
            this.lbTaInv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTaInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaInv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTaInv.Location = new System.Drawing.Point(171, 22);
            this.lbTaInv.Name = "lbTaInv";
            this.lbTaInv.Size = new System.Drawing.Size(109, 39);
            this.lbTaInv.TabIndex = 7;
            this.lbTaInv.Text = "Editar";
            this.lbTaInv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 306);
            this.Controls.Add(this.lbTaInv);
            this.Controls.Add(this.CBClaProd);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tBCant);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbClaveProducto);
            this.Name = "AlertaInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertaInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClaveProducto;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox tBCant;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ComboBox CBClaProd;
        private System.Windows.Forms.Label lbTaInv;
    }
}