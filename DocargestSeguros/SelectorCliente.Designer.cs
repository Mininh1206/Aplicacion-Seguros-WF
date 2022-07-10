
namespace DocargestSeguros
{
    partial class SelectorCliente
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAcualizarCliente = new System.Windows.Forms.PictureBox();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.CodigoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poblacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aceptar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcualizarCliente)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Image = global::DocargestSeguros.Properties.Resources.agregar_usuario;
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.altaToolStripMenuItem.Text = "Alta";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Image = global::DocargestSeguros.Properties.Resources.eliminar_usuario;
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.bajaToolStripMenuItem.Text = "Baja";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::DocargestSeguros.Properties.Resources.modificar_usuario;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // pbAcualizarCliente
            // 
            this.pbAcualizarCliente.Image = global::DocargestSeguros.Properties.Resources.actualizar;
            this.pbAcualizarCliente.Location = new System.Drawing.Point(25, 45);
            this.pbAcualizarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbAcualizarCliente.Name = "pbAcualizarCliente";
            this.pbAcualizarCliente.Size = new System.Drawing.Size(19, 20);
            this.pbAcualizarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAcualizarCliente.TabIndex = 23;
            this.pbAcualizarCliente.TabStop = false;
            // 
            // tbBuscador
            // 
            this.tbBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscador.Location = new System.Drawing.Point(602, 42);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(186, 22);
            this.tbBuscador.TabIndex = 22;
            this.tbBuscador.TextChanged += new System.EventHandler(this.tbBuscador_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscador";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraProgreso,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // barraProgreso
            // 
            this.barraProgreso.Name = "barraProgreso";
            this.barraProgreso.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 20);
            this.toolStripStatusLabel1.Text = "DocarGest";
            // 
            // tablaClientes
            // 
            this.tablaClientes.AllowUserToAddRows = false;
            this.tablaClientes.AllowUserToDeleteRows = false;
            this.tablaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCli,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Provincia,
            this.Poblacion});
            this.tablaClientes.Location = new System.Drawing.Point(12, 72);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.ReadOnly = true;
            this.tablaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaClientes.Size = new System.Drawing.Size(776, 393);
            this.tablaClientes.TabIndex = 24;
            // 
            // CodigoCli
            // 
            this.CodigoCli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodigoCli.Frozen = true;
            this.CodigoCli.HeaderText = "Codigo";
            this.CodigoCli.Name = "CodigoCli";
            this.CodigoCli.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.Frozen = true;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 147;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            // 
            // Poblacion
            // 
            this.Poblacion.HeaderText = "Poblacion";
            this.Poblacion.Name = "Poblacion";
            this.Poblacion.ReadOnly = true;
            // 
            // aceptar
            // 
            this.aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptar.Location = new System.Drawing.Point(533, 483);
            this.aceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 28);
            this.aceptar.TabIndex = 27;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // cancelar
            // 
            this.cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(681, 483);
            this.cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 28);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // SelectorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.tablaClientes);
            this.Controls.Add(this.pbAcualizarCliente);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectorCliente";
            this.Text = "SelectorCliente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcualizarCliente)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbAcualizarCliente;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar barraProgreso;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView tablaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poblacion;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button cancelar;
    }
}