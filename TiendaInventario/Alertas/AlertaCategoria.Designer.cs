namespace TiendaInventario.Alertas
{
    partial class AlertaCategoria
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
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.lbEditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lbDescripcion.Location = new System.Drawing.Point(64, 128);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(160, 25);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "DESCRIPCIÓN";
            // 
            // btActualizar
            // 
            this.btActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btActualizar.BackColor = System.Drawing.Color.LimeGreen;
            this.btActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.ForeColor = System.Drawing.Color.Black;
            this.btActualizar.Location = new System.Drawing.Point(182, 194);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(105, 33);
            this.btActualizar.TabIndex = 4;
            this.btActualizar.Text = "Agregra";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBDescripcion.Location = new System.Drawing.Point(257, 128);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(141, 20);
            this.TBDescripcion.TabIndex = 6;
            // 
            // lbEditar
            // 
            this.lbEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEditar.AutoSize = true;
            this.lbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditar.ForeColor = System.Drawing.Color.Navy;
            this.lbEditar.Location = new System.Drawing.Point(162, 9);
            this.lbEditar.Name = "lbEditar";
            this.lbEditar.Size = new System.Drawing.Size(139, 37);
            this.lbEditar.TabIndex = 7;
            this.lbEditar.Text = "EDITAR";
            // 
            // AlertaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 266);
            this.Controls.Add(this.lbEditar);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.btActualizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertaCategoria";
            this.Load += new System.EventHandler(this.AlertaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label lbEditar;
    }
}