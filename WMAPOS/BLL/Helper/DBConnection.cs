using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using DAL;


namespace BLL.Helper
{
    public class DbConnection : IDisposable
    {
        protected WMAPOSEntities Context;
        //public ILogger Logger => new SystemErrorLog(Context.Database.Connection.ConnectionString);
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context?.Dispose();
                    Context = null;
                    // called via myClass.Dispose(). 
                    // OK to use any private object references
                }
                _disposed = true;
            }
        }

        public void Dispose() // Implement IDisposable
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DbConnection() // the finalizer
        {
            Dispose(false);
        }

    }
}