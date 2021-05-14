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
    public partial class Report : Form
    {
        int iduss;
        public Report(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void Report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
           TipoReporte men = new TipoReporte(iduss);
            men.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
