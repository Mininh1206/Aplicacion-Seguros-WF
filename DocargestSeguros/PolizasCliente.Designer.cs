
namespace DocargestSeguros
{
    partial class PolizasCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaPolizas = new System.Windows.Forms.DataGridView();
            this.pbAcualizarPoliza = new System.Windows.Forms.PictureBox();
            this.tbBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.barraProgreso = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tablaPagos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcualizarPoliza)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.añadirPagoToolStripMenuItem,
            this.borrarPagoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.altaToolStripMenuItem.Text = "Añadir póliza";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.bajaToolStripMenuItem.Text = "Borrar póliza";
            this.bajaToolStripMenuItem.Click += new System.EventHandler(this.bajaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.modificarToolStripMenuItem.Text = "Modificar póliza";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // añadirPagoToolStripMenuItem
            // 
            this.añadirPagoToolStripMenuItem.Name = "añadirPagoToolStripMenuItem";
            this.añadirPagoToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.añadirPagoToolStripMenuItem.Text = "Añadir pago";
            this.añadirPagoToolStripMenuItem.Click += new System.EventHandler(this.añadirPagoToolStripMenuItem_Click);
            // 
            // borrarPagoToolStripMenuItem
            // 
            this.borrarPagoToolStripMenuItem.Name = "borrarPagoToolStripMenuItem";
            this.borrarPagoToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.borrarPagoToolStripMenuItem.Text = "Borrar pago";
            this.borrarPagoToolStripMenuItem.Click += new System.EventHandler(this.borrarPagoToolStripMenuItem_Click);
            // 
            // tablaPolizas
            // 
            this.tablaPolizas.AllowUserToAddRows = false;
            this.tablaPolizas.AllowUserToDeleteRows = false;
            this.tablaPolizas.AllowUserToResizeColumns = false;
            this.tablaPolizas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPolizas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPoliza,
            this.Importe,
            this.Fecha,
            this.Estado,
            this.Observaciones});
            this.tablaPolizas.Location = new System.Drawing.Point(12, 90);
            this.tablaPolizas.Name = "tablaPolizas";
            this.tablaPolizas.ReadOnly = true;
            this.tablaPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPolizas.Size = new System.Drawing.Size(473, 436);
            this.tablaPolizas.TabIndex = 32;
            this.tablaPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPolizas_CellClick);
            // 
            // pbAcualizarPoliza
            // 
            this.pbAcualizarPoliza.Image = global::DocargestSeguros.Properties.Resources.actualizar;
            this.pbAcualizarPoliza.Location = new System.Drawing.Point(25, 38);
            this.pbAcualizarPoliza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbAcualizarPoliza.Name = "pbAcualizarPoliza";
            this.pbAcualizarPoliza.Size = new System.Drawing.Size(19, 20);
            this.pbAcualizarPoliza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAcualizarPoliza.TabIndex = 31;
            this.pbAcualizarPoliza.TabStop = false;
            // 
            // tbBuscador
            // 
            this.tbBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscador.Location = new System.Drawing.Point(602, 31);
            this.tbBuscador.Name = "tbBuscador";
            this.tbBuscador.Size = new System.Drawing.Size(186, 22);
            this.tbBuscador.TabIndex = 30;
            this.tbBuscador.TextChanged += new System.EventHandler(this.tbBuscador_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Buscador";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraProgreso,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 28;
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
            // tablaPagos
            // 
            this.tablaPagos.AllowUserToAddRows = false;
            this.tablaPagos.AllowUserToDeleteRows = false;
            this.tablaPagos.AllowUserToResizeColumns = false;
            this.tablaPagos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ImportePago});
            this.tablaPagos.Location = new System.Drawing.Point(491, 90);
            this.tablaPagos.Name = "tablaPagos";
            this.tablaPagos.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tablaPagos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPagos.Size = new System.Drawing.Size(297, 436);
            this.tablaPagos.TabIndex = 33;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ImportePago
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.ImportePago.DefaultCellStyle = dataGridViewCellStyle3;
            this.ImportePago.HeaderText = "Importe";
            this.ImportePago.Name = "ImportePago";
            this.ImportePago.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pagos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Pólizas:";
            // 
            // NumPoliza
            // 
            this.NumPoliza.HeaderText = "Id";
            this.NumPoliza.Name = "NumPoliza";
            this.NumPoliza.ReadOnly = true;
            this.NumPoliza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Importe
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle1;
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            this.Importe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Fecha
            // 
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PolizasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaPagos);
            this.Controls.Add(this.tablaPolizas);
            this.Controls.Add(this.pbAcualizarPoliza);
            this.Controls.Add(this.tbBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PolizasCliente";
            this.Text = "PolizasCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.PolizasCliente_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcualizarPoliza)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPagos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.DataGridView tablaPolizas;
        private System.Windows.Forms.PictureBox pbAcualizarPoliza;
        private System.Windows.Forms.TextBox tbBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar barraProgreso;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView tablaPagos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem añadirPagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarPagoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPoliza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}