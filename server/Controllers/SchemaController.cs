using System;
using System.Text;
using System.Data;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DBGen
{
    [Route("api/[Controller]/[Action]")]
    public class SchemaController : Controller
    {
        [HttpPost]
        public string GetTables([FromBody]String connectStr)
        {
            if(String.IsNullOrEmpty(connectStr)) connectStr=@"Data Source=C:\Users\fpata\Documents\MyProjects\WIP_Projects\FPClinic\Data\MyClinic_Model.sqlite";
            IDBHelper dbhelper = DBFactory.GetDBInstance(connectStr, DBType.Sqlite);
            DataTable dtTables = dbhelper.GetTables();
         
            return DataTableToJSONString(dtTables);
        }

        [HttpPost]
        public string GetColumns(string connectStr, string tableName)
        {
            IDBHelper dbhelper = DBFactory.GetDBInstance(connectStr, DBType.Sqlite);
            DataTable dtColumns = dbhelper.GetColumns(tableName);
            return JsonConvert.SerializeObject(dtColumns);
        }

        [HttpPost]
        public string GetCode(string connectStr, string tableName, string codeType)
        {
            IDBHelper dbhelper = DBFactory.GetDBInstance(connectStr, DBType.Sqlite);
            DataTable dtColumns = dbhelper.GetColumns(tableName);
            ICodeHelper codeHelper = DBFactory.GetCodeHelper(codeType);
            String code = codeHelper.GetCode(tableName, dtColumns, false);
            return code;
        }

        
    private string DataTableToJSONString(DataTable table)   
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
        JSONString = JSONString.Replace(@"\","");
        return JSONString.ToString();  
    }   
    }
}