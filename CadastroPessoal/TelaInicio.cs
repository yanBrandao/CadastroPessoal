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
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void TelaInicio_Load(object sender, EventArgs e)
        {
            
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                Color c = e.Item.Selected ? Color.Azure : Color.FromArgb(232, 21, 37);
                using (SolidBrush brush = new SolidBrush(c))
                    e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbpAbasPrograma.Visible = false;
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbpAbasPrograma.Visible = true;
            CarregaDados();
        }

        private void CarregaDados()
        {
            DataTable dt = new DataTable();
            SQLiteConnection conn = null;
            string sql = "SELECT PES_NOME AS NOME, PES_NASCIMENTO AS DATA_NASCIMENTO, CERT.CERT_NOME AS GRAU_INSTRUÇÃO " +
                "FROM PESSOA PES" +
                " JOIN CERTIFICACOES CERT ON PES.PES_CERT_COD = CERT.CERT_ID";
            string strConn = @"Data Source=recofarma_db.db";
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
                string strConn = @"Data Source=recofarma_db.db";
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
    }
}
