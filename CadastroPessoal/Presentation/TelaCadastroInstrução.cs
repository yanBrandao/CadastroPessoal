using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoal
{
    public partial class TelaCadastroInstrução : Form
    {
        public TelaCadastroInstrução()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `CERTIFICACOES`(`CERT_NOME`) " +
                "VALUES(\"" + tbNome.Text + "\");";
            try
            {
                using (Database db = new Database())
                {
                    db.executarComandoSQL(sql);
                }

                if (DialogResult.OK == MessageBox.Show("Grau de instrução cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }
    }
}
