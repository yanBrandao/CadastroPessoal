using CadastroPessoal.Presentation;
using CadastroPessoal.Shared;
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
    public partial class TelaInicio : Form
    {
        List<TabPage> tabs = new List<TabPage>();
        string perfil;
        public TelaInicio(string per)
        {
            InitializeComponent();
            perfil = per;
            foreach(TabPage tabPage in tbpAbasPrograma.TabPages)
            {
                tabs.Add(tabPage);
            }
        }

        private void TelaInicio_Load(object sender, EventArgs e)
        {
            menuStrip1.Renderer = new MyRenderer();
            cadastroToolStripMenuItem.BackColor = DesignTemplate.primaryColor;
            cadastroToolStripMenuItem.MouseEnter += DesignTemplate.onToolStripMouseEnter;
            cadastroToolStripMenuItem.MouseLeave += DesignTemplate.onToolStripMouseLeave;
            empresaToolStripMenuItem.MouseEnter += DesignTemplate.onToolStripMouseEnter;
            empresaToolStripMenuItem.MouseLeave += DesignTemplate.onToolStripMouseLeave;
            pessoaToolStripMenuItem.MouseEnter += DesignTemplate.onToolStripMouseEnter;
            pessoaToolStripMenuItem.MouseLeave += DesignTemplate.onToolStripMouseLeave;
            grauDeInstruçãoToolStripMenuItem.MouseEnter += DesignTemplate.onToolStripMouseEnter;
            grauDeInstruçãoToolStripMenuItem.MouseLeave += DesignTemplate.onToolStripMouseLeave;
            inícioToolStripMenuItem.MouseEnter += DesignTemplate.onToolStripMouseEnter;
            inícioToolStripMenuItem.MouseLeave += DesignTemplate.onToolStripMouseLeave;
            pbIcon.Location = new Point(((Screen.PrimaryScreen.Bounds.Width / 2) - (pbIcon.Width / 2)), pbIcon.Location.Y);
            if (perfil == "PADRÃO")
            {
                btnAdicionarPessoa.Visible = false;
                cadastroToolStripMenuItem.Visible = false;
            }
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.Azure : DesignTemplate.primaryColor;
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbpAbasPrograma.Visible = false;
        }

        private void CarregaDados()
        {
            DataTable dt = new DataTable();
            SQLiteConnection conn = null;
            string sql = "SELECT PES_NOME AS NOME, PES_NASCIMENTO AS DATA_NASCIMENTO, CERT.CERT_NOME AS GRAU_INSTRUÇÃO " +
                "FROM PESSOA PES" +
                " JOIN CERTIFICACOES CERT ON PES.PES_CERT_COD = CERT.CERT_ID";
            string strConn = @"Data Source=pessoal_db.db";
            try
            {
                conn = new SQLiteConnection(strConn);
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, strConn);
                da.Fill(dt);
                gridPessoas.DataSource = dt.DefaultView;
                
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

        private void btnAdicionarPessoa_Click(object sender, EventArgs e)
        {
            new TelaCadastroPessoa().Show();
        }

        private void TelaInicio_Activated(object sender, EventArgs e)
        {
            if (tbpAbasPrograma.Visible)
                CarregaDados();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Você tem certeza que deseja remover esta pessoa?", "Cuidado!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
            {
                string sql = "DELETE FROM PESSOA WHERE PES_NOME = \"" + gridPessoas.SelectedRows[0].Cells[0].Value + "\"";
                SQLiteConnection conn = null;
                string strConn = @"Data Source=pessoal_db.db";
                try
                {
                    conn = new SQLiteConnection(strConn);
                    conn.Open();
                    SQLiteCommand command = new SQLiteCommand(sql, conn);
                    command.ExecuteNonQuery();
                    CarregaDados();
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

        private void gridPessoas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                cmsMenuCelula.Show(Cursor.Position);
            }
        }

        private void gridPessoas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = gridPessoas.HitTest(e.X, e.Y);
                gridPessoas.ClearSelection();
                gridPessoas.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void grauDeInstruçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroInstrução().Show();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbpAbasPrograma.BringToFront();
            tbpAbasPrograma.Visible = true;
            tbpAbasPrograma.TabPages.Clear();
            tbpAbasPrograma.TabPages.Add(tabs[0]);
            CarregaDados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TelaImportarExcel().Show();
        }

        private void TelaInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TelaAtiva.formAnterior.Show();
        }

        private void pbSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inícioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            tbpAbasPrograma.Visible = false;
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            tbpAbasPrograma.BringToFront();
            tbpAbasPrograma.Visible = true;
            tbpAbasPrograma.TabPages.Clear();
            tbpAbasPrograma.TabPages.Add(tabs[1]);
        }

        private void lbEncontrarPessoas_Click(object sender, EventArgs e)
        {
            pbEdit_Click(sender, e);
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegisterCompanyForm().Show();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
