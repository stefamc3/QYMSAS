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
using MySql.Data.MySqlClient;

namespace QYMSAS
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //  int contraseña = basededatos.Modificarcontraseña(txt_usuario.Text, "321");
            //  if (contraseña > 0)
            //  {
            //       MessageBox.Show("Se ha cambiado la contraseña", "Contraseña cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  }
            var user = new UserModel();
            var result = user.recoverPassword(txtUserRequest.Text);
            lblResultado.Text = result;
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
using MySql.Data.MySqlClient;

namespace QYMSAS
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //  int contraseña = basededatos.Modificarcontraseña(txt_usuario.Text, "321");
            //  if (contraseña > 0)
            //  {
            //       MessageBox.Show("Se ha cambiado la contraseña", "Contraseña cambiada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  }
            var user = new UserModel();
            var result = user.recoverPassword(txtUserRequest.Text);
            lblResultado.Text = result;
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
