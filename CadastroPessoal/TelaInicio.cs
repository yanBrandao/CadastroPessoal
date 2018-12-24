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
            string sql = "select * from PESSOA";
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
    }
}
