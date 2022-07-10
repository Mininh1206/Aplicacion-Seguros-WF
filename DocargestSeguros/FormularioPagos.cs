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
    public partial class FormularioPagos : Form
    {

        BDMySQL bd;

        public FormularioPagos()
        {
            InitializeComponent();
        }

        public FormularioPagos(BDMySQL bd, string poliza, double importeRestante)
        {
            InitializeComponent();
            this.bd = bd;

            tbRestante.Text = importeRestante+"";
            tbPoliza.Text = poliza;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            error.Text = "";

            double importe;

            if (double.TryParse(tbImporte.Text, out importe))
            {
                if (importe <= double.Parse(tbRestante.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    error.Text = "Introduce un importe menor al restante";
                }
            }
            else
            {
                tbImporte.Text = "";
                error.Text = "Introduce un importe numérico";
            }
            
        }
    }
}
