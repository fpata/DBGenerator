using System;
using System.Data;

namespace DBGen
{
    public interface ICodeHelper
    {
        String GetCode(String tableName, DataTable dtColumns, ORM ormType);
    }
}