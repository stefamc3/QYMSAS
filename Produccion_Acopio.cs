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
    public partial class Produccion_Acopio : Form
    {
        int iduss;
        public Produccion_Acopio(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void Produccio_Acopion_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from produccion_acopio;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID PRODUCCIÓN ACOPIO";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "QUINCENA";
            dg_consulta.Columns[3].HeaderText = "CLIENTE";
            dg_consulta.Columns[4].HeaderText = "TONELADA";
            dg_consulta.Columns[5].HeaderText = "PRECIO";
            dg_consulta.Columns[6].HeaderText = "TOTAL";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void busAce_TextChanged(object sender, EventArgs e)
        {
            if (busAce.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `produccion_acopio` WHERE `cliente` LIKE '%" + busAce.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `produccion_acopio` ");
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            this.textQuin.Text = "";
            this.textPre.Text = "";
            this.textTotal.Text = "";
            this.txt_cliente.Text = "";
            this.txt_ton.Text = "";

        }

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from produccion_acopio where id_produccion_acopio = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {

            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                string Query = "INSERT INTO produccion_acopio (fecha,quincena,cliente_A,toneladas_PA,precio_PA,total_PA) values('" + fecha + "','" + this.textQuin.Text + "','" + this.txt_cliente.Text + "','" + this.txt_ton.Text + "','" + this.textPre.Text + "','" + this.txt_ton.Text+"'); ";
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
            Menu_Acopio log = new Menu_Acopio(iduss);
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }
    }
}
