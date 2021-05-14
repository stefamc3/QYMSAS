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
    public partial class ReportesOperarios : Form
    {
        int iduss;
        public ReportesOperarios(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void ReportesOperarios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TipoR men = new TipoR(iduss);
            men.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
