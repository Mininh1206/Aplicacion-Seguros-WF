
namespace DocargestSeguros
{
    partial class FormularioPagos
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
            this.tbPoliza = new System.Windows.Forms.TextBox();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.tbRestante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPoliza
            // 
            this.tbPoliza.Enabled = false;
            this.tbPoliza.Location = new System.Drawing.Point(189, 40);
            this.tbPoliza.Name = "tbPoliza";
            this.tbPoliza.Size = new System.Drawing.Size(100, 22);
            this.tbPoliza.TabIndex = 0;
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(365, 40);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(100, 22);
            this.tbImporte.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Importe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Poliza:";
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(391, 135);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 27);
            this.cancelar.TabIndex = 4;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(272, 135);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 27);
            this.aceptar.TabIndex = 5;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // tbRestante
            // 
            this.tbRestante.Enabled = false;
            this.tbRestante.Location = new System.Drawing.Point(30, 40);
            this.tbRestante.Name = "tbRestante";
            this.tbRestante.Size = new System.Drawing.Size(100, 22);
            this.tbRestante.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Importe restante:";
            // 
            // error
            // 
            this.error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(30, 140);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 21;
            this.error.Visible = false;
            // 
            // FormularioPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(507, 202);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRestante);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.tbPoliza);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        public System.Windows.Forms.TextBox tbPoliza;
        public System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.TextBox tbRestante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error;
    }
}