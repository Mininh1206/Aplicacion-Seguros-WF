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
    public partial class Polizas : Form
    {
        BDMySQL bd;

        public Polizas()
        {
            InitializeComponent();
        }

        public Polizas(BDMySQL bd)
        {
            InitializeComponent();

            this.bd = bd;
        }

        private void tbBuscador_TextChanged(object sender, EventArgs e)
        {
            tablaPolizas.ClearSelection();
            if (tbBuscador.Text.Length >= 3)
            {
                foreach (DataGridViewRow temp in tablaPolizas.Rows)
                {
                    bool visible = false;
                    for (int c = 0; c < temp.Cells.Count; c++)
                    {
                        if (temp.Cells[c].Value.ToString().ToUpper().Contains(tbBuscador.Text.ToUpper()))
                        {
                            visible = true;
                        }
                    }
                    temp.Visible = visible;
                }
            }
        }

        private void pbAcualizarPoliza_Click(object sender, EventArgs e)
        {
            bd.cargarClientes(tablaPolizas, barraProgreso);
            tablaPolizas.ClearSelection();
        }
    }
}
