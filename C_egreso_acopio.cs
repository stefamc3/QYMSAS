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
    public partial class C_egreso_acopio : Form
    {
        int iduss;
        public C_egreso_acopio(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }
        basededatos bd = new basededatos();

        private void C_egreso_acopio_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from egreso;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID FACTURACION";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "N° COMPEOBANTE";
            dg_consulta.Columns[3].HeaderText = "SEÑORES";
            dg_consulta.Columns[4].HeaderText = "TELEFONO";
            dg_consulta.Columns[5].HeaderText = "DIRECCION";
            dg_consulta.Columns[6].HeaderText = "CIUDAD";
            dg_consulta.Columns[7].HeaderText = "DESCRIPCION";
            dg_consulta.Columns[8].HeaderText = "TOTAL";
            dg_consulta.Columns[8].HeaderText = "TIPO";
        }
        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpia();
        }
        private void limpia()
        {
            this.txtNumF.Text = "";
            this.txt_señor.Text = "";
            this.txt_direccion.Text = "";
            this.txt_ciudad.Text = "";
            this.txt_telefono.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_valor.Text = "";
            cbtipo.Focus();
        }
        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                String tipo = Convert.ToString(cbtipo.SelectedItem);
                string Query = "INSERT INTO egreso (fecha,Num_comprobante,señores,telefono,direccion,ciudad,descripcion,valor,tipo) values('" + fecha + "','" + this.txtNumF.Text + "','" + this.txt_señor.Text + "','" + this.txt_direccion.Text + "','" + this.txt_ciudad.Text + "','" + this.txt_telefono.Text + "','" + this.txt_descripcion.Text + "','" + this.txt_valor.Text + "','" + tipo + "');";
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

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from egreso where id_comprobante = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }

        private void busCom_TextChanged(object sender, EventArgs e)
        {
            if (busCom.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `egreso` WHERE `señores` LIKE '%" + busCom.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `egreso` ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu_Acopio log = new Menu_Acopio(iduss);
            log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        
}
