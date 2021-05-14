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
    public partial class Menu_Recebera : Form
    {
        int iduss;
        public Menu_Recebera(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Selección sel = new Selección(iduss);
            sel.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Remisiones Rem = new Remisiones(iduss);
            Rem.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CrearUsuario creus = new CrearUsuario(iduss);
            creus.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FacturaC_Recebera log = new FacturaC_Recebera(iduss);
            log.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          this.Dispose();
          Nomina_Recebera log = new Nomina_Recebera(iduss);
          log.Show();
        }

        private void Menu_Recebera_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Facturas_recebera log = new Facturas_recebera(iduss);
            log.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            C_Egreso_Recebera log = new C_Egreso_Recebera(iduss);
            log.Show();
        }
    }
}
