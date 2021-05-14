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
    public partial class TipoReporte : Form
    {
        int iduss;
        public TipoReporte(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            TipoR creus = new TipoR(iduss);
            creus.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Report creus = new Report(iduss);
            creus.Show();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Selección sel = new Selección(iduss);
            sel.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ReporteAcopio sel = new ReporteAcopio(iduss);
            sel.Show();
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
    public partial class TipoReporte : Form
    {
        int iduss;
        public TipoReporte(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            TipoR creus = new TipoR(iduss);
            creus.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Report creus = new Report(iduss);
            creus.Show();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Selección sel = new Selección(iduss);
            sel.Show();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ReporteAcopio sel = new ReporteAcopio(iduss);
            sel.Show();
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
