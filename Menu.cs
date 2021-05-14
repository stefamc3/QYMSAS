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
    public partial class Menu : Form
    {
        int iduss;
        public Menu(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Aceites aceite = new Aceites(iduss);
            aceite.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Combustible combus = new Combustible(iduss);
            combus.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CuentasCobro cuenta = new CuentasCobro(iduss);
            cuenta.Show();
        }
       
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            ReciboDeCaja recibo = new ReciboDeCaja(iduss);
            recibo.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Horas hora = new Horas(iduss);
            hora.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Maquinaria sel = new Maquinaria(iduss);
            sel.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Facturacion fac = new Facturacion(iduss);
            fac.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Viaticos via = new Viaticos(iduss);
            via.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
                Application.Exit();
            
        }
    }
}
