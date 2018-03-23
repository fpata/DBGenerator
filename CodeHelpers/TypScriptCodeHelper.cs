using System;
using System.Data;
using System.Globalization;
using System.Text;

namespace DBGen
{
    internal class TypScriptCodeHelper : ICodeHelper
    {
        public string GetCode(string tableName, DataTable dtColumns, bool requireEFMappings)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("export class " + tableName);
            sb.Append(" {");
            appendProperty(ref sb, dtColumns);
            sb.AppendLine("}");
            return sb.ToString();
        }

        private void appendProperty(ref StringBuilder sb, DataTable dtColumns)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            foreach (DataRow dr in dtColumns.Rows)
            {
                string dataType = getDataType(dr["type"].ToString());
                string colName = dr["name"].ToString();
                sb.AppendLine("\t" + textInfo.ToTitleCase(colName.ToLower())   + ": " + dataType + ";");
                sb.AppendLine();
            }
        }

        private string getDataType(string dataType)
        {
            string retType = String.Empty;
            dataType = dataType.ToLower();
            switch (dataType)
            {
                case "number":
                case "integer":
                    retType = "number";
                    break;
                case "text":
                case "varchar":
                case "varchar2":
                case "date":
                case "datetime":
                    retType = "string";
                    break;
                default:
                    retType = "string";
                    break;
            }
            return retType;
        }
    }
}