using System;
using System.Text;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DBGen
{
    [Route("api/[Controller]/[Action]")]
    public class SchemaController : Controller
    {
        private string connectStr = String.Empty;
        private string tableName = String.Empty;
        private string codeType = String.Empty;
        private ORM orm = ORM.None;

        [HttpPost]
        public string GetTables([FromBody]JObject objectData)
        {
            SetObjectData(objectData);
            IDBHelper dbhelper = DBFactory.GetDBInstance(connectStr, DBType.Sqlite);
            DataTable dtTables = dbhelper.GetTables();
            return DataTableToJSONString(dtTables);
        }

        [HttpPost]
        public string GetColumns([FromBody]JObject objectData)
        {
            SetObjectData(objectData);
            IDBHelper dbhelper = DBFactory.GetDBInstance(connectStr, DBType.Sqlite);
            DataTable dtColumns = dbhelper.GetColumns(tableName);
            return DataTableToJSONString(dtColumns);
        }

        [HttpPost]
        public string GetCode([FromBody]JObject objectData)
        {
            String code = String.Empty;
            SetObjectData(objectData);
            IDBHelper dbhelper = DBFactory.GetDBInstance(connectStr, DBType.Sqlite);
            ICodeHelper codeHelper = DBFactory.GetCodeHelper(codeType);
            if (codeType.Equals("CSharpDBContext", StringComparison.InvariantCultureIgnoreCase))
            {
                var DALCodeHelper = (CSharpDALCodeHelper)codeHelper;
                DataTable dtTables = dbhelper.GetTables();
                code = DALCodeHelper.GetDBContextCode(dtTables);
            }
            else
            {
                DataTable dtColumns = dbhelper.GetColumns(tableName);
                code = codeHelper.GetCode(tableName, dtColumns, orm);
            }
            return code;
        }

        [HttpPost]
        public String CreateFiles([FromBody]JObject objectData)
        {
            SetObjectData(objectData);
            string fileExtn = codeType.StartsWith('C') ? ".cs" : ".ts";
            IDBHelper dbhelper = DBFactory.GetDBInstance(connectStr, DBType.Sqlite);
            ICodeHelper codeHelper = DBFactory.GetCodeHelper(codeType);
            DataTable dtTables = dbhelper.GetTables();
            FileHelper fileHelper = new FileHelper();
            String tableName = String.Empty;
            foreach (DataRow dr in dtTables.Rows)
            {
                tableName = dr["Name"].ToString();
                DataTable dtColumns = dbhelper.GetColumns(tableName);
                String code = codeHelper.GetCode(tableName, dtColumns, orm);
                fileHelper.WriteFile(tableName + fileExtn, code);
            }
            return "Process Complete";
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
            JSONString = JSONString.Replace(@"\", "");
            return JSONString.ToString();
        }

        private void SetObjectData(JObject objectData)
        {
            this.connectStr = (String)(objectData["connectStr"]);
            this.tableName = objectData["tableName"] == null ? String.Empty : (String)objectData["tableName"];
            this.codeType = objectData["codeType"] == null ? String.Empty : (String)objectData["codeType"];
            var ormval = objectData["ORM"] == null ? "None" : (String)objectData["ORM"];
            orm = Enum.Parse<ORM>(ormval, true);
        }
    }
}