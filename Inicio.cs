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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 40;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            label2.Text = "Cargando el sistema al " + progressBar1.Value + " %";
            this.Opacity = this.Opacity + .03;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Login iniciosesion = new Login();
                iniciosesion.Show();
            }
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 40;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            label2.Text = "Cargando el sistema al " + progressBar1.Value + " %";
            this.Opacity = this.Opacity + .03;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Login iniciosesion = new Login();
                iniciosesion.Show();
            }
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
