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
    public partial class FacturaC_Recebera : Form
    {
        int iduss;
        public FacturaC_Recebera(int idusuario)
        {
            InitializeComponent();
            iduss = idusuario;
        }
        private void GatosRecebera_Load(object sender, EventArgs e)
        {
            busqueda();
        }
        private void busqueda()
        {
            String busqueda = "select * from FacturaCompra;";
            MySqlCommand comando = new MySqlCommand(busqueda, basededatos.ObtenerConexion());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            MyAdapter.SelectCommand = comando;
            DataTable dTable = new DataTable();
            MyAdapter.Fill(dTable);
            dg_consulta.DataSource = dTable;
            dg_consulta.Columns[0].HeaderText = "ID FACTURACION";
            dg_consulta.Columns[1].HeaderText = "FECHA";
            dg_consulta.Columns[2].HeaderText = "No.FACTURA";
            dg_consulta.Columns[3].HeaderText = "SEÑORES";
            dg_consulta.Columns[4].HeaderText = "NIT";
            dg_consulta.Columns[5].HeaderText = "DIRECCION";
            dg_consulta.Columns[6].HeaderText = "TELEFONO";
            dg_consulta.Columns[7].HeaderText = "DESCRIPCION";
            dg_consulta.Columns[8].HeaderText = "CANTIDAD";
            dg_consulta.Columns[9].HeaderText = "VALOR UNITARIO";
            dg_consulta.Columns[10].HeaderText = "SUBTOTAL";
            dg_consulta.Columns[11].HeaderText = "IVA %";
            dg_consulta.Columns[12].HeaderText = "IVA";
            dg_consulta.Columns[13].HeaderText = "RETEFUENTE %";
            dg_consulta.Columns[14].HeaderText = "RETEFUENTE";
            dg_consulta.Columns[15].HeaderText = "NETO";
            dg_consulta.Columns[16].HeaderText = "ESTADO";
            dg_consulta.Columns[17].HeaderText = "TIPO";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Menu_Recebera log = new Menu_Recebera(iduss);
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            limpia();
         
        }
        private void limpia()
        {
            this.txtnumf.Text = "";
            this.txtdestino.Text = "";
            this.txtnit.Text = "";
            this.txtdireccion.Text = "";
            this.txttelefono.Text = "";
            this.txt_descripcionf.Text = "";
            this.txt_cantidad.Text = "";
            this.txtvaloru.Text = "";
            this.txtsubt.Text = "";
            this.txtivap.Text = "";
            this.txtiva.Text = "";           
            this.txtretef.Text = "";
            this.txtretefp.Text = "";
            this.txtneto.Text = "";
            Cbid_estadof.Focus();
            cbtipo.Focus();

        }
        private void Bt_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;";
                String fecha = "" + dt_fecha.Value.Year + "/" + dt_fecha.Value.Month + "/" + dt_fecha.Value.Day;
                String estado = Convert.ToString(Cbid_estadof.SelectedItem);
                String tipo = Convert.ToString(cbtipo.SelectedItem);
                string Query = "INSERT INTO FacturaCompra (fecha,N_fac,señores,nit,direccion,telefono,descripcion,cantidad,valor_unitario,subtotal,porcentaje_iva,iva,porcentaje_retf,retefuente,estado,tipo) values('" + fecha + "','" + this.txtnumf.Text + "','" + this.txtdestino.Text + "','" + this.txtnit.Text + "','" + this.txtdireccion.Text + "','" + this.txttelefono.Text + "','" + this.txt_descripcionf.Text + "','" + this.txt_cantidad.Text + "','" + this.txtvaloru.Text + "','" + this.txtsubt.Text + "','" + this.txtivap.Text + "','" + this.txtiva.Text + "','" + this.txtretefp.Text + "','" + this.txtretef.Text + "','" + this.txtneto.Text + "','" + estado + "','" + tipo + "');";
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

        private void bt_Eliminar_Click(object sender, EventArgs e)
        {
          String id = dg_consulta.Rows[dg_consulta.CurrentRow.Index].Cells[0].Value.ToString();
            if (MessageBox.Show("¿Realmente Desea Eliminar el registro '" + id + "' ?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string Borrar = "delete from FacturaCompra where id_FacturaC = '" + id + "';";
                MySqlCommand ComandBorrar = new MySqlCommand(Borrar, basededatos.ObtenerConexion());
                ComandBorrar.ExecuteReader();
                busqueda();
            }
        }
        private void busAce_TextChanged(object sender, EventArgs e)
        {
           if (busAce.Text != "")
          dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `FacturaCompra` WHERE `señores` LIKE '%" + busAce.Text + "%'");
            else
             dg_consulta.DataSource = basededatos.ConsultaGeneral("SELECT * FROM `FacturaCompra` ");
        }

        private void exportar_Click(object sender, EventArgs e)
        {
            exportExcel exc = new exportExcel();
            exc.exportaraexcel(dg_consulta);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtsubt.Text = Convert.ToString(Convert.ToDecimal(txt_cantidad.Text) * Convert.ToDecimal(txtvaloru.Text));
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtiva.Text = Convert.ToString(Convert.ToDecimal(txtsubt.Text) * Convert.ToDecimal(txtivap.Text));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtretef.Text = Convert.ToString(Convert.ToDecimal(txtsubt.Text) * Convert.ToDecimal(txtretefp.Text));
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            txtneto.Text = Convert.ToString(Convert.ToDecimal(txtsubt.Text) - Convert.ToDecimal(txtretefp.Text) + Convert.ToDecimal(txtiva.Text));
        }
    }
    }

