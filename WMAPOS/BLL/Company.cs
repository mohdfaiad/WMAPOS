using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Company : DBConnection
    {
        
        public void DeleteCompany(string companyCode)
        {
            try
            {
                if (context.Database.Connection.State != System.Data.ConnectionState.Open) context.Database.Connection.Open();
                tbl_Company cObject = context.tbl_Company.FirstOrDefault(c => c.CompanyCode == companyCode);
                context.SaveChanges();
            }
            catch
            {

            }
            finally
            {
                context.Database.Connection.Close();
            }
        }
        

        public void NewCompany(string CompanyCode, string CompanyNameAr, string CompanyNameEn)
        {
            try
            {
                if (context.Database.Connection.State != System.Data.ConnectionState.Open) context.Database.Connection.Open();
                tbl_Company cObj = new tbl_Company()
                {
                    CompanyCode=CompanyCode
                    ,
                    CompanyNameAr = CompanyNameAr
                    ,
                    CompanyNameEn = CompanyNameEn
                };
                context.tbl_Company.Add(cObj);
                string CompanyID = cObj.CompanyCode;
                context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                context.Database.Connection.Close();
            }
        }
    }
}
