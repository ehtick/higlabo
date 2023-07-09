﻿//Generated by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net7
using System.Data;
using System.Data.Common;
using System.Text;
using HigLabo.Core;
using HigLabo.Data;
using HigLabo.DbSharp;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace HigLabo.DbSharpSample.MySql
{
    public partial class identitytableSelectAll : StoredProcedureWithResultSet<identitytableSelectAll.ResultSet>
    {
        public partial class ResultSet : StoredProcedureResultSet
        {
            private Int32 _IntColumn;
            private DateTime _TimestampColumn;
            private String _NVarCharColumn = "";

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
            public String NVarCharColumn
            {
                get
                {
                    return _NVarCharColumn;
                }
                set
                {
                    _NVarCharColumn = value ?? "";
                }
            }

            public ResultSet()
            {
            }
            public ResultSet(ResultSet resultSet)
            {
                var r = resultSet;
                IntColumn = r.IntColumn;
                TimestampColumn = r.TimestampColumn;
                NVarCharColumn = r.NVarCharColumn;
            }
            internal ResultSet(identitytableSelectAll storedProcedure)
            {
                this._StoredProcedureResultSet_StoredProcedure = storedProcedure;
            }

            public override String ToString()
            {
                var sb = new StringBuilder(64);
                sb.AppendLine("<identitytableSelectAll.ResultSet>");
                sb.AppendFormat("IntColumn={0}", this.IntColumn); sb.AppendLine();
                sb.AppendFormat("TimestampColumn={0}", this.TimestampColumn); sb.AppendLine();
                sb.AppendFormat("NVarCharColumn={0}", this.NVarCharColumn); sb.AppendLine();
                return sb.ToString();
            }
        }

        public const String Name = "identitytableSelectAll";

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

        public identitytableSelectAll()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample";
            ConstructorExecuted();
        }

        public override String GetStoredProcedureName()
        {
            return identitytableSelectAll.Name;
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
        public override identitytableSelectAll.ResultSet CreateResultSet()
        {
            return new ResultSet(this);
        }
        protected override void SetResultSet(identitytableSelectAll.ResultSet resultSet, IDataReader reader)
        {
            var r = resultSet;
            Int32 index = -1;
            try
            {
                index += 1; r.IntColumn = reader.GetInt32(index);
                index += 1; r.TimestampColumn = reader.GetDateTime(index);
                index += 1; r.NVarCharColumn = (String)reader[index];
            }
            catch (Exception ex)
            {
                throw new StoredProcedureSchemaMismatchedException(this, index, ex);
            }
        }
        public override String ToString()
        {
            var sb = new StringBuilder(32);
            sb.AppendLine("<identitytableSelectAll>");
            return sb.ToString();
        }
    }
}