using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QYMSAS
{
    public partial class ReporteAcopio : Form
    {
        int iduss;
        public ReporteAcopio(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void ReporteAcopio_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TipoReporte sel = new TipoReporte(iduss);
            sel.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
