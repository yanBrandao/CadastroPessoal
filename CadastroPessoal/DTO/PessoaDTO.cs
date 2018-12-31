using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoal.DTO
{
    public static class PessoaDTO
    {

        public static void cadastrarPessoa(string nome, DateTime nascimento, string certificacao)
        {
            string sql = "INSERT INTO `PESSOA`(`PES_NOME`,`PES_DATA_CADASTRO`,`PES_NASCIMENTO`, `PES_CERT_COD`) " +
                "VALUES(\"" + nome + "\", \"" + DateTime.Now.ToString() + "\", \"" + nascimento.ToLongDateString() + "\", " +
                "(SELECT CERT_ID FROM CERTIFICACOES WHERE CERT_NOME =\"" + certificacao + "\"));";
            try
            {
                using (Database db = new Database())
                {
                    db.executarComandoSQL(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
