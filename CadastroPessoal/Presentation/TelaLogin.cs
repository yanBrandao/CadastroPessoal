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
using CadastroPessoal.Shared;
using CadastroPessoal.DTO;

namespace CadastroPessoal
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            btnEntrar.MouseEnter += DesignTemplate.onButtonSaveMouseEnter;
            btnEntrar.MouseLeave += DesignTemplate.onButtonMouseLeave;
            BackColor = DesignTemplate.primaryColor;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senhaCodificada = CustomMD5.ReturnMD5(tbSenha.Text);
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
                    senhaOK = UserDTO.loginUser(tbLogin.Text, tbSenha.Text, out perfil);
                    if (senhaOK)
                    {
                        Hide();
                        Utils.ActiveForm.lastForm = this;
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
            Utils.ActiveForm.lastForm = this;
            new TelaCadastroUsuario().Show();
        }

        
    }
}
