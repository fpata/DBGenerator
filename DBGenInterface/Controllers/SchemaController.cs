using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DBGen;
using DBGen.DBHelpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DBGenInterface.Controllers
{
    [Produces("application/json")]
    [Route("[controller]/[action]")]
    public class SchemaController : Controller
    {
        // GET: api/Schema
        [HttpPost]
        public string GetTables(string connectStr, DBType DbType)
        {
            IDBHelper iDBHelper = DBFactory.GetDBInstance(connectStr, DbType);
            DataTable sqlTables = iDBHelper.GetTables();
            return DataTableToJSON(sqlTables); 
        }

        // GET: api/Schema/5
        [HttpPost]
        public DataTable GetColumns(string connectStr, DBType DbType, string tableName)
        {
            IDBHelper iDBHelper = DBFactory.GetDBInstance(connectStr, DbType);
            DataTable sqlColumns = iDBHelper.GetColumns(tableName);
            return sqlColumns;
        }
        
        // POST: api/Schema
        [HttpPost]
        public String GetCode(string connectStr, DBType DbType,string tableName, string lang)
        {
            IDBHelper iDBHelper = DBFactory.GetDBInstance(connectStr, DbType);
            DataTable sqlColumns = iDBHelper.GetColumns(tableName);
            ICodeHelper codeHelper = DBFactory.GetCodeHelper(lang);
            String code = codeHelper.GetCode(tableName, sqlColumns, false);
            return code;
        }

        private string DataTableToJSON(DataTable table)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                JSONString.Append("[");
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
                JSONString.Append("]");
            }
            return JSONString.ToString();
        }
    }
}
