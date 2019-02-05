using CadastroPessoal.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using OfficeExcel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroPessoal.Utils;

namespace CadastroPessoal.Presentation
{
    public partial class TelaImportarExcel : Form
    {
        private long lastCompanyId;
        private long lastPersonId;
        private long lastSupplierId;
        public TelaImportarExcel()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                


                String name = "teste2";
                OpenFileDialog ofd = new OpenFileDialog();
                if (DialogResult.OK == ofd.ShowDialog())
                {
                    OfficeExcel.Application app = new OfficeExcel.Application();
                    OfficeExcel.Workbook book = app.Workbooks.Open( ofd.FileName);                    
                    DataTable data = new DataTable();
                    int index = 0;
                    object rowIndex = 2;
                    DataRow row;
                    data.Columns.Add("EMPRESA");
                    data.Columns.Add("NOME");
                    data.Columns.Add("RG / CTPS");
                    data.Columns.Add("Integração");
                    data.Columns.Add("ASO NR-10");
                    data.Columns.Add("ASO NR-10 STATUS");
                    data.Columns.Add("ASO NR-33 STATUS");
                    data.Columns.Add("ASO NR-35 STATUS");
                    data.Columns.Add("NR10");
                    data.Columns.Add("SEP");
                    data.Columns.Add("NR35");
                    data.Columns.Add("NR18 ANDAIMES");
                    data.Columns.Add("NR18 GENIE");
                    data.Columns.Add("CAMINHÃO MUNCK");
                    data.Columns.Add("NR 11 - EMPILHADEIRA");
                    data.Columns.Add("NR 11 - TALHA");
                    data.Columns.Add("SOLDA");
                    data.Columns.Add("NR-12");
                    data.Columns.Add("NR 20");
                    data.Columns.Add("NR 33");
                    foreach (OfficeExcel.Worksheet sheet in book.Sheets)
                    {
                        if(sheet.Name == name)
                        {
                            while (((OfficeExcel.Range)sheet.Cells[rowIndex, 1]).Value2 != null)
                            {
                                rowIndex = 2 + index;

                                row = data.NewRow();
                                for (int i = 0; i < 20; i++)
                                {
                                    DateTime date = new DateTime(1899, 12, 31);
                                    string cellValue = Convert.ToString(sheet.Cells[rowIndex, i + 1].Value2);
                                    if (!String.IsNullOrEmpty(cellValue))
                                    {
                                        row[i] = cellValue;
                                        if (IsDigit(cellValue) && i != 2)
                                        {
                                            int teste = Convert.ToInt32(cellValue);
                                            date = date.AddDays(teste - 1);
                                            row[i] = date.ToShortDateString();
                                        }
                                        else if (cellValue.Contains('/'))
                                        {
                                            string[] dateSplitted = cellValue.Split('/');
                                            if (dateSplitted.Length == 3)
                                            {
                                                if (MonthClass.GetAllMonth().Contains(dateSplitted[1].ToLower()))
                                                {
                                                    int monthNumber = MonthClass.GetAllMonth().IndexOf(dateSplitted[1].ToLower());
                                                    row[i] = (monthNumber + 1) + "/" + dateSplitted[0] + "/20" + dateSplitted[2];
                                                }
                                            }
                                        }
                                    }
                                    
                                }
                                index++;
                                data.Rows.Add(row);
                            }
                        }
                    }
                    dgImportar.DataSource = data;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                if (dgImportar.Rows.Count > 0)
                {
                    pbImport.Maximum = dgImportar.Rows.Count - 1;
                    pbImport.Minimum = 0;
                    foreach (DataGridViewRow linha in dgImportar.Rows)
                    {
                        lbContador.Text = "Importando pessoas: " + count + "/" + (dgImportar.Rows.Count-1);
                        pbImport.Value = count;
                        if (linha.Index == dgImportar.Rows.GetLastRow(DataGridViewElementStates.None))
                            break;
                        lastCompanyId = CompanyDTO.findCompany(linha.Cells[0].Value.ToString());
                        if (lastCompanyId == -1)
                        {
                             lastCompanyId = CompanyDTO.registerCompany(linha.Cells[0].Value.ToString());
                        }
                        lastPersonId = PersonDTO.registerPerson(linha.Cells[1].Value.ToString(), String.Empty, linha.Cells[2].Value.ToString());
                        lastSupplierId = SupplierDTO.registerSupplier(lastPersonId, lastCompanyId);
                        foreach(DataGridViewCell cell in linha.Cells)
                        {
                            if ("" != cell.Value.ToString() && cell.Value.ToString().Contains('/'))
                            {
                                long certTypeId = CertificateTypeDTO.findCertificate(dgImportar.Columns[cell.ColumnIndex].HeaderText);
                                SecurityCertificateDTO.registerSecurityCertificate(lastSupplierId, certTypeId, cell.Value.ToString());
                            }
                        }
                        count++;
                        Application.DoEvents();
                    }
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

        bool IsDigit(string str)
        {
            
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
