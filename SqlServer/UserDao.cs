using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace QYMSAS.SqlServer
{
        public class UserDao
        {
            public string recoverPassword(string userRequesting)
            {
                using (var connection = basededatos.ObtenerConexion())
                {
               // connection.Open();
                using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select *from usuarios where usuario=@user or email=@mail";
                        command.Parameters.AddWithValue("@user", userRequesting);
                        command.Parameters.AddWithValue("@mail", userRequesting);
                        command.CommandType = CommandType.Text;
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read() == true)
                        {
                            string userName = reader.GetString(1) + ", " + reader.GetString(2);
                            string userMail = reader.GetString(5);
                            string accountPassword = reader.GetString(4);
                            var mailService = new MailServices.SystemSupportMail();
                            mailService.sendMail(
                              subject: "SISTEMA: solicitud de recuperación de contraseña",
                              body: "Hola, " + userName + "\nSolicitó recuperar su contraseña.\n" +
                              "Su contraseña actual es: " + accountPassword +
                              "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.",
                              recipientMail: new List<string> { userMail }
                              );
                            return "Hola, " + userName + "\nSolicitó recuperar su contraseña.\n" +
                              "Por favor revise su correo: " + userMail +
                              "\nSin embargo, le pedimos que cambie su contraseña \ninmediatamente una vez que ingrese al sistema.";
                        }
                        else
                            return "Lo sentimos, no tienes una cuenta con ese correo o nombre de usuario.";
                    }
                }
            }

        }
    
}
