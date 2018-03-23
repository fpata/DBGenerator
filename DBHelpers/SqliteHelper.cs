using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using System.Data.Common;
using System.Threading.Tasks;

namespace DBGen.DBHelpers
{
    internal class SqliteHelper:IDBHelper
    {
        private string connectionString;
      

        public SqliteHelper(string connectStr)
        {
            this.connectionString = connectStr;
            base.dbConnection = new SQLiteConnection(this.connectionString);
           
        }


        internal override DataTable GetTables()
        {
            DataTable dtTables = base.ExecuteQuery("SELECT Name FROM sqlite_master where type = 'table'");
            return dtTables;
        }


        internal override DataTable GetTableNames()
        {
            DataTable dtTables = base.ExecuteQuery("SELECT Name FROM sqlite_master where type = 'table'");
            return dtTables;
        }

        internal override DataTable GetColumns(string tableName)
        {
            DataTable dtTables = base.ExecuteQuery("PRAGMA table_info('"+tableName+"')");
            return dtTables;
        }

        internal override DataTable GetData(string tableName)
        {
            DataTable dtTables = base.ExecuteQuery("Select * from " + tableName + " LIMIT 10");
            return dtTables;
        }

    }
}
