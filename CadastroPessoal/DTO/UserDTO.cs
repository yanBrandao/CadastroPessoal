using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.DTO
{
    public static class UserDTO
    {
        public static bool registerUser(string login, string password, string cpf)
        {
            bool result = false;
            string sql = "INSERT INTO `ROS_PERSON`(`PER_NAME`,`PER_CPF`, `PER_RG_CTPS`) " +
                "VALUES(\"" + login + "\", \"" + cpf + "\", NULL);";
            try
            {
                using (DatabaseROS db = new DatabaseROS())
                {
                    long personId = db.executeScalarSQL(sql);
                    if (personId == -1)
                    {
                        throw new ArgumentException("Problema ao cadastrar usuário com este CPF");
                    }
                    else
                    {
                        string userSql = "INSERT INTO `ROS_USER`(`USR_LOGIN`,`USR_PASSWORD`, `USR_PER_ID`, `USR_PRO_ID`) " +
                                         "VALUES(\"" + login + "\", \"" + password + "\", " + personId + ", \"1\");";
                        db.executeCommandSQL(userSql);
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public static bool loginUser(string login, string password, out string profile)
        {
            bool senhaOK = false;
            profile = "";
            string sql = "SELECT USR_PASSWORD, PRO_DESCRIPTION " +
                         "FROM ROS_USER US " +
                         "INNER JOIN ROS_PROFILE PRO ON USR_PRO_ID = PRO_ID " +
                         "WHERE USR_LOGIN =  \"" + login + "\"";
            using (DatabaseROS db = new DatabaseROS())
            {
                SQLiteDataReader reader = db.executeReader(sql);

                while (reader.Read())
                {
                    senhaOK = CustomMD5.CompareMD5(password, reader.GetString(0));
                    profile = reader.GetString(1);
                }
            }
            return senhaOK;
        }
    }
}
