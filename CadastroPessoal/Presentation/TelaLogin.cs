using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptHash;
using System.Windows.Forms;
using System.Security.Cryptography;
using CadastroPessoal.Utils;
using CadastroPessoal.Presentation;
using System.Data.SQLite;

namespace CadastroPessoal
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senhaCodificada = CustomMD5.RetornarMD5(tbSenha.Text);
            try
            {
                bool senhaOK = false;
                string perfil = "";
                if (String.IsNullOrEmpty(tbLogin.Text))
                    throw new ArgumentException("Login não pode ser em branco.");
                else if (String.IsNullOrEmpty(tbSenha.Text))
                    throw new ArgumentException("Senha não pode ser em branco.");
                else
                {
                    string sql = "SELECT US_SENHA, PER_NOME FROM USUARIO US JOIN PERFIL PER ON US.US_PER_ID = PER.PER_ID " +
                        " WHERE US_LOGIN = \"" + tbLogin.Text + "\"";
                    using (Database db = new Database())
                    {
                        SQLiteDataReader reader = db.executarReader(sql);

                        while (reader.Read())
                        {
                            senhaOK = CustomMD5.ComparaMD5(tbSenha.Text, reader.GetString(0));
                            perfil = reader.GetString(1);
                        }
                    }
                    if (senhaOK)
                    {
                        Hide();
                        TelaAtiva.formAnterior = this;
                        tbLogin.Clear();
                        tbSenha.Clear();
                        new TelaInicio(perfil).Show();
                    }
                    else
                    {
                        throw new ArgumentException("Usuário ou senha, inválidos");
                    }

                }
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SQLiteException sql)
            {
                MessageBox.Show(sql.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void linkCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            TelaAtiva.formAnterior = this;
            new TelaCadastroUsuario().Show();
        }
    }
}
