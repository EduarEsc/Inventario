
namespace TiendaInventario
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.CBPermiso = new System.Windows.Forms.ComboBox();
            this.lbPrec = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtAMaterno = new System.Windows.Forms.TextBox();
            this.lbCodi = new System.Windows.Forms.Label();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbProd = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.datagridUser = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(533, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBPermiso
            // 
            this.CBPermiso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBPermiso.FormattingEnabled = true;
            this.CBPermiso.Location = new System.Drawing.Point(247, 144);
            this.CBPermiso.Name = "CBPermiso";
            this.CBPermiso.Size = new System.Drawing.Size(129, 21);
            this.CBPermiso.TabIndex = 7;
            // 
            // lbPrec
            // 
            this.lbPrec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPrec.AutoSize = true;
            this.lbPrec.Location = new System.Drawing.Point(981, 152);
            this.lbPrec.Name = "lbPrec";
            this.lbPrec.Size = new System.Drawing.Size(64, 13);
            this.lbPrec.TabIndex = 17;
            this.lbPrec.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContraseña.Location = new System.Drawing.Point(1051, 146);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 16;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAMaterno.Location = new System.Drawing.Point(881, 146);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.ShortcutsEnabled = false;
            this.txtAMaterno.Size = new System.Drawing.Size(81, 20);
            this.txtAMaterno.TabIndex = 15;
            // 
            // lbCodi
            // 
            this.lbCodi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCodi.AutoSize = true;
            this.lbCodi.Location = new System.Drawing.Point(832, 149);
            this.lbCodi.Name = "lbCodi";
            this.lbCodi.Size = new System.Drawing.Size(55, 13);
            this.lbCodi.TabIndex = 14;
            this.lbCodi.Text = "Amaterno:";
            // 
            // txtApaterno
            // 
            this.txtApaterno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApaterno.Location = new System.Drawing.Point(692, 145);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.ShortcutsEnabled = false;
            this.txtApaterno.Size = new System.Drawing.Size(100, 20);
            this.txtApaterno.TabIndex = 13;
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(620, 149);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(53, 13);
            this.lbDesc.TabIndex = 12;
            this.lbDesc.Text = "Apaterno:";
            // 
            // lbProd
            // 
            this.lbProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbProd.AutoSize = true;
            this.lbProd.Location = new System.Drawing.Point(395, 152);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(47, 13);
            this.lbProd.TabIndex = 11;
            this.lbProd.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(464, 149);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // datagridUser
            // 
            this.datagridUser.AllowUserToAddRows = false;
            this.datagridUser.AllowUserToDeleteRows = false;
            this.datagridUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datagridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR});
            this.datagridUser.Location = new System.Drawing.Point(158, 203);
            this.datagridUser.Name = "datagridUser";
            this.datagridUser.ReadOnly = true;
            this.datagridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridUser.Size = new System.Drawing.Size(1130, 227);
            this.datagridUser.TabIndex = 18;
            this.datagridUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridUser_CellContentClick);
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = ((System.Drawing.Image)(resources.GetObject("EDITAR.Image")));
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Permiso:";
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarUser.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAgregarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUser.Location = new System.Drawing.Point(1189, 129);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(112, 40);
            this.btnAgregarUser.TabIndex = 20;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 553);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridUser);
            this.Controls.Add(this.lbPrec);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtAMaterno);
            this.Controls.Add(this.lbCodi);
            this.Controls.Add(this.txtApaterno);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.CBPermiso);
            this.Controls.Add(this.label1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.datagridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBPermiso;
        private System.Windows.Forms.Label lbPrec;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtAMaterno;
        private System.Windows.Forms.Label lbCodi;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbProd;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView datagridUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.Button btnAgregarUser;
    }
}