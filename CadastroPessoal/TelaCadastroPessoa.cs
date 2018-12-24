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
    public partial class TelaCadastroPessoa : Form
    {
        public TelaCadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = null;
            string sql = "INSERT INTO `PESSOA`(`PES_NOME`,`PES_DATA_CADASTRO`,`PES_NASCIMENTO`) " +
                "VALUES(\"" + tbNome.Text + "\", \"" + DateTime.Now.ToString() + "\", \"" + dtpNascimento.Text + "\");";
            string strConn = @"Data Source=D:\Desktop\recofarma_db.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                conn.Open();
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
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
