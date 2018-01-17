using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Everything4Rent.Common
{
    class DataBaseConnector
    {
        private static OleDbConnection connection;

        private static string ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Resources\DB.accdb";

        static DataBaseConnector()
        {
            connection = new OleDbConnection(ConnStr);
            connection.Open();

        }


        public static OleDbDataReader sql(string query)
        {
            OleDbCommand Cmd = new OleDbCommand(query, connection);
            OleDbDataReader ObjReader = Cmd.ExecuteReader();

            return ObjReader;
        }

    }
}
