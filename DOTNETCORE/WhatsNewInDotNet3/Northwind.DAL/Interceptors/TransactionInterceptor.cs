﻿using System.Data.Common;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Northwind.Dal.Interceptors
{
    public class TransactionInterceptor: DbTransactionInterceptor
    {
        public override InterceptionResult<DbTransaction> TransactionStarting(DbConnection connection, TransactionStartingEventData eventData,
            InterceptionResult<DbTransaction> result)
        {
            return base.TransactionStarting(connection, eventData, result);
        }
    }
}
