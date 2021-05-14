<<<<<<< HEAD
﻿using System;
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
    public partial class Selección : Form
    {
        int iduss;
        public Selección(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CrearUsuario creus = new CrearUsuario(iduss);
            creus.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Maquinaria men = new Maquinaria(iduss);
            men.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu_Recebera menR = new Menu_Recebera(iduss);
            menR.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Selección_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            estadisticas creus = new estadisticas(iduss);
            creus.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TipoReporte creus = new TipoReporte(iduss);
            creus.Show();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Menu_Acopio creus = new Menu_Acopio(iduss);
            creus.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Trabajadores men = new Trabajadores(iduss);
            men.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AgregarMaquina men = new AgregarMaquina(iduss);
            men.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Alerta men = new Alerta(iduss);
            men.Show();
        }
    }
}
=======
﻿using System;
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
    public partial class Selección : Form
    {
        int iduss;
        public Selección(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CrearUsuario creus = new CrearUsuario(iduss);
            creus.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Maquinaria men = new Maquinaria(iduss);
            men.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu_Recebera menR = new Menu_Recebera(iduss);
            menR.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Selección_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            estadisticas creus = new estadisticas(iduss);
            creus.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TipoReporte creus = new TipoReporte(iduss);
            creus.Show();
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Menu_Acopio creus = new Menu_Acopio(iduss);
            creus.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Trabajadores men = new Trabajadores(iduss);
            men.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AgregarMaquina men = new AgregarMaquina(iduss);
            men.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Alerta men = new Alerta(iduss);
            men.Show();
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
