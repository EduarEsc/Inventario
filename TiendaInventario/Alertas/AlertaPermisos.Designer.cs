namespace TiendaInventario.Alertas
{
    partial class AlertaPermisos
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.btActualizar = new System.Windows.Forms.Button();
            this.txtPermisos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(132, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Editar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lbDescripcion.Location = new System.Drawing.Point(36, 125);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(160, 25);
            this.lbDescripcion.TabIndex = 9;
            this.lbDescripcion.Text = "DESCRIPCIÓN";
            // 
            // btActualizar
            // 
            this.btActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btActualizar.BackColor = System.Drawing.Color.Cyan;
            this.btActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActualizar.ForeColor = System.Drawing.Color.Black;
            this.btActualizar.Location = new System.Drawing.Point(139, 188);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(105, 33);
            this.btActualizar.TabIndex = 8;
            this.btActualizar.Text = "Aceptar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // txtPermisos
            // 
            this.txtPermisos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPermisos.Location = new System.Drawing.Point(202, 125);
            this.txtPermisos.Name = "txtPermisos";
            this.txtPermisos.Size = new System.Drawing.Size(126, 20);
            this.txtPermisos.TabIndex = 13;
            // 
            // AlertaPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 278);
            this.Controls.Add(this.txtPermisos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.btActualizar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertaPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlertaPermisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.TextBox txtPermisos;
    }
}