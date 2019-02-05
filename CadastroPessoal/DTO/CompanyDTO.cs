using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.DTO
{
    public static class CompanyDTO
    {

        public static long findCompany(string name)
        {
            string sql = "SELECT COM_ID FROM `ROS_COMPANY` WHERE COM_NAME=\"" + name + "\"";
            long retorno = -1;
            try
            {
                using (DatabaseROS db = new DatabaseROS())
                {
                    retorno = db.executeSelectScalarSQL(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public static long registerCompany(string name)
        {
            string sql = "INSERT INTO `ROS_COMPANY`(`COM_NAME`) " +
                "VALUES(\"" + name + "\");";
            long id;
            try
            {
                using (DatabaseROS db = new DatabaseROS())
                {
                    id = db.executeScalarSQL(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return id;
        }
    }
}
