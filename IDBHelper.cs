using System;
using System.Data;

namespace DBGen
{
    internal abstract class IDBHelper
    {
        protected IDbConnection dbConnection;
        protected IDbCommand dbCommand;
        internal virtual bool TestConnection()
        {
            bool isSuccess = true;
            try
            {
                dbConnection.Open();
                dbConnection.Close();
            }
            catch(Exception ex)
            {
                isSuccess = false;
            }
            return isSuccess;
        }

        protected virtual DataTable ExecuteQuery(string query)
        {
            DataTable dtTables = new DataTable();
            try
            {
                dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandText = query;
                dbCommand.Connection.Open();
                IDataReader dbReader = dbCommand.ExecuteReader(CommandBehavior.CloseConnection);
                dtTables.Load(dbReader, LoadOption.OverwriteChanges);
               
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            return dtTables;
        }


        internal abstract DataTable GetTables();
        internal abstract DataTable GetTableNames();
        internal abstract DataTable GetColumns(string tableName);
        internal abstract DataTable GetData(string tableName);

    }
}