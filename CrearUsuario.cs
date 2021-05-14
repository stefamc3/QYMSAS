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
    public partial class CrearUsuario : Form
    {
        int iduss;
        public CrearUsuario(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Selección sel = new Selección(iduss);
            sel.Show();

        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                int status = basededatos.RegistrarUsuario(txt_nombre.Text, txt_apellido.Text, txt_usuario.Text, txt_contraseña.Text,txt_email.Text);
                if (status == 1)
                {
                    MessageBox.Show("Se ha ingresado el usuario correctamente");
                }
                else if (status == 0)
                {
                    MessageBox.Show("Error al ingresar el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique todos los campos Requeridos" + ex);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
