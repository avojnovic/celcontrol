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

        public static void executes(OleDbConnection myConnection, StringBuilder sb)
        {
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(sb.ToString(), myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
        }

        public static void executes(OleDbConnection myConnection, string sb)
        {
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(sb, myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
        }

        public static OleDbDataAdapter getData(OleDbConnection myConnection, string selectCommand)
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectCommand, myConnection);
            OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
            return dataAdapter;
        }

    }
}
