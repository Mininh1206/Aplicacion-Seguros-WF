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
    public partial class Login : Form
    {

        BDMySQL bd;

        public Login()
        {
            InitializeComponent();

            bd = new BDMySQL();
        }

        private void tbUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bd.inicioValido(tbUsuario.Texto, tbContrasena.Texto))
                {
                    abrirMenu();
                }
            }
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            if (bd.inicioValido(tbUsuario.Texto, tbContrasena.Texto)) {
                abrirMenu();
            }
            
        }

        private void abrirMenu()
        {
            Menu m = new Menu(bd);
            Hide();
            m.ShowDialog();
            Close();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
