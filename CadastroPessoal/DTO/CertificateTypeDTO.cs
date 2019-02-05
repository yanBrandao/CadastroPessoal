using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.DTO
{
    public static class CertificateTypeDTO
    {
        public static long findCertificate(string name)
        {
            string sql = "SELECT CET_ID, CET_DESCRIPTION FROM ROS_CERTIFICATE_TYPE WHERE CET_DESCRIPTION = \"" + name + "\"";
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

    }
}
