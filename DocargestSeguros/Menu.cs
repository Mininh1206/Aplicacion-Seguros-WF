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
    public partial class Menu : Form
    {
        BDMySQL bd;

        public Menu()
        {
            InitializeComponent();
        }

        public Menu(BDMySQL bd)
        {
            InitializeComponent();
            this.bd = bd;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes c = new Clientes(bd);
            Hide();
            c.ShowDialog();
            Show();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polizas p = new Polizas(bd);
            Hide();
            p.ShowDialog();
            Show();
        }
    }
}
