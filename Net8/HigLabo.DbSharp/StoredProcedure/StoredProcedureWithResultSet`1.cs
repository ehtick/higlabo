﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data;
using HigLabo.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Threading;

namespace HigLabo.DbSharp
{
    public abstract class StoredProcedureWithResultSet<T> : StoredProcedureWithResultSet
        where T : StoredProcedureResultSet, new()
    {
        protected abstract void SetResultSet(T resultSet, IDataReader reader);
        public abstract T CreateResultSet();
        protected override StoredProcedureResultSet CreateResultSets(IDataReader reader)
        {
            var rs = this.CreateResultSet();
            SetResultSet(rs, reader);
            return rs;
        }

        public new async ValueTask<T?> GetFirstResultSetAsync()
        {
            return await this.GetFirstResultSetAsync(this.GetDatabase());
        }
        public new async ValueTask<T?> GetFirstResultSetAsync(Database database)
        {
            return await this.GetFirstResultSetAsync(database, CancellationToken.None);
        }
        public new async ValueTask<T?> GetFirstResultSetAsync(Database database, CancellationToken cancellationToken)
        {
            return (await this.GetResultSetsAsync(database, cancellationToken)).FirstOrDefault() as T;
        }
        public new async ValueTask<T?> GetFirstResultSetAsync(IEnumerable<Database> databases)
        {
            return await this.GetFirstResultSetAsync(databases, CancellationToken.None);
        }
        public new async ValueTask<T?> GetFirstResultSetAsync(IEnumerable<Database> databases, CancellationToken cancellationToken)
        {
            var results = await this.GetResultSetsAsync(databases, cancellationToken);
            return results.FirstOrDefault() as T;
        }

        public new async ValueTask<List<T>> GetResultSetsAsync()
        {
            return await this.GetResultSetsAsync(this.GetDatabase(), CommandBehavior.Default, CancellationToken.None);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(CommandBehavior commandBehavior)
        {
            return await this.GetResultSetsAsync(this.GetDatabase(), commandBehavior, CancellationToken.None);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(CancellationToken cancellationToken)
        {
            return await this.GetResultSetsAsync(this.GetDatabase(), CommandBehavior.Default, cancellationToken);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(Database database)
        {
            return await this.GetResultSetsAsync(database, CommandBehavior.Default, CancellationToken.None);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(Database database, CommandBehavior commandBehavior)
        {
            return await this.GetResultSetsAsync(database, commandBehavior, CancellationToken.None);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(Database database, CancellationToken cancellationToken)
        {
            return await this.GetResultSetsAsync(database, CommandBehavior.Default, cancellationToken);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(Database database, CommandBehavior commandBehavior, CancellationToken cancellationToken)
        {
            var l = new List<T>();
            foreach (var item in await base.GetResultSetsAsync(database, commandBehavior, cancellationToken))
            {
                l.Add((T)item);
            }
            return l;
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(IEnumerable<Database> databases)
        {
            return await this.GetResultSetsAsync(databases, CommandBehavior.Default, CancellationToken.None);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(IEnumerable<Database> databases, CommandBehavior commandBehavior)
        {
            return await this.GetResultSetsAsync(databases, commandBehavior, CancellationToken.None);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(IEnumerable<Database> databases, CancellationToken cancellationToken)
        {
            return await this.GetResultSetsAsync(databases, CommandBehavior.Default, cancellationToken);
        }
        public new async ValueTask<List<T>> GetResultSetsAsync(IEnumerable<Database> databases, CommandBehavior commandBehavior, CancellationToken cancellationToken)
        {
            var l = new List<T>();
            foreach (var item in await base.GetResultSetsAsync(databases, commandBehavior, cancellationToken))
            {
                l.Add((T)item);
            }
            return l;
        }

        public T? GetFirstResultSet()
        {
            return this.EnumerateResultSets().FirstOrDefault();
        }
        public T? GetFirstResultSet(CommandBehavior commandBehavior)
        {
            return this.EnumerateResultSets(commandBehavior).FirstOrDefault();
        }
        public T? GetFirstResultSet(Database database)
        {
            return this.EnumerateResultSets(database).FirstOrDefault();
        }
        public T? GetFirstResultSet(Database database, CommandBehavior commandBehavior)
        {
            return this.EnumerateResultSets(database, commandBehavior).FirstOrDefault();
        }

        public List<T> GetResultSets()
        {
            return this.EnumerateResultSets().ToList();
        }
        public List<T> GetResultSets(CommandBehavior commandBehavior)
        {
            return this.EnumerateResultSets(commandBehavior).ToList();
        }
        public List<T> GetResultSets(Database database)
        {
            return this.EnumerateResultSets(database).ToList();
        }
        public List<T> GetResultSets(Database database, CommandBehavior commandBehavior)
        {
            return this.EnumerateResultSets(database, commandBehavior).ToList();
        }

        public new IEnumerable<T> EnumerateResultSets()
        {
            return base.EnumerateResultSets().Cast<T>();
        }
        public new IEnumerable<T> EnumerateResultSets(CommandBehavior commandBehavior)
        {
            return base.EnumerateResultSets(commandBehavior).Cast<T>();
        }
        public new IEnumerable<T> EnumerateResultSets(Database database)
        {
            return base.EnumerateResultSets(database, CommandBehavior.Default).Cast<T>();
        }
        public new IEnumerable<T> EnumerateResultSets(Database database, CommandBehavior commandBehavior)
        {
            return base.EnumerateResultSets(database, commandBehavior).Cast<T>();
        }

        public new async IAsyncEnumerable<T> EnumerateResultSetsAsync(Database database)
        {
            await foreach (var item in this.EnumerateResultSetsAsync(database, CommandBehavior.Default, CancellationToken.None))
            {
                yield return item;
            }
        }
        public new async IAsyncEnumerable<T> EnumerateResultSetsAsync(Database database, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            await foreach (var item in this.EnumerateResultSetsAsync(database, CommandBehavior.Default, cancellationToken))
            {
                yield return item;
            }
        }
        public new async IAsyncEnumerable<T> EnumerateResultSetsAsync(Database database, CommandBehavior commandBehavior, [EnumeratorCancellation] CancellationToken cancellationToken)
        {
            await foreach (var item in base.EnumerateResultSetsAsync(database, commandBehavior, cancellationToken))
            {
                yield return (T)item;
            }
        }

        public TResult? GetFirstResultSet<TResult>(Func<T, TResult> selector)
            where TResult : class
        {
            var r = this.EnumerateResultSets().FirstOrDefault();
            if (r == null) { return null; }
            return selector(r);
        }
        public List<TResult> GetResultSets<TResult>(Func<T, TResult> selector)
        {
            return this.EnumerateResultSets().Select(selector).ToList();
        }
        public List<TResult> GetResultSets<TResult>(Database database, Func<T, TResult> selector)
        {
            return this.EnumerateResultSets(database).Select(selector).ToList();
        }
        public async ValueTask<TResult?> GetFirstResultSetAsync<TResult>(Func<T, TResult> selector)
            where TResult : class
        {
            var r = await this.GetFirstResultSetAsync();
            if (r == null) { return null; }
            return selector(r);
        }
        public async ValueTask<List<TResult>> GetResultSetsAsync<TResult>(Func<T, TResult> selector)
        {
            var l = new List<TResult>();
            foreach (var item in await this.GetResultSetsAsync())
            {
                var r = selector(item);
                l.Add(r);
            }
            return l;
        }

        public IEnumerable<TResult> EnumerateResultSets<TResult>(Func<T, TResult> selector)
        {
            return this.EnumerateResultSets().Select(selector);
        }
        public IEnumerable<TResult> EnumerateResultSets<TResult>(Database database, Func<T, TResult> selector)
        {
            return this.EnumerateResultSets(database).Select(selector);
        }
        protected Func<DbDataReader, StoredProcedureResultSet> CreateCreateResultSetMethod<TResultSet>(Action<TResultSet, DbDataReader> setResultSetMethod)
            where TResultSet : StoredProcedureResultSet, new()
        {
            return dr =>
            {
                var rs = new TResultSet();
                setResultSetMethod(rs, dr);
                return rs;
            };
        }
    }
}
