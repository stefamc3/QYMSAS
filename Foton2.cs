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
    public partial class Foton2 : Form
    {
        int iduss;
        public Foton2(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void Foton1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            movimientos log = new movimientos(iduss);
            log.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Resumen_Mes log = new Resumen_Mes(iduss);
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Resumen_Año log = new Resumen_Año(iduss);
            log.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Maquinaria log = new Maquinaria(iduss);
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    public partial class Foton2 : Form
    {
        int iduss;
        public Foton2(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void Foton1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            movimientos log = new movimientos(iduss);
            log.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Resumen_Mes log = new Resumen_Mes(iduss);
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Resumen_Año log = new Resumen_Año(iduss);
            log.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Maquinaria log = new Maquinaria(iduss);
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
