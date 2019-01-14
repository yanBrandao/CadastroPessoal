using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.DTO
{
    public static class PersonDTO
    {

        public static long registerPerson(string name, string cpf, string rg_ctps)
        {
            string sql = "INSERT INTO `ROS_PERSON`(`PER_NAME`,`PER_CPF`, `PER_RG_CTPS`) " +
                "VALUES(\"" + name + "\", \"" + cpf + "\", \"" + rg_ctps + "\");";
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
