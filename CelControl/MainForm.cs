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

        OleDbDataAdapter dataAdapter;
        OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\CelControl.accdb;Persist Security Info=False;");

        public MainForm()
        {
            InitializeComponent();
         
        }



        private void BtnImportar_Click(object sender, EventArgs e)
        {
            if(txtFileImport.Text!="")
            {
                ExcelUtils.ReadExcelFileOLDB(myConnection,txtFileImport.Text, txtSheet.Text.Trim());

                GetData();
            }
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
                try
                {
                    txtFileImport.Text = openFileDialog1.FileName;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridViewLiquidaciones.DataSource = celControlDataSetBindingSource;
            GetData();

        }

        private void GetData()
        {
            dataAdapter = DBUtils.getData(myConnection, "select * from liquidaciones");

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);

            dataGridViewLiquidaciones.DataSource = table; 
            dataGridViewLiquidaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void GetData(string filter)
        {

            string query = @"select * from liquidaciones where IMEI like '%" + filter + "%' ";
            query += " or SIM like '%" + filter + "%' ";
            query += " or FECHA like '%" + filter + "%' ";
            query += " or LINEA like '%" + filter + "%' ";
          
           


            dataAdapter = DBUtils.getData(myConnection,query);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);

            dataGridViewLiquidaciones.DataSource = table;
            dataGridViewLiquidaciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            dataAdapter.Update((DataTable)dataGridViewLiquidaciones.DataSource);
            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetData(txtSearch.Text);
        }





    }
}
