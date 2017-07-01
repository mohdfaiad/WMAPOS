using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using BLL.Helper;
using DAL;

namespace BLL
{
    public class Company : MasterData<tbl_Company>
    {
        public Company(tbl_Users user = null, string formName = "", string masterKey = "") : base(user, formName, masterKey)
        {

        }

        public List<tbl_Branch> GetBranches(string companyCode)
        {
            List<tbl_Branch> branches;
            using (var useData = new UseData<tbl_Branch>(User, ""))
            {
                //useData.Db.Configuration.LazyLoadingEnabled = false;
                //branches = useData.List(b => b.CompanyCode == companyCode).ToList();
                return useData.Db.tbl_Branch.Where(b => b.CompanyCode == companyCode).ToList();

                //useData.Db.Configuration.LazyLoadingEnabled = false;
            }
            //return branches;
        }

        public TransactionResult Delete(tbl_Company company, List<tbl_Branch> branches)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    TransactionResult result;
                    using (var useData = new UseData<tbl_Branch>(User, ""))
                    {
                        foreach (var tblBranch in branches)
                        {
                            result = useData.Delete(tblBranch, useLog: false);
                            if (result != TransactionResult.DeleteSuccess)
                                return result;
                        }
                    }
                    using (var useData = new UseData<tbl_Company>(User, ""))
                    {
                        result = useData.Delete(company, useLog: false);
                        if (result != TransactionResult.DeleteSuccess)
                            return result;
                    }
                    
                    scope.Complete();
                    return TransactionResult.SaveSuccess;
                }
                catch (Exception)
                {
                    return TransactionResult.SaveFailed;
                }
                finally
                {
                    scope.Dispose();
                }
            }
        }

        public TransactionResult Save(tbl_Company company, List<tbl_Branch> branches)
        {
            using (var scope = new TransactionScope())
            {
                try
                {
                    TransactionResult result;
                    using (var useData = new UseData<tbl_Company>(User, ""))
                    {
                        result = useData.Save(company, true, useLog: false);
                        if (result != TransactionResult.SaveSuccess)
                            return result;
                    }
                    using (var useData = new UseData<tbl_Branch>(User, ""))
                    {
                        result = useData.SaveList(b => b.CompanyCode == company.CompanyCode, branches, useLog: false);
                        if (result != TransactionResult.SaveSuccess)
                            return result;
                    }
                    scope.Complete();
                    return TransactionResult.SaveSuccess;
                }
                catch (Exception)
                {
                    return TransactionResult.SaveFailed;
                }
                finally
                {
                    scope.Dispose();
                }
            }
        }

    }
}
