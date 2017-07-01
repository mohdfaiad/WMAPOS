using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Sys : IDisposable
    {
        private readonly Lazy<Company> _lCompany;

        public Sys(tbl_Users user, string formName, string formType)
        {
            _lCompany = new Lazy<Company>(() => new Company(user, formName, "CompanyCode"));
        }

        public Company Company => _lCompany.Value;

        public void Dispose()
        {
            
        }
    }
}
