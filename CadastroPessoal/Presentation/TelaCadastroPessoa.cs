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
            //string sql = "INSERT INTO `PESSOA`(`PES_NOME`,`PES_DATA_CADASTRO`,`PES_NASCIMENTO`, `PES_CERT_COD`) " +
            //    "VALUES(\"" + tbName.Text + "\", \"" + DateTime.Now.ToString() + "\", \"" + dtpNascimento.Text + "\", " +
            //    ");";
            //try
            //{
            //    PersonDTO.registerPerson(tbName.Text, dtpNascimento.Text, cbCertificacoes.SelectedItem.ToString());
            //    if (DialogResult.OK == MessageBox.Show("Pessoa cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information))
            //    {
            //        Close();
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void TelaCadastroPessoa_Load(object sender, EventArgs e)
        {
            string sql = "SELECT CET_DESCRIPTION FROM ROS_CERTIFICATE_TYPE";
            try
            {
                using (Database db = new Database())
                {
                    SQLiteDataReader reader = db.executeReader(sql);
                    while (reader.Read())
                    {
                        cbCertificates.Items.Add(reader.GetString(0));
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
