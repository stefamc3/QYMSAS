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
    public partial class ReciboDeCaja : Form
    {
        int iduss;
        public ReciboDeCaja(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }
        
        private void solonumeros(object sender, KeyPressEventArgs e)
        {

        }



        private void bt_nuevo_Click_1(object sender, EventArgs e)
        {
            this.txt_valor.Text = "";
            this.txt_descripcionc.Text = "";
            Cb_tipo.Focus();
        }

        private void Bt_Ingresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                String maquina = Convert.ToString(Cb_tipo.SelectedItem);
                string Query = "INSERT INTO recibo_de_caja (fecha,descripcion,valor, maquina) values('" + fecha + "','" + this.txt_descripcionc.Text + "','" + this.txt_valor.Text + "','" + maquina + "');";
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu(iduss);
            men.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReciboDeCaja_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from recibo_de_caja;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID RECIBO DE CAJA";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "DESCRIPCIÓN";
            dg_consulta.Columns[3].HeaderText = "VALOR";
            dg_consulta.Columns[4].HeaderText = "MAQUINA";
            dg_consulta.Columns[5].HeaderText = "ID MAQUINA";
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from recibo_de_caja where id_reciboC = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void busRc_TextChanged(object sender, EventArgs e)
        {
            if (busRc.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `recibo_de_caja` WHERE `maquina` LIKE '%" + busRc.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `recibo_de_caja` ");
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
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
    public partial class ReciboDeCaja : Form
    {
        int iduss;
        public ReciboDeCaja(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }
        
        private void solonumeros(object sender, KeyPressEventArgs e)
        {

        }



        private void bt_nuevo_Click_1(object sender, EventArgs e)
        {
            this.txt_valor.Text = "";
            this.txt_descripcionc.Text = "";
            Cb_tipo.Focus();
        }

        private void Bt_Ingresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                String maquina = Convert.ToString(Cb_tipo.SelectedItem);
                string Query = "INSERT INTO recibo_de_caja (fecha,descripcion,valor, maquina) values('" + fecha + "','" + this.txt_descripcionc.Text + "','" + this.txt_valor.Text + "','" + maquina + "');";
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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu(iduss);
            men.Show();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Login log = new Login();
            log.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReciboDeCaja_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from recibo_de_caja;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID RECIBO DE CAJA";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "DESCRIPCIÓN";
            dg_consulta.Columns[3].HeaderText = "VALOR";
            dg_consulta.Columns[4].HeaderText = "MAQUINA";
            dg_consulta.Columns[5].HeaderText = "ID MAQUINA";
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from recibo_de_caja where id_reciboC = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void busRc_TextChanged(object sender, EventArgs e)
        {
            if (busRc.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `recibo_de_caja` WHERE `maquina` LIKE '%" + busRc.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `recibo_de_caja` ");
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }
    }
}
    
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
