namespace TiendaInventario
{
    partial class Permisos
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
            this.lbPerm = new System.Windows.Forms.Label();
            this.datagridPermisos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPerm
            // 
            this.lbPerm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPerm.AutoSize = true;
            this.lbPerm.BackColor = System.Drawing.Color.Transparent;
            this.lbPerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbPerm.Location = new System.Drawing.Point(231, 41);
            this.lbPerm.Name = "lbPerm";
            this.lbPerm.Size = new System.Drawing.Size(178, 37);
            this.lbPerm.TabIndex = 0;
            this.lbPerm.Text = " Permisos ";
            this.lbPerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagridPermisos
            // 
            this.datagridPermisos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datagridPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPermisos.Location = new System.Drawing.Point(99, 165);
            this.datagridPermisos.Name = "datagridPermisos";
            this.datagridPermisos.Size = new System.Drawing.Size(476, 188);
            this.datagridPermisos.TabIndex = 1;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 438);
            this.Controls.Add(this.datagridPermisos);
            this.Controls.Add(this.lbPerm);
            this.Name = "Permisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            ((System.ComponentModel.ISupportInitialize)(this.datagridPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPerm;
        private System.Windows.Forms.DataGridView datagridPermisos;
    }
}