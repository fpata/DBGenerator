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

        public String GetDALCode(string tableName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("using Microsoft.EntityFrameworkCore;");
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine();
            sb.AppendLine("namespace DBGen.DataAccess");
            sb.AppendLine("{");
            sb.AppendLine("\tpublic class " + tableName + "DAL");
            sb.AppendLine("\t{");

            sb.AppendLine();
            sb.AppendLine("\t\tprivate readonly DBGenDbContext DBGenContext;");
            sb.AppendLine();

//GetAll
            sb.AppendLine("\t\tpublic List<" + tableName + "> GetAll" + tableName + "s()");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\treturn DBGenContext." + tableName + "s.ToList();");
            sb.AppendLine("\t\t}");
            sb.AppendLine();

//GetById
            sb.AppendLine("\t\tpublic " + tableName + " Get" + tableName + "(int Id)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\treturn DBGenContext." + tableName + "s.First(t => t.Id == Id).ToList();");
            sb.AppendLine("\t\t}");
            sb.AppendLine();

//Update
            sb.AppendLine("\t\tpublic void Update" + tableName + "(" + tableName +" "+ tableName.ToLower() +")");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tDBGenContext." + tableName + "s.Update("+tableName.ToLower()+");");
            sb.AppendLine("\t\t\tDBGenContext.SaveChanges();");
            sb.AppendLine("\t\t}");
            sb.AppendLine();

//Add
            sb.AppendLine("\t\tpublic void Add" + tableName + "(" + tableName +" "+ tableName.ToLower() +")");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tDBGenContext." + tableName + "s.Add("+tableName.ToLower()+");");
            sb.AppendLine("\t\t\tDBGenContext.SaveChanges();");
            sb.AppendLine("\t\t}");
            sb.AppendLine();

     
//Delete
            sb.AppendLine("\t\tpublic void Delete" + tableName + "(int Id)");
            sb.AppendLine("\t\t{");
            sb.AppendLine("\t\t\tvar tempObj = new "+tableName+"{Id = Id};");
            sb.AppendLine("\t\t\tDBGenContext."+tableName+"s.Attach(tempObj);");
            sb.AppendLine("\t\t\tDBGenContext.SaveChanges();");
            sb.AppendLine("\t\t}");
            sb.AppendLine();

            sb.AppendLine("\t}");
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}