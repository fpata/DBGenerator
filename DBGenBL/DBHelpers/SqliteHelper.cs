using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Data.Common;
using System.Threading.Tasks;

namespace DBGen.DBHelpers
{
    public class SqliteHelper:IDBHelper
    {
        private string connectionString;
      

        public SqliteHelper(string connectStr)
        {
            this.connectionString = connectStr;
            base.dbConnection = new SqliteConnection(this.connectionString);
           
        }


        public override DataTable GetTables()
        {
            DataTable dtTables = base.ExecuteQuery("SELECT Name FROM sqlite_master where type = 'table'");
            return dtTables;
        }


        public override DataTable GetTableNames()
        {
            DataTable dtTables = base.ExecuteQuery("SELECT Name FROM sqlite_master where type = 'table'");
            return dtTables;
        }

        public override DataTable GetColumns(string tableName)
        {
            DataTable dtTables = base.ExecuteQuery("PRAGMA table_info('"+tableName+"')");
            return dtTables;
        }

        public override DataTable GetData(string tableName)
        {
            DataTable dtTables = base.ExecuteQuery("Select * from " + tableName + " LIMIT 10");
            return dtTables;
        }

    }
}
