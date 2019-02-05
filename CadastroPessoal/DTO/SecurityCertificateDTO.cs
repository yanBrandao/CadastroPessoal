using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.DTO
{
    public static class SecurityCertificateDTO
    {
        public static long registerSecurityCertificate(long supplierId, long certId, string date)
        {
            string sql = "INSERT INTO ROS_SECURITY_CERTIFICATE (SEC_SUP_ID, SEC_CET_ID, SEC_DATE)" +
                "VALUES(" + supplierId + "," + certId + ",\"" + date + "\");";
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
