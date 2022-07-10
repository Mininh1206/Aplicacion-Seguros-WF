using MySql.Data.Types;
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
    public partial class PolizasCliente : Form
    {
        BDMySQL bd;

        int cliente;

        public PolizasCliente()
        {
            InitializeComponent();
        }

        public PolizasCliente(BDMySQL bd, int cliente)
        {
            InitializeComponent();

            this.bd = bd;

            this.cliente = cliente;

            bd.cargarPolizasFromCliente(tablaPolizas, barraProgreso, cliente);
        }

        private void PolizasCliente_Activated(object sender, EventArgs e)
        {
            cargarTabla();

            if (tablaPolizas.Rows.Count>0)
                tablaPolizas.CurrentCell = tablaPolizas.Rows[0].Cells[0];

            if (tablaPolizas.SelectedRows.Count == 1)
                bd.cargarPagosFromPoliza(tablaPagos, barraProgreso, tablaPolizas.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void cargarTabla()
        {
            foreach (DataGridViewRow fila in tablaPolizas.Rows)
            {
                switch (fila.Cells[3].Value.ToString())
                {
                    case "Cobrada":
                        fila.DefaultCellStyle.BackColor = Color.Blue;
                        break;
                    case "A cuenta":
                        fila.DefaultCellStyle.BackColor = Color.Gray;
                        break;
                    case "Liquidada":
                        fila.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    case "Pre anulada":
                        fila.DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case "Anulada":
                        fila.DefaultCellStyle.BackColor = Color.Red;
                        break;

                }
            }
        }

        private void tablaPolizas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaPolizas.SelectedRows.Count == 1)
            {
                bd.cargarPagosFromPoliza(tablaPagos, barraProgreso, tablaPolizas.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioPolizas alta = new FormularioPolizas(bd, cliente);

            if (alta.ShowDialog() == DialogResult.OK)
            {
                bd.insertarPoliza(alta.tbNumPol.Text, alta.tbImporte.Text, new MySqlDateTime(alta.tbFecha.Value), alta.cbEstado.Text, alta.tbObservaciones.Text, int.Parse(alta.tbCodCli.Text));
                bd.cargarPolizasFromCliente(tablaPolizas, barraProgreso, cliente);
                cargarTabla();
            }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in tablaPolizas.SelectedRows)
            {
                bd.eliminarPoliza(fila.Cells[0].Value.ToString());
            }
            bd.cargarPolizasFromCliente(tablaPolizas, barraProgreso, cliente);
            cargarTabla();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPolizas.SelectedRows.Count == 1)
            {
                FormularioPolizas modificar = new FormularioPolizas(bd, tablaPolizas.SelectedRows[0].Cells[0].Value.ToString(), double.Parse(tablaPolizas.SelectedRows[0].Cells[1].Value.ToString()), new MySqlDateTime(tablaPolizas.SelectedRows[0].Cells[2].Value.ToString()), tablaPolizas.SelectedRows[0].Cells[3].Value.ToString(), tablaPolizas.SelectedRows[0].Cells[4].Value.ToString(), int.Parse(tablaPolizas.SelectedRows[0].Cells[5].Value.ToString()));

                if (modificar.ShowDialog() == DialogResult.OK)
                {
                    bd.actualizarPoliza(modificar.tbNumPol.Text, modificar.tbImporte.Text, new MySqlDateTime(modificar.tbFecha.Value), modificar.cbEstado.Text, modificar.tbObservaciones.Text, int.Parse(modificar.tbCodCli.Text));

                    bd.cargarPolizasFromCliente(tablaPolizas, barraProgreso, cliente);
                    cargarTabla();
                }
            }
        }

        private void añadirPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaPolizas.SelectedRows.Count == 1)
            {
                double importeRestante = bd.getImporteRestante(tablaPolizas.SelectedRows[0].Cells[0].Value.ToString(), double.Parse(tablaPolizas.SelectedRows[0].Cells[1].Value.ToString()));
               
                if (importeRestante!=0){
                    FormularioPagos fp = new FormularioPagos(bd, tablaPolizas.SelectedRows[0].Cells[0].Value.ToString(), importeRestante);

                    if (fp.ShowDialog() == DialogResult.OK)
                    {
                        bd.insertarPago(fp.tbPoliza.Text, fp.tbImporte.Text);

                        bd.cargarPagosFromPoliza(tablaPagos, barraProgreso, fp.tbPoliza.Text);
                    }
                }
            }
        }

        private void borrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in tablaPagos.SelectedRows)
            {
                bd.eliminarPago(fila.Cells[0].Value.ToString());
            }
            
            if (tablaPolizas.SelectedRows.Count == 1)
            {
                bd.cargarPagosFromPoliza(tablaPagos, barraProgreso, tablaPolizas.SelectedRows[0].Cells[0].Value.ToString());
            }
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
                cargarTabla();
            }
            else
            {
                foreach (DataGridViewRow temp in tablaPolizas.Rows)
                {
                    temp.Visible = true;
                }
                cargarTabla();
            }
        }
    }
}
