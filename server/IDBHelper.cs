using System;
using System.Data;

namespace DBGen
{
    public abstract class IDBHelper
    {
        protected IDbConnection dbConnection;
        protected IDbCommand dbCommand;
        public virtual bool TestConnection()
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

        protected virtual DataTable ExecuteQuery(string query, IDbDataAdapter dataAdapter)
        {
            DataSet ds = new DataSet();
            try
            {
                dbCommand = dbConnection.CreateCommand();
                dbCommand.CommandText = query;
                dbCommand.Connection = dbConnection;
                dataAdapter.SelectCommand = dbCommand;
                dataAdapter.Fill(ds);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
            }
            finally
            {
                if(dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
            }
            return ds.Tables[0];
        }


        public abstract DataTable GetTables();
        public abstract DataTable GetTableNames();
        public abstract DataTable GetColumns(string tableName);
        public abstract DataTable GetData(string tableName);

    }
}