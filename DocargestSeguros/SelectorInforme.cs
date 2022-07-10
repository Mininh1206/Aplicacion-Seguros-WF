using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocargestSeguros
{
    public partial class SelectorInforme : Form
    {
        public SelectorInforme()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (cbDesde.SelectedIndex <= cbHasta.SelectedIndex && dtDesde.Value.Date.CompareTo(dtHasta.Value.Date) < 1)
            {
                if (rbEstado.Checked)
                {
                    InformePolizas ip = new InformePolizas(int.Parse(cbDesde.SelectedValue.ToString()), int.Parse(cbHasta.SelectedValue.ToString()), dtDesde.Value, dtHasta.Value, cbEstado.Text);

                    this.Hide();

                    ip.ShowDialog();

                    this.Close();
                }
                else if (rbTodos.Checked)
                {
                    InformePolizas ip = new InformePolizas(int.Parse(cbDesde.SelectedValue.ToString()), int.Parse(cbHasta.SelectedValue.ToString()), dtDesde.Value, dtHasta.Value);

                    this.Hide();

                    ip.ShowDialog();

                    this.Close();
                }

            }
        }

        private void SelectorInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetSeguros.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataSetSeguros.clientes);

        }

        private void SelectorInforme_Activated(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 0;
        }
    }
}
