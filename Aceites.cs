using System;
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
    public partial class Aceites : Form
    {
        int iduss;
        public Aceites(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }
        basededatos bd = new basededatos();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu(iduss);
            men.Show();
        }

        private void solonumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpia();
        }

        private void limpia()
        {
            this.txt_valor.Text = "";
            this.txt_descripcionf.Text = "";
            this.Cbid_maquina.Text = "";
            this.dt_fecha.Text = DateTime.Now.ToString();
            Cbid_maquina.Focus();
        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;"; 
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;              
                String id_maquina = Convert.ToString(Cbid_maquina.SelectedItem);
                string Query = "INSERT INTO aceites_y_filtros (fecha,descripcion,valor,id_maquina) values('" + fecha + "','" + this.txt_descripcionf.Text + "','" + this.txt_valor.Text + "','" + id_maquina + "');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, basededatos.ObtenerConexion());
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Se guardado el registro", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                busqueda();
                limpia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Aceites_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from aceites_y_filtros;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID ACEITES";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "DESCRIPCIÓN";
            dg_consulta.Columns[3].HeaderText = "VALOR";
            dg_consulta.Columns[4].HeaderText = "ID MAQUINA";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //string modificar = "ubdate aceites set descripcion=" + txt_descripcionf.Text + "where maquina=" + Cb_tipo.Text;

            //   if (bd.executecommand(modificar))
            //   {
            //   }
            //   else
            //   {
            //   }     string mod = "ubdate aceites set descripcion =" + txt_descripcionf.Text + "";
            int modifica = basededatos.ModificaAceites(txt_descripcionf.Text, dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString());
            if(modifica > 0)
            {
                MessageBox.Show("Se ha modificado el registro", "Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                busqueda();
                limpia();
            }
            else
            {
                MessageBox.Show("No ha modificado el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from aceites_y_filtros where id_aceites = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
                limpia();
            }
        }

        private void busAce_TextChanged(object sender, EventArgs e)
        {
            if (busAce.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `aceites_y_filtros` WHERE `id_maquina` LIKE '%" + busAce.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `aceites_y_filtros` ");
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }
    }
}
