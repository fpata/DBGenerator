using System;
using System.Data;

namespace DBGen
{
    public interface ICodeHelper
    {
        String GetCode(String tableName, ORM ormType, DataTable dtTables = null, DataTable dtColumns = null);
    }
}