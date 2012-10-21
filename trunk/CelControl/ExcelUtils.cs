using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.SqlClient;


namespace CelControl
{
    public static class ExcelUtils
    {


        public static void ReadExcelFileOLDB(OleDbConnection myConnection, string fileName, string sheetName)
        {
            StringBuilder sb = new StringBuilder();
            string insert = " insert into liquidaciones (SIM,LINEA,MONTO,IMEI,FECHA) values ('{0}','{1}',{2},'{3}','{4}'); ";



            string TxtSim = "";
            string TxtLinea = "";
            double TxtMonto;
            string TxtIMEI = "";
            DateTime TxtFECHA;
            string insertquery = "";
            string excelConnectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0", fileName);

            using (OleDbConnection connection = new OleDbConnection(excelConnectionString))
            {
                OleDbCommand command = new OleDbCommand("Select * FROM [" + sheetName + "$]", connection);

                connection.Open();

              
                using (DbDataReader dr = command.ExecuteReader())
                {

                    while (dr.Read())
                    {

                      
                                TxtIMEI = dr.GetString(dr.GetOrdinal("IMEI"));

                                TxtLinea = dr.GetString(dr.GetOrdinal("LINEA"));
                            
                                TxtMonto =dr.GetDouble(dr.GetOrdinal("MONTO"));
                              
                                TxtFECHA = dr.GetDateTime(dr.GetOrdinal("FECHA"));

                                TxtSim = dr.GetString(dr.GetOrdinal("SIM"));


                                insertquery = string.Format(insert, TxtSim, TxtLinea, TxtMonto.ToString().Replace(",", "."), TxtIMEI, TxtFECHA.ToShortDateString());
                                DBUtils.insert(myConnection,insertquery.ToString());
                        }
                    }
                 
                }


     

            } 
        }

    
}
