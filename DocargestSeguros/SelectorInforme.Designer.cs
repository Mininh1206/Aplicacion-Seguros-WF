
namespace DocargestSeguros
{
    partial class SelectorInforme
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
            this.components = new System.ComponentModel.Container();
            this.cbDesde = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSeguros = new DocargestSeguros.DataSetSeguros();
            this.cbHasta = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.clientesTableAdapter = new DocargestSeguros.DataSetSegurosTableAdapters.clientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeguros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDesde
            // 
            this.cbDesde.DataSource = this.clientesBindingSource;
            this.cbDesde.DisplayMember = "concat(Nombre, \' \', Apellidos)";
            this.cbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesde.FormattingEnabled = true;
            this.cbDesde.Location = new System.Drawing.Point(60, 68);
            this.cbDesde.Name = "cbDesde";
            this.cbDesde.Size = new System.Drawing.Size(200, 24);
            this.cbDesde.TabIndex = 0;
            this.cbDesde.ValueMember = "Codigo";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.dataSetSeguros;
            // 
            // dataSetSeguros
            // 
            this.dataSetSeguros.DataSetName = "DataSetSeguros";
            this.dataSetSeguros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbHasta
            // 
            this.cbHasta.DataSource = this.clientesBindingSource1;
            this.cbHasta.DisplayMember = "concat(Nombre, \' \', Apellidos)";
            this.cbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHasta.FormattingEnabled = true;
            this.cbHasta.Location = new System.Drawing.Point(318, 68);
            this.cbHasta.Name = "cbHasta";
            this.cbHasta.Size = new System.Drawing.Size(200, 24);
            this.cbHasta.TabIndex = 1;
            this.cbHasta.ValueMember = "Codigo";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.dataSetSeguros;
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(60, 155);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 22);
            this.dtDesde.TabIndex = 2;
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(318, 155);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 22);
            this.dtHasta.TabIndex = 3;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Checked = true;
            this.rbEstado.Location = new System.Drawing.Point(124, 233);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(58, 20);
            this.rbEstado.TabIndex = 4;
            this.rbEstado.TabStop = true;
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(124, 289);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(75, 20);
            this.rbTodos.TabIndex = 5;
            this.rbTodos.Text = "Sin estado";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Cobrada",
            "A cuenta",
            "Liquidada",
            "Pre anulada",
            "Anulada"});
            this.cbEstado.Location = new System.Drawing.Point(280, 233);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hasta cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hasta fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Desde fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Desde cliente:";
            // 
            // cancelar
            // 
            this.cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelar.Location = new System.Drawing.Point(443, 385);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 29);
            this.cancelar.TabIndex = 11;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(318, 385);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 29);
            this.aceptar.TabIndex = 12;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // SelectorInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(610, 448);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbEstado);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.cbHasta);
            this.Controls.Add(this.cbDesde);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectorInforme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectorInforme";
            this.Activated += new System.EventHandler(this.SelectorInforme_Activated);
            this.Load += new System.EventHandler(this.SelectorInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSeguros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDesde;
        private System.Windows.Forms.ComboBox cbHasta;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private DataSetSeguros dataSetSeguros;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSetSegurosTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
    }
}