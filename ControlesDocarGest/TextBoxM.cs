using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesDocarGest
{
    public partial class TextBoxM: UserControl
    {
        
        public Color ColorFondo
        {
            get
            {
                return textBox1.BackColor;
            }
            set
            {
                textBox1.BackColor = value;
            }
        }

        private Color colorPista = Color.Gray;
        public Color ColorPista
        {
            get
            {
                return colorPista;
            }
            set
            {
                colorPista = value;
                textBox1.ForeColor = colorPista;
            }
        }

        private Color colorTexto = Color.Black;
        public Color ColorTexto
        {
            get
            {
                return colorTexto;
            }
            set
            {
                colorTexto = value;
                textBox1.ForeColor = colorPista;
            }
        }

        public bool contraseña;
        public bool Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
                textBox1.UseSystemPasswordChar = contraseña;
                if (contraseña)
                {
                    textBox1.PasswordChar = '·';
                }
                else
                {
                    textBox1.PasswordChar = (char)0;
                }
            }
        }

        private string texto = "";
        public string Texto
        {
            get
            {
                return texto;
            }
            set
            {
                texto = value;
                if (texto.Equals(""))
                {
                    textBox1.Text = pista;
                    textBox1.ForeColor = colorPista;
                    textBox1.UseSystemPasswordChar = false;
                    textBox1.PasswordChar = (char)0;
                }
                else
                {
                    textBox1.Text = texto;
                    textBox1.ForeColor = colorTexto;
                    textBox1.UseSystemPasswordChar = contraseña;
                    if (contraseña)
                    {
                        textBox1.PasswordChar = '·';
                    }
                }
            }
        }

        private string pista = "";
        public string Pista
        {
            get
            {
                return pista;
            }
            set
            {
                pista = value;
                if (texto.Equals(""))
                {
                    textBox1.Text = pista;
                    textBox1.ForeColor = colorPista;
                    textBox1.UseSystemPasswordChar = false;
                    textBox1.PasswordChar = (char)0;
                }
            }
        }

        public TextBoxM()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = texto;
            textBox1.ForeColor = colorTexto;
            textBox1.UseSystemPasswordChar = contraseña;
            if (contraseña)
            {
                textBox1.PasswordChar = '·';
            }
            else
            {
                textBox1.PasswordChar = (char)0;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (texto.Equals(""))
            {
                textBox1.Text = pista;
                textBox1.ForeColor = colorPista;
                textBox1.UseSystemPasswordChar = false;
                textBox1.PasswordChar = (char)0;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            texto = textBox1.Text;
        }
    }
}
