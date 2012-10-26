using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace CelControl
{
    public static class ExcelUtils
    {
        public static String[] GetExcelSheetNames(string excelFile)
        {
            OleDbConnection objConn = null;
            System.Data.DataTable dt = null;

            try
            {
                // Connection String. Change the excel file to the file you
                // will search.
                string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", excelFile);

                // Create connection object by using the preceding connection string.
                objConn = new OleDbConnection(excelConnectionString);
                // Open connection with the database.
                objConn.Open();
                // Get the data table containg the schema guid.
                dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                if (dt == null)
                {
                    return null;
                }

                String[] excelSheets = new String[dt.Rows.Count];
                int i = 0;

                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row["TABLE_NAME"].ToString().Replace("$", "");
                    i++;
                }

                // Loop through all of the sheets if you want too...
                //for (int j = 0; j < excelSheets.Length; j++)
                //{
                    // Query each excel sheet.
                //}

                return excelSheets;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                // Clean up.
                if (objConn != null)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
                if (dt != null)
                {
                    dt.Dispose();
                }
            }
        }

        public static void ReadExcelFileOLDB(OleDbConnection myConnection, string fileName, string sheetName, EnumTipo tipo, bool borrar)
        {
            StringBuilder sb = new StringBuilder();
            string insertLiq = " insert into liquidaciones (SIM,LINEA,MONTO,IMEI,FECHA) values ('{0}','{1}',{2},'{3}','{4}'); ";
            string insertChip = " insert into Chips (CHIP,FECHA_ACTIVACION,LINEA) values ('{0}','{1}',{2}); ";

            if (borrar)
            {
                if (tipo == EnumTipo.liquidaciones)
                {
                    DBUtils.executes(myConnection, "delete from Liquidaciones");
                }
                else
                {
                    DBUtils.executes(myConnection, "delete from Chips");
                }

            }


            string txt1 = "";
            string txt2 = "";
            double txt3;
            string txt4 = "";
            DateTime txt5;
            string insertquery = "";
            string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", fileName);

            OleDbConnection connection = new OleDbConnection(excelConnectionString);

            OleDbCommand command = new OleDbCommand("Select * FROM [" + sheetName + "$]", connection);

            connection.Open();


            //try
            //{
                DbDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Application.DoEvents();

                    if (tipo == EnumTipo.liquidaciones)
                    {
                        txt1 = dr.GetString(dr.GetOrdinal("SIM"));
                        txt2 = dr.GetString(dr.GetOrdinal("LINEA"));
                        txt3 = dr.GetDouble(dr.GetOrdinal("MONTO"));
                        txt4 = dr.GetString(dr.GetOrdinal("IMEI"));
                        txt5 = dr.GetDateTime(dr.GetOrdinal("FECHA"));

                        insertquery = string.Format(insertLiq, txt1, txt2, txt3.ToString().Replace(",", "."), txt4, txt5.ToShortDateString());
                    }
                    else
                    {
                        txt1 = dr.GetString(dr.GetOrdinal("CHIP"));
                        txt5 = dr.GetDateTime(dr.GetOrdinal("FECHA_ACTIVACION"));
                        txt4 = dr.GetString(dr.GetOrdinal("LINEA"));

                        insertquery = string.Format(insertChip, txt1, txt5.ToShortDateString(), txt4);

                    }

                    DBUtils.executes(myConnection, insertquery.ToString());

                }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}

        }



    }


}
