using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class DBConnection : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        internal WMAPOSEntities context = new WMAPOSEntities();

    }
}
