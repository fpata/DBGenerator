using System;

namespace DBGen
{
    public class DBFactory
    {
        public static IDBHelper GetDBInstance(string connectStr, DBType dbType)
        {
            IDBHelper dbHelper = null;
            switch (dbType)
            {
                case DBType.Sqlite:
                    dbHelper = new DBGen.DBHelpers.SQLiteHelper(connectStr);
                    break;
                case DBType.SqlServer:
                    dbHelper = new DBGen.DBHelpers.SQLServerHelper(connectStr);
                    break;
            }
            return dbHelper;

        }


        public static ICodeHelper GetCodeHelper(string code)
        {
            ICodeHelper codeHelper = null;
            switch (code)
            {
                case "CSharpEntity":
                    codeHelper = new CSharpEntityCodeHelper();
                    break;
                case "CSharpDAL":
                case "CSharpDBContext":
                    codeHelper = new CSharpDALCodeHelper();
                    break;
                case "TypeScript":
                    codeHelper = new TypScriptCodeHelper();
                    break;
            }
            return codeHelper;

        }
    }

    public enum DBType
    {
        Sqlite,
        Oracle,
        MySQL,
        SqlServer
    }
}