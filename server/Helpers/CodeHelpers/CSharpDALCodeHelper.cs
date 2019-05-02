using System;
using System.Data;
using System.Globalization;
using System.Text;

namespace DBGen
{
    public class CSharpDALCodeHelper : ICodeHelper
    {
        public string GetCode(string tableName, DataTable dtColumns, ORM ormType)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }

        public string GetDBContextCode(DataTable dtTables)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using Microsoft.EntityFrameworkCore;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendLine("namespace DBGen.DataAccess");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic class DBGenDbContext:DbContext");
            sb.AppendLine("\t{");
            sb.AppendLine();
            
            foreach (DataRow dr in dtTables.Rows)
            {
                sb.Append("\t\tinternal DbSet<");
                sb.Append(dr["Name"]);
                sb.Append("> ");
                sb.Append(dr["Name"]);
                sb.Append("s { get; set; }");
                sb.AppendLine();
            }

            sb.AppendLine("\t\tprotected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\toptionsBuilder.UseSqlite(connectStr);");
            sb.AppendLine("\t\t}");
            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}