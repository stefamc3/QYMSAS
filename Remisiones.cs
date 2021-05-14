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
    public partial class Remisiones : Form
    {
        int iduss;
        public Remisiones(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            this.txtplaca.Text = "";
            this.txtdestinor.Text = "";
            this.txtmaterialr.Text = "";
            this.txtmetrosr.Text = "";
            this.txtremision.Text = "";
            this.txt_rvalor.Text = "";
        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                string Query = "INSERT INTO remisiones (fecha,placa,destino,material,metros,remision,precio,estado) values('" + fecha + "','" + this.txtplaca.Text + "','" + this.txtdestinor.Text + "','" + this.txtmaterialr.Text + "','" + this.txtmetrosr.Text + "','" + this.txtremision.Text + "','" + this.txt_rvalor.Text + "','" + this.textEstado.Text + "');";
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
            Menu_Recebera menR = new Menu_Recebera(iduss);
            menR.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from remisiones where 	id_remisiones = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void busRe_TextChanged(object sender, EventArgs e)
        {
            if (busRe.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `remisiones` WHERE `destino` LIKE '%" + busRe.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `remisiones` ");
        }

        private void Remisiones_Load(object sender, EventArgs e)
        {
          busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from remisiones;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID REMISIONES";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "PLACA";
            dg_consulta.Columns[3].HeaderText = "DESTINO";
            dg_consulta.Columns[4].HeaderText = "MATERIAL";
            dg_consulta.Columns[5].HeaderText = "METROS";
            dg_consulta.Columns[6].HeaderText = "REMISIONE";
            dg_consulta.Columns[7].HeaderText = "PRECIO";
            dg_consulta.Columns[8].HeaderText = "ESTADO";
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
    public partial class Remisiones : Form
    {
        int iduss;
        public Remisiones(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            this.txtplaca.Text = "";
            this.txtdestinor.Text = "";
            this.txtmaterialr.Text = "";
            this.txtmetrosr.Text = "";
            this.txtremision.Text = "";
            this.txt_rvalor.Text = "";
        }

        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                string Query = "INSERT INTO remisiones (fecha,placa,destino,material,metros,remision,precio,estado) values('" + fecha + "','" + this.txtplaca.Text + "','" + this.txtdestinor.Text + "','" + this.txtmaterialr.Text + "','" + this.txtmetrosr.Text + "','" + this.txtremision.Text + "','" + this.txt_rvalor.Text + "','" + this.textEstado.Text + "');";
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
            Menu_Recebera menR = new Menu_Recebera(iduss);
            menR.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from remisiones where 	id_remisiones = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void busRe_TextChanged(object sender, EventArgs e)
        {
            if (busRe.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `remisiones` WHERE `destino` LIKE '%" + busRe.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `remisiones` ");
        }

        private void Remisiones_Load(object sender, EventArgs e)
        {
          busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from remisiones;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID REMISIONES";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "PLACA";
            dg_consulta.Columns[3].HeaderText = "DESTINO";
            dg_consulta.Columns[4].HeaderText = "MATERIAL";
            dg_consulta.Columns[5].HeaderText = "METROS";
            dg_consulta.Columns[6].HeaderText = "REMISIONE";
            dg_consulta.Columns[7].HeaderText = "PRECIO";
            dg_consulta.Columns[8].HeaderText = "ESTADO";
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
