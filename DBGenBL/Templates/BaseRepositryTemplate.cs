using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGen.Templates
{
    public class BaseRepositryTemplate
    {

        public static string GetRepositry(string tableName)
        {
            string lowerCaseTableName = Char.ToLowerInvariant(tableName[0]) + tableName.Substring(1);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using Dapper;");
sb.AppendLine("using Server.Models;");
            sb.AppendLine("using System;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendLine("namespace Server.DAL");
            sb.AppendLine("{");
            sb.AppendLine("    public class "+ tableName +"Repositry : SqLiteBaseRepository<"+ tableName +">");
            sb.AppendLine("    {");
            sb.AppendLine("        public " + tableName + "Repositry(String _DbFileName)");
            sb.AppendLine("        {");
            sb.AppendLine("            base.DbFileName = _DbFileName;");
            sb.AppendLine("        }");
            sb.AppendLine();
sb.AppendLine("        public "+ tableName + " Get" + tableName + "ById(int Id)");
            sb.AppendLine("        {");
            sb.AppendLine(tableName + " " + lowerCaseTableName  +" = null;");
            sb.AppendLine(lowerCaseTableName + " = base.GetById(Id);"); 
sb.AppendLine("            return "+lowerCaseTableName+";");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine();

            sb.AppendLine("        public List<"+tableName+"> Get"+tableName+"s()");
sb.AppendLine("        {");
            sb.AppendLine("            List<"+tableName+"> "+ lowerCaseTableName + "s = null;");
            sb.AppendLine("            "+ lowerCaseTableName + "s = base.GetAll().AsList();");
            sb.AppendLine("            return "+ lowerCaseTableName + "s;");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine();
sb.AppendLine("        public bool Save"+ tableName + "(ref "+ tableName + " "+ lowerCaseTableName + ")");
            sb.AppendLine("        {");
            sb.AppendLine("            bool success = false;");
            sb.AppendLine("            if ("+ lowerCaseTableName + ".Id <= 0)");
            sb.AppendLine("            {");
            sb.AppendLine("                "+ lowerCaseTableName + ".Id = base.Insert("+ lowerCaseTableName + ");");
            sb.AppendLine("                if ("+ lowerCaseTableName + ".Id > 0) success = true;");
            sb.AppendLine("            }");
            sb.AppendLine("            else");
            sb.AppendLine("            {");
            sb.AppendLine("                success = base.Update("+ lowerCaseTableName + ");");
            sb.AppendLine("            }");
            sb.AppendLine("            return success;");
            sb.AppendLine("        }");
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine("        public bool Delete"+ tableName + "("+ tableName + " "+ lowerCaseTableName + ")");
            sb.AppendLine("        {");
            sb.AppendLine("            bool success = false;");
            sb.AppendLine("            success = base.Delete("+ lowerCaseTableName + ");");
            sb.AppendLine("            return success;");
            sb.AppendLine("        }");
            sb.AppendLine("    }");
            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
