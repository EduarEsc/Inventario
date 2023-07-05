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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permisos));
            this.lbPerm = new System.Windows.Forms.Label();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lbDesc = new System.Windows.Forms.Label();
            this.datagridPermisos = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtDescPer = new System.Windows.Forms.TextBox();
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
            this.lbPerm.Location = new System.Drawing.Point(173, 41);
            this.lbPerm.Name = "lbPerm";
            this.lbPerm.Size = new System.Drawing.Size(178, 37);
            this.lbPerm.TabIndex = 0;
            this.lbPerm.Text = " Permisos ";
            this.lbPerm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(388, 99);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(112, 40);
            this.btRegistrar.TabIndex = 7;
            this.btRegistrar.Text = "Agregar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(74, 122);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(66, 13);
            this.lbDesc.TabIndex = 5;
            this.lbDesc.Text = "Descripcion:";
            // 
            // datagridPermisos
            // 
            this.datagridPermisos.AllowUserToAddRows = false;
            this.datagridPermisos.AllowUserToDeleteRows = false;
            this.datagridPermisos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datagridPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR});
            this.datagridPermisos.Location = new System.Drawing.Point(86, 164);
            this.datagridPermisos.Name = "datagridPermisos";
            this.datagridPermisos.ReadOnly = true;
            this.datagridPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPermisos.Size = new System.Drawing.Size(378, 173);
            this.datagridPermisos.TabIndex = 8;
            this.datagridPermisos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPermisos_CellContentClick_1);
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // txtDescPer
            // 
            this.txtDescPer.Location = new System.Drawing.Point(161, 115);
            this.txtDescPer.Name = "txtDescPer";
            this.txtDescPer.Size = new System.Drawing.Size(138, 20);
            this.txtDescPer.TabIndex = 9;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 377);
            this.Controls.Add(this.txtDescPer);
            this.Controls.Add(this.datagridPermisos);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lbDesc);
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
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.DataGridView datagridPermisos;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.TextBox txtDescPer;
    }
}