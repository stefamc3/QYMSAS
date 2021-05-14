using QYMSAS.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QYMSAS
{
        public class UserModel
        {
            UserDao userDao = new UserDao();
            public string recoverPassword(string userRequesting)
            {
                return userDao.recoverPassword(userRequesting);
            }
        }

}
