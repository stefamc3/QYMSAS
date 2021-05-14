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
    public partial class TipoR : Form
    {
        int iduss;
        public TipoR(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ReportesOperarios creus = new ReportesOperarios(iduss);
            creus.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TipoReporte sel = new TipoReporte(iduss);
            sel.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ReporteM sel = new ReporteM(iduss);
            sel.Show();
        }

        private void TipoR_Load(object sender, EventArgs e)
        {

        }
    }
}
