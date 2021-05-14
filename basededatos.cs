using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace QYMSAS
{
    class basededatos
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=mysql.freehostia.com; database=qymsas_bd; Uid=qymsas_bd; pwd=qym3103369882;");
            conectar.Open();
            return conectar;
        }

        public static String ConsultaStatusUsuario(String usuario, String contraseña)
        {
            String status = "0";
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("select estado, usuario, contraseña from usuarios where (usuario='{0}' and contraseña= md5('{1}') )", usuario, contraseña), basededatos.ObtenerConexion());
                MySqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    status = leer.GetString(0);
                }
            }
            catch
            {
                MessageBox.Show("Ingreso invalido, verifique el usuario y la contraseña");
                status = "0";
            }
            return status;
        }

        public static int ConsultaTipoUsuario(String usuario, String contraseña)
        {
            int tipo;
            MySqlCommand comando = new MySqlCommand(String.Format("select tipo, usuario, contraseña from usuarios where (usuario='{0}' and contraseña= md5('{1}') )", usuario, contraseña), basededatos.ObtenerConexion());
            Int32 Tipo = (Int32)comando.ExecuteScalar();
            tipo = Tipo;
            return tipo;
        }

        public static int ObtenerIDusuario(String usuario, String contraseña)
        {
            MySqlCommand comando = new MySqlCommand(String.Format("select id_us, usuario, contraseña from usuarios where (usuario='{0}' and contraseña= md5('{1}') )", usuario, contraseña), basededatos.ObtenerConexion());
            int Id = (int)comando.ExecuteScalar();
            return Id;
        }


        public static int RegistrarUsuario(String nombre, String apellido, String usuario, String contraseña, String email)
        {
            int registro;
            try
            {
                String estado = "Habilitado";
                MySqlCommand comando = new MySqlCommand(String.Format("insert into usuarios(nombre,apellido,usuario,contraseña,email,estado,tipo) values ('{0}','{1}','{2}',md5('{3}'),'{4}','{5}','1')", nombre, apellido, usuario, contraseña, estado), basededatos.ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ingreso invalido, verifique los datos");
                registro = 0;
            }
            return registro;
        }

        public static int Modificarcontraseña(String usuario, String contraseña)
        {
            int registro = 1;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("update usuarios set contraseña = md5('{0}') where usuario='{1}'", contraseña, usuario), ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
            }
            return registro;
        }

        public static int sumaporplaca(String fechainicial, String fechafinal)
        {
            int suma;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("select sum(precio) from remisiones where (fecha between '{0}' and '{1}')", fechainicial, fechafinal), basededatos.ObtenerConexion());
                MySqlDataReader _reader = comando.ExecuteReader();
                Int64 Suma = 0;
                while (_reader.Read())
                {
                    Suma = _reader.GetInt32(0);
                }
                suma = (Int32)Suma;
            }
            catch
            {
                suma = 0;
            }
            return suma;
        }
        public static DataTable ConsultaGeneral(string Q)
        {
            //MySqlConnection conectar = new MySqlConnection("server=localhost; database=qymsas; Uid=root; pwd=;");
            MySqlDataAdapter DA = new MySqlDataAdapter(Q, ObtenerConexion());
            DataTable TB = new DataTable();
            try
            {
                //conectar.Open();
                DA.Fill(TB);
                //conectar.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //conectar.Close();
            }
            return TB;


        }

        public static int ModificaAceites(String descripcion, String idaceites)
        {
            int registro = 1;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("update aceites_y_filtros set descripcion = '{0}' where id_aceites='{1}'", descripcion, idaceites), ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
            }
            return registro;
        }
        public static int ModificaCombustible(String valor, String idcombustible)
        {
            int registro = 1;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("update combustible set Valor_Total = '{0}' where id_combustible='{1}'", valor, idcombustible), ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
            }
            return registro;

        }
        public static int ModificaCuentasdeCobro(String descripcion, String idcuentas_de_cobro)
        {
            int registro = 1;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("update cuentas_de_cobro set Descripcion = '{0}' where id_cuentasC='{1}'", descripcion, idcuentas_de_cobro), ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
            }
            return registro;

        }
        public static int ModificaHoras(String horas, String maquina)
        {
            int registro = 1;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("update horas set Num_Horas = '{0}' where id_horas ='{1}'", horas, maquina), ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
            }
            return registro;

        }
        public static int ModificaMovimientos(String patio, String id_movimientos)
        {
            int registro = 1;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("update movimientos_foton2 set patio = '{0}' where id_movimientos ='{1}'", patio, id_movimientos), ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
            }
            return registro;

        }
        public static int ModificaContraseña(String contraseña, String id_us)
        {
            int registro = 1;
            try
            {
                MySqlCommand comando = new MySqlCommand(String.Format("update usuarios set contraseña = '{0}' where id_us ='{1}'", contraseña, id_us), ObtenerConexion());
                registro = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                registro = 0;
            }
            return registro;

        }
    }
}
    

