using System;
using System.Collections.Generic;
using System.Data;
using DBGen;
using DBGen.DBHelpers;
using Microsoft.AspNetCore.Mvc;

namespace DBGenInterface.Controllers
{
    [Produces("application/json")]
    [Route("[controller]/[action]")]
    public class SchemaController : Controller
    {
        // GET: api/Schema
        [HttpGet]
        public DataTable GetTables(string connectStr, DBType DbType)
        {
            IDBHelper iDBHelper = DBFactory.GetDBInstance(connectStr, DbType);
            DataTable sqlTables = iDBHelper.GetTables();
            return sqlTables;
        }

        // GET: api/Schema/5
        [HttpGet]
        public DataTable GetColumns(string connectStr, DBType DbType, string tableName)
        {
            IDBHelper iDBHelper = DBFactory.GetDBInstance(connectStr, DbType);
            DataTable sqlColumns = iDBHelper.GetColumns(tableName);
            return sqlColumns;
        }
        
        // POST: api/Schema
        [HttpGet]
        public String GetCode(string connectStr, DBType DbType,string tableName, string lang)
        {
            IDBHelper iDBHelper = DBFactory.GetDBInstance(connectStr, DbType);
            DataTable sqlColumns = iDBHelper.GetColumns(tableName);
            ICodeHelper codeHelper = DBFactory.GetCodeHelper(lang);
            String code = codeHelper.GetCode(tableName, sqlColumns, false);
            return code;
        }
        
       


    }
}
