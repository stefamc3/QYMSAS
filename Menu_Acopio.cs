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
    public partial class Menu_Acopio : Form
    {
        int iduss;
        public Menu_Acopio(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            FacturaC_Acopio creus = new FacturaC_Acopio(iduss);
            creus.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Nomina_Acopio creus = new Nomina_Acopio(iduss);
            creus.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Selección log = new Selección(iduss);
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Acopio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Produccion_Acopio men = new Produccion_Acopio(iduss);
            men.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Resumen_Acopio men = new Resumen_Acopio(iduss);
            men.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Facturacion_Acopio men = new Facturacion_Acopio(iduss);
            men.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            C_egreso_acopio log = new C_egreso_acopio(iduss);
            log.Show();
        }
    }
}
