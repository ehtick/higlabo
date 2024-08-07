﻿//Generated at 2022/01/01 11:52:05 by DbSharpApplication.
//https://github.com/higty/higlabo/tree/master/Net6/Tools/DbSharp
using System;
using System.Linq;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Collections.Generic;
using HigLabo.Data;
using HigLabo.DbSharp;

namespace HigLabo.DbSharpSample.MySql
{
    public partial class alldatatypetable : Table<alldatatypetable.Record>
    {
        public const String Name = "alldatatypetable";

        public override String TableName
        {
            get
            {
                return alldatatypetable.Name;
            }
        }

        public alldatatypetable()
        {
            ((IDatabaseContext)this).DatabaseKey = "DbSharpSample_MySql";
        }

        public override Record CreateRecord()
        {
            return new Record();
        }
        protected override void SetRecordProperty(StoredProcedureResultSet resultSet, Record record)
        {
            record.SetProperty(resultSet as IRecord);
        }
        protected override void SetOutputParameterValue(Record record, StoredProcedure storedProcedure)
        {
            var spInsert = storedProcedure as alldatatypetableInsert;
            if (spInsert != null)
            {
                record.TimestampColumn = spInsert.TimestampColumn;
            }
            var spUpdate = storedProcedure as alldatatypetableUpdate;
            if (spUpdate != null)
            {
                record.TimestampColumn = spUpdate.TimestampColumn;
            }
        }
        public Record SelectByPrimaryKey(Int64 primaryKeyColumn)
        {
            return this.SelectByPrimaryKey(this.GetDatabase(), primaryKeyColumn);
        }
        public Record SelectByPrimaryKeyOrNull(Int64 primaryKeyColumn)
        {
            return this.SelectByPrimaryKeyOrNull(this.GetDatabase(), primaryKeyColumn);
        }
        public Record SelectByPrimaryKey(Database database, Int64 primaryKeyColumn)
        {
            var r = this.SelectByPrimaryKeyOrNull(database, primaryKeyColumn);
            if (r == null) throw new TableRecordNotFoundException(Name, primaryKeyColumn);
            return r;
        }
        public Record SelectByPrimaryKeyOrNull(Database database, Int64 primaryKeyColumn)
        {
            var sp = new alldatatypetableSelectByPrimaryKey();
            sp.PK_PrimaryKeyColumn = primaryKeyColumn;
            var rs = sp.GetFirstResultSet(database);
            if (rs == null) return null;
            var r = new Record(rs);
            r.SetOldRecordProperty();
            return r;
        }
        public Int32 Delete(Int64 primaryKeyColumn, DateTime timestampColumn)
        {
            return this.Delete(this.GetDatabase(), primaryKeyColumn, timestampColumn);
        }
        public Int32 Delete(Database database, Int64 primaryKeyColumn, DateTime timestampColumn)
        {
            var sp = new alldatatypetableDelete();
            sp.PK_PrimaryKeyColumn = primaryKeyColumn;
            sp.PK_TimestampColumn = timestampColumn;
            return sp.ExecuteNonQuery(database);
        }
        public override StoredProcedureWithResultSet CreateStoredProcedureWithResultSet(TableStoredProcedureTypeWithResultSet type, Record record)
        {
            switch (type)
            {
                case TableStoredProcedureTypeWithResultSet.SelectAll: return CreateSelectAllStoredProcedure();
                case TableStoredProcedureTypeWithResultSet.SelectByPrimaryKey: return this.CreateSelectByPrimaryKeyStoredProcedure(record);
                default: throw new InvalidOperationException();
            }
        }
        public override StoredProcedure CreateStoredProcedure(TableStoredProcedureType type, Record record)
        {
            switch (type)
            {
                case TableStoredProcedureType.Insert: return this.CreateInsertStoredProcedure(record);
                case TableStoredProcedureType.Update: return this.CreateUpdateStoredProcedure(record);
                case TableStoredProcedureType.Delete: return this.CreateDeleteStoredProcedure(record);
                default: throw new InvalidOperationException();
            }
        }
        public alldatatypetableSelectAll CreateSelectAllStoredProcedure()
        {
            return new alldatatypetableSelectAll();
        }
        public alldatatypetableSelectByPrimaryKey CreateSelectByPrimaryKeyStoredProcedure(Record record)
        {
            var sp = new alldatatypetableSelectByPrimaryKey();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_PrimaryKeyColumn = record.OldRecord.PrimaryKeyColumn;
            return sp;
        }
        public alldatatypetableInsert CreateInsertStoredProcedure(Record record)
        {
            var sp = new alldatatypetableInsert();
            if (record == null) return sp;
            sp.PrimaryKeyColumn = record.PrimaryKeyColumn;
            sp.TimestampColumn = record.TimestampColumn;
            sp.CharColumn = record.CharColumn;
            sp.VarCharColumn = record.VarCharColumn;
            sp.BitColumn = record.BitColumn;
            sp.TinyIntColumn = record.TinyIntColumn;
            sp.SmallIntColumn = record.SmallIntColumn;
            sp.MediumIntColumn = record.MediumIntColumn;
            sp.IntColumn = record.IntColumn;
            sp.BigIntColumn = record.BigIntColumn;
            sp.TinyIntUnsignedColumn = record.TinyIntUnsignedColumn;
            sp.SmallIntUnsignedColumn = record.SmallIntUnsignedColumn;
            sp.MediumIntUnsignedColumn = record.MediumIntUnsignedColumn;
            sp.IntUnsignedColumn = record.IntUnsignedColumn;
            sp.BigIntUnsignedColumn = record.BigIntUnsignedColumn;
            sp.FloatColumn = record.FloatColumn;
            sp.DoubleColumn = record.DoubleColumn;
            sp.DecimalColumn = record.DecimalColumn;
            sp.NumericColumn = record.NumericColumn;
            sp.DateColumn = record.DateColumn;
            sp.DateTimeColumn = record.DateTimeColumn;
            sp.TimeColumn = record.TimeColumn;
            sp.YearColumn = record.YearColumn;
            sp.BinaryColumn = record.BinaryColumn;
            sp.VarBinaryColumn = record.VarBinaryColumn;
            sp.TinyBlobColumn = record.TinyBlobColumn;
            sp.MediumBlobColumn = record.MediumBlobColumn;
            sp.BlobColumn = record.BlobColumn;
            sp.LongBlobColumn = record.LongBlobColumn;
            sp.TinyTextColumn = record.TinyTextColumn;
            sp.MediumTextColumn = record.MediumTextColumn;
            sp.TextColumn = record.TextColumn;
            sp.LongTextColumn = record.LongTextColumn;
            sp.GeometryColumn = record.GeometryColumn;
            sp.EnumColumn = record.EnumColumn;
            sp.SetColumn = record.SetColumn;
            sp.NotNullCharColumn = record.NotNullCharColumn;
            sp.NotNullVarCharColumn = record.NotNullVarCharColumn;
            sp.NotNullBitColumn = record.NotNullBitColumn;
            sp.NotNullTinyIntColumn = record.NotNullTinyIntColumn;
            sp.NotNullSmallIntColumn = record.NotNullSmallIntColumn;
            sp.NotNullMediumIntColumn = record.NotNullMediumIntColumn;
            sp.NotNullIntColumn = record.NotNullIntColumn;
            sp.NotNullBigIntColumn = record.NotNullBigIntColumn;
            sp.NotNullTinyIntUnsignedColumn = record.NotNullTinyIntUnsignedColumn;
            sp.NotNullSmallIntUnsignedColumn = record.NotNullSmallIntUnsignedColumn;
            sp.NotNullMediumIntUnsignedColumn = record.NotNullMediumIntUnsignedColumn;
            sp.NotNullIntUnsignedColumn = record.NotNullIntUnsignedColumn;
            sp.NotNullBigIntUnsignedColumn = record.NotNullBigIntUnsignedColumn;
            sp.NotNullFloatColumn = record.NotNullFloatColumn;
            sp.NotNullDoubleColumn = record.NotNullDoubleColumn;
            sp.NotNullDecimalColumn = record.NotNullDecimalColumn;
            sp.NotNullNumericColumn = record.NotNullNumericColumn;
            sp.NotNullDateColumn = record.NotNullDateColumn;
            sp.NotNullDateTimeColumn = record.NotNullDateTimeColumn;
            sp.NotNullTimeColumn = record.NotNullTimeColumn;
            sp.NotNullYearColumn = record.NotNullYearColumn;
            sp.NotNullBinaryColumn = record.NotNullBinaryColumn;
            sp.NotNullVarBinaryColumn = record.NotNullVarBinaryColumn;
            sp.NotNullTinyBlobColumn = record.NotNullTinyBlobColumn;
            sp.NotNullTinyTextColumn = record.NotNullTinyTextColumn;
            sp.NotNullBlobColumn = record.NotNullBlobColumn;
            sp.NotNullTextColumn = record.NotNullTextColumn;
            sp.NotNullMediumBlobColumn = record.NotNullMediumBlobColumn;
            sp.NotNullMediumTextColumn = record.NotNullMediumTextColumn;
            sp.NotNullLongBlobColumn = record.NotNullLongBlobColumn;
            sp.NotNullLongTextColumn = record.NotNullLongTextColumn;
            sp.NotNullGeometryColumn = record.NotNullGeometryColumn;
            sp.NotNullEnumColumn = record.NotNullEnumColumn;
            sp.NotNullSetColumn = record.NotNullSetColumn;
            return sp;
        }
        public alldatatypetableUpdate CreateUpdateStoredProcedure(Record record)
        {
            var sp = new alldatatypetableUpdate();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PrimaryKeyColumn = record.PrimaryKeyColumn;
            sp.TimestampColumn = record.TimestampColumn;
            sp.CharColumn = record.CharColumn;
            sp.VarCharColumn = record.VarCharColumn;
            sp.BitColumn = record.BitColumn;
            sp.TinyIntColumn = record.TinyIntColumn;
            sp.SmallIntColumn = record.SmallIntColumn;
            sp.MediumIntColumn = record.MediumIntColumn;
            sp.IntColumn = record.IntColumn;
            sp.BigIntColumn = record.BigIntColumn;
            sp.TinyIntUnsignedColumn = record.TinyIntUnsignedColumn;
            sp.SmallIntUnsignedColumn = record.SmallIntUnsignedColumn;
            sp.MediumIntUnsignedColumn = record.MediumIntUnsignedColumn;
            sp.IntUnsignedColumn = record.IntUnsignedColumn;
            sp.BigIntUnsignedColumn = record.BigIntUnsignedColumn;
            sp.FloatColumn = record.FloatColumn;
            sp.DoubleColumn = record.DoubleColumn;
            sp.DecimalColumn = record.DecimalColumn;
            sp.NumericColumn = record.NumericColumn;
            sp.DateColumn = record.DateColumn;
            sp.DateTimeColumn = record.DateTimeColumn;
            sp.TimeColumn = record.TimeColumn;
            sp.YearColumn = record.YearColumn;
            sp.BinaryColumn = record.BinaryColumn;
            sp.VarBinaryColumn = record.VarBinaryColumn;
            sp.TinyBlobColumn = record.TinyBlobColumn;
            sp.MediumBlobColumn = record.MediumBlobColumn;
            sp.BlobColumn = record.BlobColumn;
            sp.LongBlobColumn = record.LongBlobColumn;
            sp.TinyTextColumn = record.TinyTextColumn;
            sp.MediumTextColumn = record.MediumTextColumn;
            sp.TextColumn = record.TextColumn;
            sp.LongTextColumn = record.LongTextColumn;
            sp.GeometryColumn = record.GeometryColumn;
            sp.EnumColumn = record.EnumColumn;
            sp.SetColumn = record.SetColumn;
            sp.NotNullCharColumn = record.NotNullCharColumn;
            sp.NotNullVarCharColumn = record.NotNullVarCharColumn;
            sp.NotNullBitColumn = record.NotNullBitColumn;
            sp.NotNullTinyIntColumn = record.NotNullTinyIntColumn;
            sp.NotNullSmallIntColumn = record.NotNullSmallIntColumn;
            sp.NotNullMediumIntColumn = record.NotNullMediumIntColumn;
            sp.NotNullIntColumn = record.NotNullIntColumn;
            sp.NotNullBigIntColumn = record.NotNullBigIntColumn;
            sp.NotNullTinyIntUnsignedColumn = record.NotNullTinyIntUnsignedColumn;
            sp.NotNullSmallIntUnsignedColumn = record.NotNullSmallIntUnsignedColumn;
            sp.NotNullMediumIntUnsignedColumn = record.NotNullMediumIntUnsignedColumn;
            sp.NotNullIntUnsignedColumn = record.NotNullIntUnsignedColumn;
            sp.NotNullBigIntUnsignedColumn = record.NotNullBigIntUnsignedColumn;
            sp.NotNullFloatColumn = record.NotNullFloatColumn;
            sp.NotNullDoubleColumn = record.NotNullDoubleColumn;
            sp.NotNullDecimalColumn = record.NotNullDecimalColumn;
            sp.NotNullNumericColumn = record.NotNullNumericColumn;
            sp.NotNullDateColumn = record.NotNullDateColumn;
            sp.NotNullDateTimeColumn = record.NotNullDateTimeColumn;
            sp.NotNullTimeColumn = record.NotNullTimeColumn;
            sp.NotNullYearColumn = record.NotNullYearColumn;
            sp.NotNullBinaryColumn = record.NotNullBinaryColumn;
            sp.NotNullVarBinaryColumn = record.NotNullVarBinaryColumn;
            sp.NotNullTinyBlobColumn = record.NotNullTinyBlobColumn;
            sp.NotNullTinyTextColumn = record.NotNullTinyTextColumn;
            sp.NotNullBlobColumn = record.NotNullBlobColumn;
            sp.NotNullTextColumn = record.NotNullTextColumn;
            sp.NotNullMediumBlobColumn = record.NotNullMediumBlobColumn;
            sp.NotNullMediumTextColumn = record.NotNullMediumTextColumn;
            sp.NotNullLongBlobColumn = record.NotNullLongBlobColumn;
            sp.NotNullLongTextColumn = record.NotNullLongTextColumn;
            sp.NotNullGeometryColumn = record.NotNullGeometryColumn;
            sp.NotNullEnumColumn = record.NotNullEnumColumn;
            sp.NotNullSetColumn = record.NotNullSetColumn;
            sp.PK_PrimaryKeyColumn = record.OldRecord.PrimaryKeyColumn;
            sp.PK_TimestampColumn = record.OldRecord.TimestampColumn;
            return sp;
        }
        public alldatatypetableDelete CreateDeleteStoredProcedure(Record record)
        {
            var sp = new alldatatypetableDelete();
            if (record == null) return sp;
            if (record.OldRecord == null) throw new OldRecordIsNullException();
            sp.PK_PrimaryKeyColumn = record.OldRecord.PrimaryKeyColumn;
            sp.PK_TimestampColumn = record.OldRecord.TimestampColumn;
            return sp;
        }
        protected override DataTable CreateDataTable()
        {
            var dt = new DataTable(Name);
            dt.Columns.Add("@PK_PrimaryKeyColumn", typeof(Int64));
            dt.Columns.Add("@PrimaryKeyColumn", typeof(Int64));
            dt.Columns.Add("@TimestampColumn", typeof(DateTime));
            dt.Columns.Add("@CharColumn", typeof(String));
            dt.Columns.Add("@VarCharColumn", typeof(String));
            dt.Columns.Add("@BitColumn", typeof(Boolean));
            dt.Columns.Add("@TinyIntColumn", typeof(SByte));
            dt.Columns.Add("@SmallIntColumn", typeof(Int16));
            dt.Columns.Add("@MediumIntColumn", typeof(Int32));
            dt.Columns.Add("@IntColumn", typeof(Int32));
            dt.Columns.Add("@BigIntColumn", typeof(Int64));
            dt.Columns.Add("@TinyIntUnsignedColumn", typeof(Byte));
            dt.Columns.Add("@SmallIntUnsignedColumn", typeof(UInt16));
            dt.Columns.Add("@MediumIntUnsignedColumn", typeof(UInt32));
            dt.Columns.Add("@IntUnsignedColumn", typeof(UInt32));
            dt.Columns.Add("@BigIntUnsignedColumn", typeof(UInt64));
            dt.Columns.Add("@FloatColumn", typeof(Single));
            dt.Columns.Add("@DoubleColumn", typeof(Double));
            dt.Columns.Add("@DecimalColumn", typeof(Decimal));
            dt.Columns.Add("@NumericColumn", typeof(Decimal));
            dt.Columns.Add("@DateColumn", typeof(DateTime));
            dt.Columns.Add("@DateTimeColumn", typeof(DateTime));
            dt.Columns.Add("@TimeColumn", typeof(TimeSpan));
            dt.Columns.Add("@YearColumn", typeof(Int32));
            dt.Columns.Add("@BinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@VarBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@TinyBlobColumn", typeof(Byte[]));
            dt.Columns.Add("@MediumBlobColumn", typeof(Byte[]));
            dt.Columns.Add("@BlobColumn", typeof(Byte[]));
            dt.Columns.Add("@LongBlobColumn", typeof(Byte[]));
            dt.Columns.Add("@TinyTextColumn", typeof(String));
            dt.Columns.Add("@MediumTextColumn", typeof(String));
            dt.Columns.Add("@TextColumn", typeof(String));
            dt.Columns.Add("@LongTextColumn", typeof(String));
            dt.Columns.Add("@GeometryColumn", typeof(global::MySql.Data.Types.MySqlGeometry));
            dt.Columns.Add("@EnumColumn", typeof(String));
            dt.Columns.Add("@SetColumn", typeof(String));
            dt.Columns.Add("@NotNullCharColumn", typeof(String));
            dt.Columns.Add("@NotNullVarCharColumn", typeof(String));
            dt.Columns.Add("@NotNullBitColumn", typeof(Boolean));
            dt.Columns.Add("@NotNullTinyIntColumn", typeof(SByte));
            dt.Columns.Add("@NotNullSmallIntColumn", typeof(Int16));
            dt.Columns.Add("@NotNullMediumIntColumn", typeof(Int32));
            dt.Columns.Add("@NotNullIntColumn", typeof(Int32));
            dt.Columns.Add("@NotNullBigIntColumn", typeof(Int64));
            dt.Columns.Add("@NotNullTinyIntUnsignedColumn", typeof(Byte));
            dt.Columns.Add("@NotNullSmallIntUnsignedColumn", typeof(UInt16));
            dt.Columns.Add("@NotNullMediumIntUnsignedColumn", typeof(UInt32));
            dt.Columns.Add("@NotNullIntUnsignedColumn", typeof(UInt32));
            dt.Columns.Add("@NotNullBigIntUnsignedColumn", typeof(UInt64));
            dt.Columns.Add("@NotNullFloatColumn", typeof(Single));
            dt.Columns.Add("@NotNullDoubleColumn", typeof(Double));
            dt.Columns.Add("@NotNullDecimalColumn", typeof(Decimal));
            dt.Columns.Add("@NotNullNumericColumn", typeof(Decimal));
            dt.Columns.Add("@NotNullDateColumn", typeof(DateTime));
            dt.Columns.Add("@NotNullDateTimeColumn", typeof(DateTime));
            dt.Columns.Add("@NotNullTimeColumn", typeof(TimeSpan));
            dt.Columns.Add("@NotNullYearColumn", typeof(Int32));
            dt.Columns.Add("@NotNullBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullVarBinaryColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullTinyBlobColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullTinyTextColumn", typeof(String));
            dt.Columns.Add("@NotNullBlobColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullTextColumn", typeof(String));
            dt.Columns.Add("@NotNullMediumBlobColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullMediumTextColumn", typeof(String));
            dt.Columns.Add("@NotNullLongBlobColumn", typeof(Byte[]));
            dt.Columns.Add("@NotNullLongTextColumn", typeof(String));
            dt.Columns.Add("@NotNullGeometryColumn", typeof(global::MySql.Data.Types.MySqlGeometry));
            dt.Columns.Add("@NotNullEnumColumn", typeof(String));
            dt.Columns.Add("@NotNullSetColumn", typeof(String));
            return dt;
        }
        protected override DataRow SetDataRow(DataRow dataRow, Record record, SaveMode saveMode)
        {
            if (saveMode != SaveMode.Insert)
            {
                if (record.OldRecord == null) throw new OldRecordIsNullException();
                dataRow["@PK_PrimaryKeyColumn"] = GetValueOrDBNull(record.OldRecord.PrimaryKeyColumn);
            }
            dataRow["@PrimaryKeyColumn"] = GetValueOrDBNull(record.PrimaryKeyColumn);
            dataRow["@TimestampColumn"] = GetValueOrDBNull(record.TimestampColumn);
            dataRow["@CharColumn"] = GetValueOrDBNull(record.CharColumn);
            dataRow["@VarCharColumn"] = GetValueOrDBNull(record.VarCharColumn);
            dataRow["@BitColumn"] = GetValueOrDBNull(record.BitColumn);
            dataRow["@TinyIntColumn"] = GetValueOrDBNull(record.TinyIntColumn);
            dataRow["@SmallIntColumn"] = GetValueOrDBNull(record.SmallIntColumn);
            dataRow["@MediumIntColumn"] = GetValueOrDBNull(record.MediumIntColumn);
            dataRow["@IntColumn"] = GetValueOrDBNull(record.IntColumn);
            dataRow["@BigIntColumn"] = GetValueOrDBNull(record.BigIntColumn);
            dataRow["@TinyIntUnsignedColumn"] = GetValueOrDBNull(record.TinyIntUnsignedColumn);
            dataRow["@SmallIntUnsignedColumn"] = GetValueOrDBNull(record.SmallIntUnsignedColumn);
            dataRow["@MediumIntUnsignedColumn"] = GetValueOrDBNull(record.MediumIntUnsignedColumn);
            dataRow["@IntUnsignedColumn"] = GetValueOrDBNull(record.IntUnsignedColumn);
            dataRow["@BigIntUnsignedColumn"] = GetValueOrDBNull(record.BigIntUnsignedColumn);
            dataRow["@FloatColumn"] = GetValueOrDBNull(record.FloatColumn);
            dataRow["@DoubleColumn"] = GetValueOrDBNull(record.DoubleColumn);
            dataRow["@DecimalColumn"] = GetValueOrDBNull(record.DecimalColumn);
            dataRow["@NumericColumn"] = GetValueOrDBNull(record.NumericColumn);
            dataRow["@DateColumn"] = GetValueOrDBNull(record.DateColumn);
            dataRow["@DateTimeColumn"] = GetValueOrDBNull(record.DateTimeColumn);
            dataRow["@TimeColumn"] = GetValueOrDBNull(record.TimeColumn);
            dataRow["@YearColumn"] = GetValueOrDBNull(record.YearColumn);
            dataRow["@BinaryColumn"] = GetValueOrDBNull(record.BinaryColumn);
            dataRow["@VarBinaryColumn"] = GetValueOrDBNull(record.VarBinaryColumn);
            dataRow["@TinyBlobColumn"] = GetValueOrDBNull(record.TinyBlobColumn);
            dataRow["@MediumBlobColumn"] = GetValueOrDBNull(record.MediumBlobColumn);
            dataRow["@BlobColumn"] = GetValueOrDBNull(record.BlobColumn);
            dataRow["@LongBlobColumn"] = GetValueOrDBNull(record.LongBlobColumn);
            dataRow["@TinyTextColumn"] = GetValueOrDBNull(record.TinyTextColumn);
            dataRow["@MediumTextColumn"] = GetValueOrDBNull(record.MediumTextColumn);
            dataRow["@TextColumn"] = GetValueOrDBNull(record.TextColumn);
            dataRow["@LongTextColumn"] = GetValueOrDBNull(record.LongTextColumn);
            dataRow["@GeometryColumn"] = GetValueOrDBNull(record.GeometryColumn);
            dataRow["@EnumColumn"] = GetValueOrDBNull(record.EnumColumn);
            dataRow["@SetColumn"] = GetValueOrDBNull(record.SetColumn);
            dataRow["@NotNullCharColumn"] = GetValueOrDBNull(record.NotNullCharColumn);
            dataRow["@NotNullVarCharColumn"] = GetValueOrDBNull(record.NotNullVarCharColumn);
            dataRow["@NotNullBitColumn"] = GetValueOrDBNull(record.NotNullBitColumn);
            dataRow["@NotNullTinyIntColumn"] = GetValueOrDBNull(record.NotNullTinyIntColumn);
            dataRow["@NotNullSmallIntColumn"] = GetValueOrDBNull(record.NotNullSmallIntColumn);
            dataRow["@NotNullMediumIntColumn"] = GetValueOrDBNull(record.NotNullMediumIntColumn);
            dataRow["@NotNullIntColumn"] = GetValueOrDBNull(record.NotNullIntColumn);
            dataRow["@NotNullBigIntColumn"] = GetValueOrDBNull(record.NotNullBigIntColumn);
            dataRow["@NotNullTinyIntUnsignedColumn"] = GetValueOrDBNull(record.NotNullTinyIntUnsignedColumn);
            dataRow["@NotNullSmallIntUnsignedColumn"] = GetValueOrDBNull(record.NotNullSmallIntUnsignedColumn);
            dataRow["@NotNullMediumIntUnsignedColumn"] = GetValueOrDBNull(record.NotNullMediumIntUnsignedColumn);
            dataRow["@NotNullIntUnsignedColumn"] = GetValueOrDBNull(record.NotNullIntUnsignedColumn);
            dataRow["@NotNullBigIntUnsignedColumn"] = GetValueOrDBNull(record.NotNullBigIntUnsignedColumn);
            dataRow["@NotNullFloatColumn"] = GetValueOrDBNull(record.NotNullFloatColumn);
            dataRow["@NotNullDoubleColumn"] = GetValueOrDBNull(record.NotNullDoubleColumn);
            dataRow["@NotNullDecimalColumn"] = GetValueOrDBNull(record.NotNullDecimalColumn);
            dataRow["@NotNullNumericColumn"] = GetValueOrDBNull(record.NotNullNumericColumn);
            dataRow["@NotNullDateColumn"] = GetValueOrDBNull(record.NotNullDateColumn);
            dataRow["@NotNullDateTimeColumn"] = GetValueOrDBNull(record.NotNullDateTimeColumn);
            dataRow["@NotNullTimeColumn"] = GetValueOrDBNull(record.NotNullTimeColumn);
            dataRow["@NotNullYearColumn"] = GetValueOrDBNull(record.NotNullYearColumn);
            dataRow["@NotNullBinaryColumn"] = GetValueOrDBNull(record.NotNullBinaryColumn);
            dataRow["@NotNullVarBinaryColumn"] = GetValueOrDBNull(record.NotNullVarBinaryColumn);
            dataRow["@NotNullTinyBlobColumn"] = GetValueOrDBNull(record.NotNullTinyBlobColumn);
            dataRow["@NotNullTinyTextColumn"] = GetValueOrDBNull(record.NotNullTinyTextColumn);
            dataRow["@NotNullBlobColumn"] = GetValueOrDBNull(record.NotNullBlobColumn);
            dataRow["@NotNullTextColumn"] = GetValueOrDBNull(record.NotNullTextColumn);
            dataRow["@NotNullMediumBlobColumn"] = GetValueOrDBNull(record.NotNullMediumBlobColumn);
            dataRow["@NotNullMediumTextColumn"] = GetValueOrDBNull(record.NotNullMediumTextColumn);
            dataRow["@NotNullLongBlobColumn"] = GetValueOrDBNull(record.NotNullLongBlobColumn);
            dataRow["@NotNullLongTextColumn"] = GetValueOrDBNull(record.NotNullLongTextColumn);
            dataRow["@NotNullGeometryColumn"] = GetValueOrDBNull(record.NotNullGeometryColumn);
            dataRow["@NotNullEnumColumn"] = GetValueOrDBNull(record.NotNullEnumColumn);
            dataRow["@NotNullSetColumn"] = GetValueOrDBNull(record.NotNullSetColumn);
            return dataRow;
        }
    }
}
