﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigLabo.DbSharp.MetaData;

public abstract class DatabaseSchemaQueryBuilder
{
    public abstract String GetDatabases();
    public abstract String GetTables();
    public abstract String GetTable(String name);
    public abstract String GetColumns(String tableName);
    public abstract String GetPrimaryKey(String tableName);
    public abstract String GetIndex(String tableName);
    public abstract String GetForeignKeys(String tableName);
    public abstract String GetCheckConstraints(String tableName);
    public abstract String GetDefaultConstraints(String tableName);
    public abstract String GetViews();
    public abstract String GetStoredProcedures();
    public abstract String GetStoredProcedure(String name);
    public abstract String GetParameters(String storedProcedureName);
    public abstract String GetStoredFunctions();
    public abstract String GetUserDefinedTypes();
    public abstract String GetUserDefinedTypeColumns(String name);
}
