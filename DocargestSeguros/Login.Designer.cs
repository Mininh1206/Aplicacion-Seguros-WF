namespace DocargestSeguros
{
    partial class Login
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
            this.salir = new System.Windows.Forms.Label();
            this.tbContrasena = new ControlesDocarGest.TextBoxM();
            this.tbUsuario = new ControlesDocarGest.TextBoxM();
            this.entrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.entrar)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.AutoSize = true;
            this.salir.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.White;
            this.salir.Location = new System.Drawing.Point(210, 18);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(17, 20);
            this.salir.TabIndex = 5;
            this.salir.Text = "X";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // tbContrasena
            // 
            this.tbContrasena.BackColor = System.Drawing.Color.Black;
            this.tbContrasena.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbContrasena.ColorPista = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbContrasena.ColorTexto = System.Drawing.Color.White;
            this.tbContrasena.Contraseña = true;
            this.tbContrasena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbContrasena.Location = new System.Drawing.Point(75, 201);
            this.tbContrasena.MaximumSize = new System.Drawing.Size(200, 19);
            this.tbContrasena.MinimumSize = new System.Drawing.Size(100, 19);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Pista = "Contraseña";
            this.tbContrasena.Size = new System.Drawing.Size(100, 19);
            this.tbContrasena.TabIndex = 3;
            this.tbContrasena.Texto = "";
            this.tbContrasena.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUsuario_KeyUp);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.Black;
            this.tbUsuario.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbUsuario.ColorPista = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.ColorTexto = System.Drawing.Color.White;
            this.tbUsuario.Contraseña = false;
            this.tbUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUsuario.Location = new System.Drawing.Point(75, 127);
            this.tbUsuario.MaximumSize = new System.Drawing.Size(200, 19);
            this.tbUsuario.MinimumSize = new System.Drawing.Size(100, 19);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Pista = "Usuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 19);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Texto = "";
            this.tbUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUsuario_KeyUp);
            // 
            // entrar
            // 
            this.entrar.Image = global::DocargestSeguros.Properties.Resources.enter;
            this.entrar.Location = new System.Drawing.Point(105, 295);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(40, 40);
            this.entrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.entrar.TabIndex = 4;
            this.entrar.TabStop = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(250, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.tbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.entrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesDocarGest.TextBoxM tbUsuario;
        private ControlesDocarGest.TextBoxM tbContrasena;
        private System.Windows.Forms.PictureBox entrar;
        private System.Windows.Forms.Label salir;
    }
}

