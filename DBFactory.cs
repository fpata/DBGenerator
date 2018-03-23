using System;

namespace DBGen
{
    public class DBFactory
    {
        internal IDBHelper GetDBInstance(string connectStr, DBType dbType)
        {
            IDBHelper dbHelper = null;
           switch (dbType)
            {
                case DBType.Sqlite:
                    dbHelper = new DBGen.DBHelpers.SqliteHelper(connectStr);
                    break;
                case DBType.SqlServer:
                    dbHelper = new DBGen.DBHelpers.SQLServerHelper(connectStr);
                    break;
            }
            return dbHelper;

        }
    }
}