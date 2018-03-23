using System;
using System.Data;
using System.Globalization;
using System.Text;

namespace DBGen
{
    internal class CSharpCodeHelper:ICodeHelper
    {
        public CSharpCodeHelper()
        {
        }

        public string GetCode(string tableName, DataTable dtColumns,bool requireEFMappings)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using System;");
            sb.AppendLine("namespace CodeGen");
            sb.AppendLine("{");
            if (requireEFMappings)
                sb.AppendLine("\t[Table(\"" + tableName + "\")]");
            sb.AppendLine("\tinternal class " + tableName);
            sb.AppendLine("\t{");
            appendProperty(ref sb, dtColumns, requireEFMappings);
            sb.AppendLine("\t}");
            sb.AppendLine("}");
            return sb.ToString();
        }

        private void appendProperty(ref StringBuilder sb, DataTable dtColumns, bool requireEFMappings)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            foreach (DataRow dr in dtColumns.Rows)
            {
                string dataType = getDataType(dr["type"].ToString());
                string colName = dr["name"].ToString();
                if (requireEFMappings)
                    sb.AppendLine("\t\t[Column(\"" + colName + "\")]");
                sb.AppendLine("\t\tpublic " + dataType + " " + textInfo.ToTitleCase(colName.ToLower()) + "{ get; set; }");
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
                    retType = "decimal";
                    break;
                case "integer":
                case "int identity":
                    retType = "int";
                    break;
                case "text":
                case "varchar":
                case "varchar2":
                case "nvarchar":
                    retType = "String";
                    break;
                case "date":
                case "datetime":
                    retType = "DateTime";
                    break;
                default:
                    retType = "String";
                    break;
            }
            return retType;
        }
    }
}