namespace TiendaInventario
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            this.label1 = new System.Windows.Forms.Label();
            this.datagridCategoria = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbDesc = new System.Windows.Forms.Label();
            this.tBDesc = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(295, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categorias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datagridCategoria
            // 
            this.datagridCategoria.AllowUserToAddRows = false;
            this.datagridCategoria.AllowUserToDeleteRows = false;
            this.datagridCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datagridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ELIMINAR});
            this.datagridCategoria.Location = new System.Drawing.Point(155, 229);
            this.datagridCategoria.Name = "datagridCategoria";
            this.datagridCategoria.ReadOnly = true;
            this.datagridCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCategoria.Size = new System.Drawing.Size(494, 227);
            this.datagridCategoria.TabIndex = 1;
            this.datagridCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCategoria_CellContentClick);
            this.datagridCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridCategoria_CellDoubleClick);
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("ELIMINAR.Image")));
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(192, 178);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(66, 13);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Descripcion:";
            // 
            // tBDesc
            // 
            this.tBDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tBDesc.Location = new System.Drawing.Point(282, 175);
            this.tBDesc.Name = "tBDesc";
            this.tBDesc.ShortcutsEnabled = false;
            this.tBDesc.Size = new System.Drawing.Size(110, 20);
            this.tBDesc.TabIndex = 3;
            this.tBDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBDesc_KeyPress);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRegistrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(506, 155);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(112, 40);
            this.btRegistrar.TabIndex = 4;
            this.btRegistrar.Text = "Agregar";
            this.btRegistrar.UseVisualStyleBackColor = false;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 500);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.tBDesc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.datagridCategoria);
            this.Controls.Add(this.label1);
            this.Name = "Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridCategoria;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox tBDesc;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}