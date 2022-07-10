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
    public partial class InformePolizas : Form
    {
        public InformePolizas()
        {
            InitializeComponent();
        }

        public InformePolizas(int cd, int ch, DateTime fd, DateTime fh)
        {
            InitializeComponent();

            this.polizasTableAdapter.FillSinEstado(this.dataSetSeguros.polizas, cd, ch, fd, fh);

            this.reportViewer1.RefreshReport();
        }

        public InformePolizas(int cd, int ch, DateTime fd, DateTime fh, string estado)
        {
            InitializeComponent();

            this.polizasTableAdapter.FillEstado(this.dataSetSeguros.polizas, cd, ch, fd, fh, estado);

            this.reportViewer1.RefreshReport();
        }

        private void InformePolizas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
