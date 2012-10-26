using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace CelControl
{
    public partial class MainForm : Form
    {

        OleDbDataAdapter dataAdapterLiq;
        OleDbDataAdapter dataAdapterChips;
        
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\CelControl.accdb;Persist Security Info=False;");
        //OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\CelControl.accdb;Persist Security Info=False;");
   
        public MainForm()
        {
            InitializeComponent();

        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewLiquidaciones.DataSource = celControlDataSetBindingSource;
            LoadDataGridView("select * from liquidaciones");

        }


        private void LoadDataGridView(string query)
        {
            dataAdapterLiq = DBUtils.getData(myConnection, query);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapterLiq.Fill(table);

            dataGridViewLiquidaciones.DataSource = table;
            dataGridViewLiquidaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            dataAdapterLiq.Update((DataTable)dataGridViewLiquidaciones.DataSource);

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView("select * from liquidaciones");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string query = @"select * from liquidaciones where IMEI like '%" + txtSearch.Text + "%' ";
            query += " or SIM like '%" + txtSearch.Text + "%' ";
            query += " or FECHA like '%" + txtSearch.Text + "%' ";
            query += " or LINEA like '%" + txtSearch.Text + "%' ";

            LoadDataGridView(query);
        }



        private void BtnImportar_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            BtnSave.Enabled = false;
            BtnSelectFileImport.Enabled = false;
            BtnImportar.Enabled = false;
            BtnRefresh.Enabled = false;



            if (txtFileImport.Text != "")
            {
                ExcelUtils.ReadExcelFileOLDB(myConnection, txtFileImport.Text, cmbSheets2.SelectedValue.ToString().Trim(), EnumTipo.liquidaciones, false);

                LoadDataGridView("select * from liquidaciones");
            }


            btnSearch.Enabled = true;
            BtnSave.Enabled = true;
            BtnSelectFileImport.Enabled = true;
            BtnImportar.Enabled = true;
            BtnRefresh.Enabled = true;

        }

        private void BtnSelectFileImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "*.xls|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileImport.Text = openFileDialog1.FileName;
                cmbSheets1.DataSource = ExcelUtils.GetExcelSheetNames(openFileDialog1.FileName);
            }
        }


        private void BtnSelectFileImport2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "*.xls|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileImport2.Text = openFileDialog1.FileName;

                cmbSheets2.DataSource = ExcelUtils.GetExcelSheetNames(openFileDialog1.FileName);

            }


        }

        private void BtnImportar2_Click(object sender, EventArgs e)
        {
            BtnImportar2.Enabled = false;
            BtnSelectFileImport2.Enabled = false;
            cmbSheets2.Enabled = false;
            BtnGenerarReporte.Enabled = false;

            if (txtFileImport2.Text != "")
            {
                ExcelUtils.ReadExcelFileOLDB(myConnection, txtFileImport2.Text, cmbSheets2.SelectedValue.ToString().Trim(), EnumTipo.chips, true);

             
            }
            BtnImportar2.Enabled = true;
            BtnSelectFileImport2.Enabled = true;
            cmbSheets2.Enabled = true;
            BtnGenerarReporte.Enabled = true;
        }



        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            BtnGenerarReporte.Enabled = false;

            dataAdapterChips = DBUtils.getData(myConnection, "select count(1) from chips");
            DataTable tableChips = new DataTable();
            tableChips.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapterChips.Fill(tableChips);


            progressBar1.Minimum = 1;
            progressBar1.Maximum = int.Parse(tableChips.Rows[0].ItemArray[0].ToString());
            progressBar1.Value = 1;
            progressBar1.Step = 1;

            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            GenerarReporte();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            progressBar1.PerformStep();
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            BtnGenerarReporte.Enabled = true;
            progressBar1.Visible = false;
        }


        private void GenerarReporte()
        {

            dataAdapterChips = DBUtils.getData(myConnection, "select * from chips");
            DataTable tableChips = new DataTable();
            tableChips.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapterChips.Fill(tableChips);


            int rows = tableChips.Rows.Count / 3;

            if (rows < 1)
                rows = 1;
            int columns = 5;


            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Microsoft.Office.Interop.Word._Application oWord;
            Microsoft.Office.Interop.Word._Document oDoc;
            oWord = new Microsoft.Office.Interop.Word.Application();
            oWord.Visible = false;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);



            Microsoft.Office.Interop.Word.Table oTable;
            Microsoft.Office.Interop.Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, rows, columns, ref oMissing, ref oMissing);
            oTable.Borders.Enable = 1;

            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            int i = 0;
            int r;
            int c;

            if (tableChips.Rows.Count < columns)
            {
                columns = tableChips.Rows.Count;
            }

            string strText;
            for (r = 1; r <= rows; r++)
                for (c = 1; c <= columns; c++)
                {
                    if (i + 1 <= tableChips.Rows.Count)
                    {
                        strText = "CHIP: " + tableChips.Rows[i].ItemArray[1].ToString() + "\nFECHA:" + tableChips.Rows[i].ItemArray[2].ToString() + "\nLINEA:" + tableChips.Rows[i].ItemArray[3].ToString();
                        //strText = "r" + r + "c" + c;
                        oTable.Cell(r, c).Range.Text = strText;
                        backgroundWorker1.ReportProgress(1);
                    }

                    i++;
                }

            oWord.Visible = true;
            //oTable.Rows[1].Range.Font.Bold = 1;
            //oTable.Rows[1].Range.Font.Italic = 1;
        }





    }
}
