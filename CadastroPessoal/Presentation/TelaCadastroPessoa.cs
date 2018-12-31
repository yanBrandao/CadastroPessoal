using CadastroPessoal.DTO;
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
    public partial class TelaCadastroPessoa : Form
    {
        public TelaCadastroPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `PESSOA`(`PES_NOME`,`PES_DATA_CADASTRO`,`PES_NASCIMENTO`, `PES_CERT_COD`) " +
                "VALUES(\"" + tbNome.Text + "\", \"" + DateTime.Now.ToString() + "\", \"" + dtpNascimento.Text + "\", " +
                "(SELECT CERT_ID FROM CERTIFICACOES WHERE CERT_NOME =\"" + cbCertificacoes.SelectedItem + "\"));";
            try
            {
                PessoaDTO.cadastrarPessoa(tbNome.Text, DateTime.Parse(dtpNascimento.Text), cbCertificacoes.SelectedItem.ToString());
                if (DialogResult.OK == MessageBox.Show("Pessoa cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information))
                {
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaCadastroPessoa_Load(object sender, EventArgs e)
        {
            string sql = "SELECT CERT_NOME FROM CERTIFICACOES";
            try
            {
                using (Database db = new Database())
                {
                    SQLiteDataReader reader = db.executarReader(sql);
                    while (reader.Read())
                    {
                        cbCertificacoes.Items.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }
    }
}
