using CadastroPessoal.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoal.Presentation
{
    public partial class TelaImportarExcel : Form
    {
        public TelaImportarExcel()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                String name = "Pessoas";
                OpenFileDialog ofd = new OpenFileDialog();
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                    ofd.FileName +
                                    ";Extended Properties=Excel 12.0;";

                    OleDbConnection con = new OleDbConnection(constr);
                    OleDbCommand oconn = new OleDbCommand("SELECT * FROM [" + name + "$]", con);
                    con.Open();

                    OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    dgImportar.DataSource = data;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgImportar.Rows.Count > 0)
                {
                    foreach(DataGridViewRow linha in dgImportar.Rows)
                    {
                        if (linha.Index == dgImportar.Rows.GetLastRow(DataGridViewElementStates.None))
                            break;
                        PessoaDTO.cadastrarPessoa(linha.Cells[0].Value.ToString(), DateTime.Parse(linha.Cells[1].Value.ToString()), linha.Cells[2].Value.ToString());
                    }
                    Close();
                    MessageBox.Show("Planilha importada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new ArgumentException("Antes de salvar, importe um arquivo Excel.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
