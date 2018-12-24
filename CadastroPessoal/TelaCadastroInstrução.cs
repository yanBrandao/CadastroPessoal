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
            SQLiteConnection conn = null;
            string sql = "INSERT INTO `CERTIFICACOES`(`CERT_NOME`) " +
                "VALUES(\"" + tbNome.Text + "\");";
            string strConn = @"Data Source=recofarma_db.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                if (DialogResult.OK == MessageBox.Show("Grau de instrução cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
