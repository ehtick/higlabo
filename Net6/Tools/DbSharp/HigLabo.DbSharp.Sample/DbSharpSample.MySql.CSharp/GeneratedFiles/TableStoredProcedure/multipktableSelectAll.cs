﻿//Generated at 2022/01/01 11:52:05 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using HigLabo.Core;
using HigLabo.Data;
using HigLabo.DbSharp;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace HigLabo.DbSharpSample.MySql
{
    public partial class multipktableSelectAll : StoredProcedureWithResultSet<multipktableSelectAll.ResultSet>
    {
        public const String Name = "multipktableSelectAll";

        public String DatabaseKey
        {
            get
            {
                return ((IDatabaseContext)this).DatabaseKey;
            }
            set
            {
                ((IDatabaseContext)this).DatabaseKey = value;
            }
        }

        public multipktableSelectAll()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_MySql";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return multipktableSelectAll.Name;
        }
        partial void ConstructorExecuted();
        public override DbCommand CreateCommand(Database database)
        {
            var db = database;
            var cm = db.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = this.GetStoredProcedureName();
            return cm;
        }
        protected override void SetOutputParameterValue(DbCommand command)
        {
        }
        public override multipktableSelectAll.ResultSet CreateResultSet()
        {
            return new ResultSet(this);
        }
        protected override void SetResultSet(multipktableSelectAll.ResultSet resultSet, IDataReader reader)
        {
            var r = resultSet;
            Int32 index = -1;
            try
            {
                index += 1; r.BigIntColumn = reader.GetInt64(index);
                index += 1; r.IntColumn = reader.GetInt32(index);
                index += 1; r.FloatColumn = reader.GetFloat(index);
                index += 1; if (reader[index] != DBNull.Value) r.BinaryColumn = reader[index] as Byte[];
                index += 1; r.TimestampColumn = reader.GetDateTime(index);
                index += 1; if (reader[index] != DBNull.Value) r.VarBinaryColumn = reader[index] as Byte[];
                index += 1; if (reader[index] != DBNull.Value) r.BitColumn = ((UInt64)reader[index] != 0);
                index += 1; if (reader[index] != DBNull.Value) r.NCharColumn = reader[index] as String;
                index += 1; if (reader[index] != DBNull.Value) r.NVarCharColumn = reader[index] as String;
            }
            catch (Exception ex)
            {
                throw new StoredProcedureSchemaMismatchedException(this, index, ex);
            }
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<multipktableSelectAll>");
            return sb.ToString();
        }

        public partial class ResultSet : StoredProcedureResultSet, multipktable.IRecord
        {
            private Int64 _BigIntColumn;
            private Int32 _IntColumn;
            private Single _FloatColumn;
            private Byte[] _BinaryColumn;
            private DateTime _TimestampColumn;
            private Byte[] _VarBinaryColumn;
            private Boolean? _BitColumn;
            private String _NCharColumn = null;
            private String _NVarCharColumn = null;

            public Int64 BigIntColumn
            {
                get
                {
                    return _BigIntColumn;
                }
                set
                {
                    _BigIntColumn = value;
                }
            }
            public Int32 IntColumn
            {
                get
                {
                    return _IntColumn;
                }
                set
                {
                    _IntColumn = value;
                }
            }
            public Single FloatColumn
            {
                get
                {
                    return _FloatColumn;
                }
                set
                {
                    _FloatColumn = value;
                }
            }
            public Byte[] BinaryColumn
            {
                get
                {
                    return _BinaryColumn;
                }
                set
                {
                    _BinaryColumn = value;
                }
            }
            public DateTime TimestampColumn
            {
                get
                {
                    return _TimestampColumn;
                }
                set
                {
                    _TimestampColumn = value;
                }
            }
            public Byte[] VarBinaryColumn
            {
                get
                {
                    return _VarBinaryColumn;
                }
                set
                {
                    _VarBinaryColumn = value;
                }
            }
            public Boolean? BitColumn
            {
                get
                {
                    return _BitColumn;
                }
                set
                {
                    _BitColumn = value;
                }
            }
            public String NCharColumn
            {
                get
                {
                    return _NCharColumn;
                }
                set
                {
                    _NCharColumn = value;
                }
            }
            public String NVarCharColumn
            {
                get
                {
                    return _NVarCharColumn;
                }
                set
                {
                    _NVarCharColumn = value;
                }
            }

            public ResultSet()
            {
            }
            public ResultSet(multipktable.IRecord resultSet)
            {
                var r = resultSet;
                BigIntColumn = r.BigIntColumn;
                IntColumn = r.IntColumn;
                FloatColumn = r.FloatColumn;
                BinaryColumn = r.BinaryColumn;
                TimestampColumn = r.TimestampColumn;
                VarBinaryColumn = r.VarBinaryColumn;
                BitColumn = r.BitColumn;
                NCharColumn = r.NCharColumn;
                NVarCharColumn = r.NVarCharColumn;
            }
            internal ResultSet(multipktableSelectAll storedProcedure)
            {
                this._StoredProcedureResultSet_StoredProcedure = storedProcedure;
            }

            public override String ToString()
            {
                var sb = new StringBuilder(64);
                sb.AppendLine("<multipktableSelectAll.ResultSet>");
                sb.AppendFormat("BigIntColumn={0}", this.BigIntColumn); sb.AppendLine();
                sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
                sb.AppendFormat("FloatColumn={0}", this.FloatColumn); sb.AppendLine();
                sb.AppendFormat("BinaryColumn={0}", this.BinaryColumn); sb.AppendLine();
                sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
                sb.AppendFormat("VarBinaryColumn={0}", this.VarBinaryColumn); sb.AppendLine();
                sb.AppendFormat("BitColumn={0}", this.BitColumn); sb.AppendLine();
                sb.AppendFormat("NCharColumn={0}", this.NCharColumn); sb.AppendLine();
                sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
                return sb.ToString();
            }
        }
    }
}
