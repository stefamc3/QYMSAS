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
    public partial class Maquinaria : Form
    {
        int iduss;
        public Maquinaria(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu log = new Menu(iduss);
            log.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Selección log = new Selección(iduss);
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Foton2 log = new Foton2(iduss);
            log.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            SZN114 log = new SZN114(iduss);
            log.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RETRO3 log = new RETRO3(iduss);
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maquinaria_Load(object sender, EventArgs e)
        {

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
    public partial class Maquinaria : Form
    {
        int iduss;
        public Maquinaria(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu log = new Menu(iduss);
            log.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Selección log = new Selección(iduss);
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Foton2 log = new Foton2(iduss);
            log.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Dispose();
            SZN114 log = new SZN114(iduss);
            log.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RETRO3 log = new RETRO3(iduss);
            log.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maquinaria_Load(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
