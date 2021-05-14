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
    public partial class Viaticos : Form
    {
        int iduss;
        public Viaticos(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            this.txtalmuerzo.Text = "";
            this.txt_valord.Text = "";
            this.txtcombustible.Text = "";
            this.txtpeaje.Text = "";
            this.txtdes.Text = "";
            Cb_tipo.Focus();
            Cbid_maquina.Focus();
        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                String maquina = Convert.ToString(Cb_tipo.SelectedItem);
                String id_maquina = Convert.ToString(Cbid_maquina.SelectedItem);
                string Query = "INSERT INTO viaticos (fecha, almuerzo,combustible,peajes,otros_descripcion,otros_valor, maquina, id_maquina) values('" + fecha + "','" + this.txtalmuerzo.Text + "','" + this.txtcombustible.Text + "','" + this.txtpeaje.Text + "','" + this.txtdes.Text + "','" + this.txt_valord.Text + "','" + maquina + "','" + id_maquina + "');";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu(iduss);
            men.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from viaticos where id_viaticos = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void Viaticos_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from viaticos;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID VIATICOS";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "ALMUERZO";
            dg_consulta.Columns[3].HeaderText = "COMBUSTIBLE";
            dg_consulta.Columns[4].HeaderText = "PEAJES";
            dg_consulta.Columns[5].HeaderText = "OTROS DESCRIPCION";
            dg_consulta.Columns[6].HeaderText = "OTROS VALOR";
            dg_consulta.Columns[7].HeaderText = "MAQUINA";
            dg_consulta.Columns[8].HeaderText = "ID MAQUINA";
        }

        private void busVi_TextChanged(object sender, EventArgs e)
        {
            if (busVi.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `viaticos` WHERE `maquina` LIKE '%" + busVi.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `viaticos` ");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }
    }
}
