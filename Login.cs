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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
 
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void inicio()
        {
            if (!string.IsNullOrEmpty(txt_usuario.Text))
            {
                if (!string.IsNullOrEmpty(txt_contraseña.Text))
                {
                    int tipo = basededatos.ConsultaTipoUsuario(txt_usuario.Text, txt_contraseña.Text);
                    int id = basededatos.ObtenerIDusuario(txt_usuario.Text, txt_contraseña.Text);
                    if (tipo == 1)
                    {
                        this.Hide();
                        Selección menua = new Selección(id);
                        menua.Show();
                    }
                    else if (tipo == 2)
                    {
                        this.Hide();
                        bascula menuu = new bascula(id);
                        menuu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Verifique los datos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una contraseña", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un usuario", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                inicio();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Contraseña recupera = new Contraseña();
            recupera.ShowDialog();
        }
    }
}
