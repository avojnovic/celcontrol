using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CelControl
{
   public static class DBUtils
    {

       
       //OleDbConnection myConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\BD\\CelControl.accdb;Persist Security Info=False;");
       
       
       public static void insert(OleDbConnection myConnection, StringBuilder sb)
       {

         
           myConnection.Open();


           OleDbCommand command = new OleDbCommand(sb.ToString(), myConnection);
           command.ExecuteNonQuery();


           myConnection.Close();
       }

       public static void insert(OleDbConnection myConnection,string sb)
       {
               
           myConnection.Open();


           OleDbCommand command = new OleDbCommand(sb, myConnection);
           command.ExecuteNonQuery();




           myConnection.Close();
       }

       public static OleDbDataAdapter getData(OleDbConnection myConnection,string selectCommand)
       {
                   
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectCommand, myConnection);
         

               OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
  
             

               return dataAdapter;

           
       }



    }
}
