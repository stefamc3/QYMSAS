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
    public partial class Horas : Form
    {
        int iduss;
        public Horas(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpia();
        }
        private void limpia()
        {
            this.txt_valorh.Text = "";
            this.textTotal.Text = "";
            this.txt_horas.Text = "";
            this.textM3.Text = "";
            this.txVm3.Text = "";
            this.text_Hinicial.Text = "";
            this.text_Hfinal.Text = "";
            Cbid_maquinaria.Focus();
        }
        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                String id_maquina = Convert.ToString(Cbid_maquinaria.SelectedItem);
                string Query = "INSERT INTO horas (fecha, horometro_inicial, horometro_final, num_horas,metros_cubicos, valor_hora,valor_m3, valor_total, id_maquina) values('" + fecha + "','"+this.text_Hinicial.Text+ "','" + this.text_Hfinal.Text + "','" + this.txt_horas.Text + "', '"+ this.textM3.Text + "', '" + this.txt_valorh.Text + "','" + this.txVm3.Text + "','"+ this.textTotal.Text + "','" + id_maquina + "');";
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
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu(iduss);
            men.Show();
        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Horas_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from horas;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID HORAS";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "HOROMETRO INICIAL";
            dg_consulta.Columns[3].HeaderText = "HOROMETRO FINAL";
            dg_consulta.Columns[4].HeaderText = "NUMERO DE HORAS";
            dg_consulta.Columns[5].HeaderText = "METROS CUBICOS";
            dg_consulta.Columns[6].HeaderText = "VALOR HORA";
            dg_consulta.Columns[7].HeaderText = "VALOR M3";
            dg_consulta.Columns[8].HeaderText = "VALOR TOTAL";
            dg_consulta.Columns[9].HeaderText = "ID MAQUINA";
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from horas where id_horas = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void busHor_TextChanged(object sender, EventArgs e)
        {
            if (busHor.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `horas` WHERE `id_maquina` LIKE '%" + busHor.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `horas` ");
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int modifica = basededatos.ModificaHoras(txt_horas.Text, dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString());
            if (modifica > 0)
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
    public partial class Horas : Form
    {
        int iduss;
        public Horas(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpia();
        }
        private void limpia()
        {
            this.txt_valorh.Text = "";
            this.textTotal.Text = "";
            this.txt_horas.Text = "";
            this.textM3.Text = "";
            this.txVm3.Text = "";
            this.text_Hinicial.Text = "";
            this.text_Hfinal.Text = "";
            Cbid_maquinaria.Focus();
        }
        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                String id_maquina = Convert.ToString(Cbid_maquinaria.SelectedItem);
                string Query = "INSERT INTO horas (fecha, horometro_inicial, horometro_final, num_horas,metros_cubicos, valor_hora,valor_m3, valor_total, id_maquina) values('" + fecha + "','"+this.text_Hinicial.Text+ "','" + this.text_Hfinal.Text + "','" + this.txt_horas.Text + "', '"+ this.textM3.Text + "', '" + this.txt_valorh.Text + "','" + this.txVm3.Text + "','"+ this.textTotal.Text + "','" + id_maquina + "');";
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
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu men = new Menu(iduss);
            men.Show();
        }

        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Horas_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from horas;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID HORAS";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "HOROMETRO INICIAL";
            dg_consulta.Columns[3].HeaderText = "HOROMETRO FINAL";
            dg_consulta.Columns[4].HeaderText = "NUMERO DE HORAS";
            dg_consulta.Columns[5].HeaderText = "METROS CUBICOS";
            dg_consulta.Columns[6].HeaderText = "VALOR HORA";
            dg_consulta.Columns[7].HeaderText = "VALOR M3";
            dg_consulta.Columns[8].HeaderText = "VALOR TOTAL";
            dg_consulta.Columns[9].HeaderText = "ID MAQUINA";
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from horas where id_horas = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }

        private void busHor_TextChanged(object sender, EventArgs e)
        {
            if (busHor.Text != "")
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `horas` WHERE `id_maquina` LIKE '%" + busHor.Text + "%'");
            else
                dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `horas` ");
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int modifica = basededatos.ModificaHoras(txt_horas.Text, dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString());
            if (modifica > 0)
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
    }
}
>>>>>>> c914ecc4e70bd20047b5792bb7b198ea09b47722
