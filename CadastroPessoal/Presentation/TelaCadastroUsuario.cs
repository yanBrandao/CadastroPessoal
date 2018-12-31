using CadastroPessoal.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoal.Presentation
{
    public partial class TelaCadastroUsuario : Form
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSenha.Text != tbConfSenha.Text)
                    throw new ArgumentException("As senhas não conferem.");
                else if (String.IsNullOrEmpty(tbSenha.Text) || String.IsNullOrEmpty(tbConfSenha.Text))
                    throw new ArgumentException("Senha não pode ser em branco.");
                else if (String.IsNullOrEmpty(tbUsuario.Text))
                    throw new ArgumentException("Nome de usuário não pode ser em branco.");
                else if (String.IsNullOrEmpty(tbCpf.Text))
                    throw new ArgumentException("CPF não pode ser em branco.");
                else
                {
                    salvarUsuario(tbUsuario.Text, tbSenha.Text, tbCpf.Text);
                    if(DialogResult.OK == MessageBox.Show("Usuário cadastrado com sucesso ao perfil \"Padrão\", contate um administrador pra mais informações", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information))
                    {
                        Close();
                        TelaAtiva.formAnterior.Show();
                    }
                }
            }catch(ArgumentException ae)
            {
                MessageBox.Show(ae.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void salvarUsuario(string usuario, string senha, string cpf)
        {
            string sql = "INSERT INTO USUARIO(US_LOGIN, US_SENHA, US_CPF, US_PER_ID) VALUES(\"" + usuario +"\" , \"" + CustomMD5.RetornarMD5(senha) + "\", \"" + cpf + "\" , 1)";
            using (Database db = new Database())
            {
                db.executarComandoSQL(sql);
            }
        }
        
    }
}
