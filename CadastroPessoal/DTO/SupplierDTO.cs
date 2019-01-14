using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.DTO
{
    public static class SupplierDTO
    {
        public static long registerSupplier(long personId, long companyId)
        {
            string sql = "INSERT INTO `ROS_SUPPLIER`(`PER_NAME`,`SUP_PER_ID`, `SUP_COM_ID`) " +
                "VALUES(" + personId + "," + companyId +");";
            long id;
            try
            {
                using (Database db = new Database())
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
