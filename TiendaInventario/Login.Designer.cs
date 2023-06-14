namespace TiendaInventario
{
    partial class Login
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
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.labelClave = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonIngreso.Location = new System.Drawing.Point(191, 214);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(135, 30);
            this.buttonIngreso.TabIndex = 0;
            this.buttonIngreso.Text = "Ingresar";
            this.buttonIngreso.UseVisualStyleBackColor = false;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // labelClave
            // 
            this.labelClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelClave.AutoSize = true;
            this.labelClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelClave.Location = new System.Drawing.Point(138, 89);
            this.labelClave.Name = "labelClave";
            this.labelClave.Size = new System.Drawing.Size(44, 13);
            this.labelClave.TabIndex = 1;
            this.labelClave.Text = "CLAVE:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(129, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // tbClave
            // 
            this.tbClave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbClave.Location = new System.Drawing.Point(258, 82);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(146, 20);
            this.tbClave.TabIndex = 3;
            // 
            // tbContra
            // 
            this.tbContra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbContra.Location = new System.Drawing.Point(258, 161);
            this.tbContra.MaxLength = 14;
            this.tbContra.Name = "tbContra";
            this.tbContra.PasswordChar = '*';
            this.tbContra.Size = new System.Drawing.Size(146, 20);
            this.tbContra.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 365);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClave);
            this.Controls.Add(this.buttonIngreso);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Label labelClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.TextBox tbContra;
    }
}