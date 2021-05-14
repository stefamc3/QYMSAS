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
    public partial class Alerta : Form
    {
        int iduss;
        public Alerta(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Selección men = new Selección(iduss);
            men.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
