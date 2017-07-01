using System;
using System.Collections.Generic;
using Configuration;
using DAL;

namespace BLL.Helper
{
    public abstract class MasterData<T> : IDisposable where T : class, new()
    {
        #region Properties
        protected tbl_Users User { get; set; }
        protected string BranchCode { get; set; }
        protected string MasterKey { get; set; }
        protected string CompanyCode { get; set; }
        protected string UserId { get; set; }
        protected string FormType { get; set; }
        protected string FormName { get; set; }
        public ResourceKeys LastKeysInfoMsg { get; } = new ResourceKeys();
        public ResourceKeys LastKeysErrorMsg { get; } = new ResourceKeys();

        #endregion
        protected MasterData(tbl_Users user, string formName = "", string masterKey = "", string formType = "")
        {
            BranchCode = user.BranchCode;
            CompanyCode = user.CompanyCode;
            UserId = user.UserID;
            FormType = formType;
            MasterKey = masterKey;
            FormName = formName;
            User = user;
        }

        public virtual List<T> ListByCompanyCode(string companyCode)
        {
            using (var useData = new UseData<T>())
            {
                return typeof(T) == typeof(tbl_Company)
                    ? useData.List()
                    : useData.List(x => x.GetValue("CompanyCode") != companyCode);
            }
        }
        public virtual T New(object obj)
        {
            return ActionMove(obj, EditFormActionType.New);
        }

        //public virtual TransactionResult Delete(object obj)
        //{
        //    T row = obj as T;
        //    using (var useData = new UseData<T>(User, FormName, MasterKey, row))
        //    {
        //        return useData.Delete(row);
        //    }
        //}
        public virtual T Next(object obj)
        {
            return ActionMove(obj, EditFormActionType.Next);
        }

        public virtual T Last(object obj)
        {
            return ActionMove(obj, EditFormActionType.Last);
        }
        public virtual T First(object obj)
        {
            return ActionMove(obj, EditFormActionType.First);
        }
        public virtual T Previous(object obj)
        {
            return ActionMove(obj, EditFormActionType.Previous);
        }

        private T ActionMove(object sender, EditFormActionType actionType)
        {
            T row = sender as T;
            using (var useData = new UseData<T>(User, FormName, MasterKey, row))
            {
                return useData.FindByMove(actionType);
            }
        }
        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
