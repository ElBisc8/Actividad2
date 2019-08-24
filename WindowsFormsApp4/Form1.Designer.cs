namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblcontra = new System.Windows.Forms.Label();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(114, 307);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(120, 51);
            this.Btnlogin.TabIndex = 0;
            this.Btnlogin.Text = "&REGISTRARTE";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(506, 311);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(133, 47);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "&SALIR";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(99, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "Olympus Gym ID";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(149, 95);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(132, 33);
            this.lblusuario.TabIndex = 3;
            this.lblusuario.Text = "Usuario:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(287, 95);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(239, 40);
            this.txtusuario.TabIndex = 4;
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontra.Location = new System.Drawing.Point(97, 157);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(184, 33);
            this.lblcontra.TabIndex = 5;
            this.lblcontra.Text = "Contraseña:";
            // 
            // txtcontra
            // 
            this.txtcontra.Location = new System.Drawing.Point(287, 157);
            this.txtcontra.Multiline = true;
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.PasswordChar = '*';
            this.txtcontra.Size = new System.Drawing.Size(239, 42);
            this.txtcontra.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.Btnlogin);
            this.Name = "Form1";
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblcontra;
        private System.Windows.Forms.TextBox txtcontra;
    }
}

