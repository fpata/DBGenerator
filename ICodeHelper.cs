using System;
using System.Data;

namespace DBGen
{
    internal interface ICodeHelper
    {
        String GetCode(String tableName, DataTable dtColumns, bool requireEFMappings);
    }
}