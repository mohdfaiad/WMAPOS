using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Transactions;
using Configuration;
using DAL;


namespace BLL.Helper
{
    /// <summary>
    ///  Created By A.Galal
    /// كلاس رئيسية تستخدم فى الحفظ والاضافة والتعديل والتعامل مع قاعدة البيانات من خلالها 
    /// </summary>
    /// <typeparam name="T">الجدول المراد استخدامة</typeparam>
    public class UseData<T> : DbConnection where T : class, new()
    {
        #region definitions
        public delegate void OnBeforeSave(T sender, WMAERPEntities context, EventUseData e);
        public delegate void OnAfterSave(T sender, WMAERPEntities context, EventBase e);

        public delegate void OnBeforeDelete(T sender, WMAERPEntities context, EventUseData e);
        public delegate void OnAfterDelete(T sender, WMAERPEntities context, EventBase e);

        public virtual event OnBeforeSave BeforeSave;
        public virtual event OnAfterSave AfterSave;

        public virtual event OnBeforeDelete BeforeDelete;
        public virtual event OnAfterDelete AfterDelete;

        private readonly tbl_Users _user;
        private readonly string _formType;
        private readonly string _formName;


        #endregion
        #region constractorspublic ResourceKeys LastKeysErrorMsg { get; set; }
        public WMAERPEntities Db { get; set; }
        public ResourceKeys LastKeysErrorMsg { get; set; }
        public ObjectContext ContextDb => ((IObjectContextAdapter)Db).ObjectContext;

        public UseData()
        {
            Context = new WMAERPEntities();
            if (Context.Database.Connection.State != ConnectionState.Open)
                Context.Database.Connection.Open();
            Db = Context;
            LastKeysErrorMsg = new ResourceKeys();
        }

        public string MasterKey { get; set; }
        public T Current { get; set; }
        public UseData(tbl_Users user, string formName, string masterKey = "", T currentObj = null, ResourceKeys lastKeysErrorMsg = null, string formType = null)
            : this()
        {
            _formType = formType;
            _formName = formName;
            _user = user;
            LastKeysErrorMsg = lastKeysErrorMsg ?? new ResourceKeys();
            if (masterKey != "")
            {
                MasterKey = masterKey;
            }
            else if (GetKeys.Length > 0)
            {
                MasterKey = GetKeys[0];
            }
            Current = currentObj ?? new T();
        }
        #endregion

        #region Movement 
        public virtual T FindByMove(EditFormActionType actionType)
        {
            switch (actionType)
            {
                case EditFormActionType.First:
                    return First();
                case EditFormActionType.Last:
                    return Last();
                case EditFormActionType.Next:
                    return Next();
                case EditFormActionType.Previous:
                    return Previous();
                case EditFormActionType.Edit:
                    return Find();
                case EditFormActionType.New:
                    var o = new T();
                    if (GetKeys.Contains("CompanyCode") && !(Current is tbl_Company))
                        o.SetValue("CompanyCode", Current.GetValue("CompanyCode"));
                    if (GetKeys.Contains("BranchCode") && !(Current is tbl_Branch))
                        o.SetValue("BranchCode", Current.GetValue("BranchCode"));
                    return o;
            }

            return new T();
        }

        public virtual T First()
        {
            var obj = Current;
            string tableName = typeof(T).Name;
            string keyName = MasterKey.IsNullOrEmpty() ? GetKeys[0] : MasterKey;
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append($"Select Top 1 * from {tableName} Where 1=1 ");

            if (GetKeys.Length > 4 && obj.GetType().GetProperties().Any(p => p.Name.Equals("PkId")) && GetKeys.Contains("TrxTypeId") && GetKeys.Contains("CompanyCode") && GetKeys.Contains("BranchCode"))
            {
                sqlStr.Append($" And CompanyCode ='{obj.GetValue("CompanyCode")}'");
                sqlStr.Append($" And BranchCode ='{obj.GetValue("BranchCode")}'");
                sqlStr.Append(" Order by PkId");
            }
            else if (GetKeys.Contains("CompanyCode"))
            {
                if (GetKeys.Length > 1 && GetKeys.Length <= 4)
                {
                    for (int i = 1; i < GetKeys.Length; i++)
                    {
                        sqlStr.Append($" And {GetKeys[i]} ='{obj.GetValue(GetKeys[i])}'");
                    }
                }
                sqlStr.Append($" Order by {keyName}");
            }

            T entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).FirstOrDefault() ?? new T();
            return entity;
        }
        public virtual T Next()
        {
            var obj = Current;
            if (obj == null)
            {
                return null;
            }

            T entity;//= new T();
            string tableName = typeof(T).Name;
            string keyName = MasterKey.IsNullOrEmpty() ? GetKeys[0] : MasterKey;
            string keyValue = obj.GetValue(GetKeys[0]).IsNull();

            StringBuilder sqlStr = new StringBuilder();
            StringBuilder sqlWhere = new StringBuilder();
            sqlStr.Append($"Select * from {tableName} Where 1=1 ");

            if (GetKeys.Length > 4 && obj.GetType().GetProperties().Any(p => p.Name.Equals("PkId")) && GetKeys.Contains("TrxTypeId") && GetKeys.Contains("CompanyCode") && GetKeys.Contains("BranchCode"))
            {
                string s =
                    $"Select * From {tableName} Where " +
                    $"TrxTypeId='{obj.GetValue("TrxTypeId")}' And " +
                    $"YearId='{obj.GetValue("YearId")}' And " +
                    $"PeriodId='{obj.GetValue("PeriodId")}' And " +
                    $"CompanyCode='{obj.GetValue("CompanyCode")}' And " +
                    $"BranchCode='{obj.GetValue("BranchCode")}'";
                if (obj.GetValue("TrxNo") != null)
                {
                    s += $"And TrxNo = '{obj.GetValue("TrxNo")}'";
                }

                keyValue = Context.Set<T>().SqlQuery(s).FirstOrDefault().GetValue("PkId").IsNull(); //obj.GetValue(GetKeys[0]).IsNull();
                sqlWhere.Append($" And CompanyCode ='{obj.GetValue("CompanyCode")}'");
                sqlWhere.Append($" And BranchCode ='{obj.GetValue("BranchCode")}'");
                if (obj.GetValue("TrxNo") != null)
                    sqlStr.Append($"{sqlWhere} And PkId=(Select Min(PkId) from {tableName} Where PkId > '{keyValue}' {sqlWhere})");
                entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).LastOrDefault() ?? obj;
            }
            else if (GetKeys.Contains("CompanyCode"))
            {
                if (GetKeys.Length > 1 && GetKeys.Length <= 4)
                {
                    for (int i = 1; i < GetKeys.Length; i++)
                    {
                        sqlWhere.Append($" And {GetKeys[i]} ='{obj.GetValue(GetKeys[i])}'");
                    }
                }
                if (keyValue != "")
                    sqlStr.Append($"{sqlWhere} And {keyName}=(Select Min({keyName}) from {tableName} Where {keyName} > '{keyValue}' {sqlWhere})");

                entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).LastOrDefault();
            }
            else
            {
                if (keyValue != "")
                    sqlStr.Append($"{sqlWhere} And {keyName}=(Select Min({keyName}) from {tableName} Where {keyName} > '{keyValue}' {sqlWhere})");
                entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).LastOrDefault();
            }

            return entity ?? obj;
        }
        public virtual T Previous()
        {
            var obj = Current;
            if (obj == null)
            {
                return null;
            }
            T entity;
            string tableName = typeof(T).Name;
            string keyName = MasterKey.IsNullOrEmpty() ? GetKeys[0] : MasterKey;
            string keyValue = obj.GetValue(GetKeys[0]).IsNull();

            StringBuilder sqlStr = new StringBuilder();
            StringBuilder sqlWhere = new StringBuilder();
            sqlStr.Append($"Select * from {tableName} Where 1=1 ");

            if (GetKeys.Length > 4 && obj.GetType().GetProperties().Any(p => p.Name.Equals("PkId")) && GetKeys.Contains("TrxTypeId") && GetKeys.Contains("CompanyCode") && GetKeys.Contains("BranchCode"))
            {
                string s =
                    $"Select * From {tableName} Where " +
                    $"TrxTypeId='{obj.GetValue("TrxTypeId")}' And " +
                    $"YearId='{obj.GetValue("YearId")}' And " +
                    $"PeriodId='{obj.GetValue("PeriodId")}' And " +
                    $"CompanyCode='{obj.GetValue("CompanyCode")}' And " +
                    $"BranchCode='{obj.GetValue("BranchCode")}'";
                if (obj.GetValue("TrxNo") != null)
                {
                    s += $"And TrxNo = '{obj.GetValue("TrxNo")}'";
                }
                keyValue = Context.Set<T>().SqlQuery(s).FirstOrDefault().GetValue("PkId").IsNull(); //obj.GetValue(GetKeys[0]).IsNull();


                sqlWhere.Append($" And CompanyCode ='{obj.GetValue("CompanyCode")}'");
                sqlWhere.Append($" And BranchCode ='{obj.GetValue("BranchCode")}'");

                if (obj.GetValue("TrxNo") != null)
                    sqlStr.Append($"{sqlWhere} And PkId=(Select Max(PkId) from {tableName} Where PkId < '{keyValue}' {sqlWhere})");
                entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).FirstOrDefault() ?? obj;
            }
            else if (GetKeys.Contains("CompanyCode"))
            {
                if (GetKeys.Length > 1 && GetKeys.Length <= 4)
                {
                    for (int i = 1; i < GetKeys.Length; i++)
                    {
                        sqlWhere.Append($" And {GetKeys[i]} ='{obj.GetValue(GetKeys[i])}'");
                    }
                }
                if (keyValue != "")
                    sqlStr.Append($"{sqlWhere} And {keyName}=(Select Max({keyName}) from {tableName} Where {keyName} < '{keyValue}' {sqlWhere})");

                entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).FirstOrDefault();
            }
            else
            {
                if (keyValue != "")
                    sqlStr.Append($"{sqlWhere} And {keyName}=(Select Max({keyName}) from {tableName} Where {keyName} < '{keyValue}' {sqlWhere})");

                entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).FirstOrDefault();
            }
            return entity ?? obj;
        }
        public virtual T Last()
        {
            var obj = Current;
            string tableName = typeof(T).Name;
            string keyName = MasterKey.IsNullOrEmpty() ? GetKeys[0] : MasterKey;
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append($"Select Top 1 * from {tableName} Where 1=1 ");

            if (GetKeys.Length > 4 && obj.GetType().GetProperties().Any(p => p.Name.Equals("PkId")) && GetKeys.Contains("TrxTypeId") && GetKeys.Contains("CompanyCode") && GetKeys.Contains("BranchCode"))
            {
                sqlStr.Append($" And CompanyCode ='{obj.GetValue("CompanyCode")}'");
                sqlStr.Append($" And BranchCode ='{obj.GetValue("BranchCode")}'");
                sqlStr.Append(" Order by PkId Desc");
            }
            else if (GetKeys.Contains("CompanyCode"))
            {
                if (GetKeys.Length > 1 && GetKeys.Length <= 4)
                {
                    for (int i = 1; i < GetKeys.Length; i++)
                    {
                        sqlStr.Append($" And {GetKeys[i]} ='{obj.GetValue(GetKeys[i])}'");
                    }
                }
                sqlStr.Append($" Order by {keyName} Desc");
            }
            else
            {
                sqlStr.Append($" Order by {keyName} Desc");

            }
            T entity = Context.Set<T>().SqlQuery(sqlStr.ToString()).FirstOrDefault() ?? new T();

            return entity;
        }
        public virtual T AddNew()
        {
            return new T();
        }
        #endregion
        #region Helpers
        public virtual bool Exists(T entity)
        {
            return Find(entity) != null;
        }
        public virtual T Find(T entity = null)
        {
            if (entity == null)
            {
                entity = Current;
            }
            var keyvalues = new List<object>();
            GetKeys.ToList().ForEach(key =>
            {
                //entity.GetType().GetProperty(key).GetValue(entity)
                keyvalues.Add(entity.GetValue(key));
            });
            return Context.Set<T>().Find(keyvalues.ToArray());
        }
        public virtual List<T> List(Expression<Func<T, bool>> wherecond = null)
        {
            return wherecond == null ? Context.Set<T>().ToList() : Context.Set<T>().Where(wherecond).ToList();
        }
        //public virtual T this[params object[] id] => FindByKeys(id);
        //public virtual T this[int index] => List()[index];

        public virtual T FindByKeys(params object[] id)
        {
            return Context.Set<T>().Find(id);
        }
        public virtual T FirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return Context.Set<T>().FirstOrDefault(expression);
        }
        public virtual T FirstOrDefault()
        {
            return Context.Set<T>().FirstOrDefault();
        }
        public virtual string[] GetKeys
        {
            get
            {
                //var objectContext = ((IObjectContextAdapter)Context).ObjectContext;
                return ContextDb.CreateObjectSet<T>().EntitySet.ElementType.KeyMembers.Select(key => key.Name).ToArray();
            }
        }

        #endregion
        #region Transaction Save , Delete 
        public virtual TransactionResult Save(T entity, bool edit, string headerkeyvalue = null, bool useLog = true)
        {
            if (Context.Database.Connection.State != ConnectionState.Open)
                Context.Database.Connection.Open();

            TransactionScope scope = new TransactionScope();
            try
            {
                T o;
                if (Exists(entity))
                {
                    if (!edit) return TransactionResult.IsExists;
                    o = Find(entity);

                    if (entity.GetType().GetProperties().Any(p => p.Name.Equals("CreatedBy", StringComparison.OrdinalIgnoreCase)))
                    {
                        entity.SetValue("CreatedBy", o.GetValue("CreatedBy"));
                        entity.SetValue("CreatedAt", o.GetValue("CreatedAt"));
                        entity.SetValue("UpdatedBy", o.GetValue("UpdatedBy"));
                        entity.SetValue("UpdatedAt", o.GetValue("UpdatedAt"));
                    }

                    Context.Entry(o).CurrentValues.SetValues(entity);

                    if (Context.Entry(o).State == EntityState.Modified && entity.GetType().GetProperties().Any(p => p.Name.Equals("UpdatedBy", StringComparison.OrdinalIgnoreCase)))
                    {
                        //o.SetValue("UpdatedBy", _user.UserId.ToInt());
                        o.SetValue("UpdatedAt", DateTime.Now);
                    }

                }
                else
                {

                    if (entity.GetType().GetProperties().Any(p => p.Name.Equals("CreatedBy", StringComparison.OrdinalIgnoreCase)))
                    {
                        //entity.SetValue("CreatedBy", _user.UserId.ToInt());
                        entity.SetValue("CreatedAt", DateTime.Now);
                    }
                    Context.Entry(entity).State = EntityState.Added;
                    o = entity;
                }
                if (BeforeSave != null)
                {
                    var eventUseData = new EventUseData();
                    BeforeSave.Invoke(o, Context, eventUseData);
                    if (eventUseData.Cancel)
                    {
                        scope.Dispose();
                        return eventUseData.Message;
                    }
                }
                //if (_user.FollowUp && useLog)
                //{
                //    Context.LogEntity(o, _user, GetKeys[0], _formType, headerkeyvalue, headerkeyvalue);
                //}
                Context.SaveChanges();
                scope.Complete();
                if (AfterSave != null)
                {
                    var eventMessage = new EventBase { Message = TransactionResult.None };
                    AfterSave.Invoke(o, Context, eventMessage);
                    if (eventMessage.Message != TransactionResult.None)
                    {
                        return eventMessage.Message;
                    }
                }

                return TransactionResult.SaveSuccess;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                scope.Dispose();
                Context.Database.Connection.Close();
                //Logger.LogSystemError(_user.UserId.ToString(), ex);
                return TransactionResult.SaveFailed;
            }
            finally
            {
                scope.Dispose();
            }
        }

        /// <summary>
        /// حفظ مجموعة من السطور 
        /// </summary>
        /// <param name="wherecond">الشرط الاساسى لجلب السطور</param>
        /// <param name="currentList">مجموعة السطور المراد حفظها</param>
        /// <param name="headerkeyvalue">الرمز المستخدم فى تتبع المستخدمين</param>
        /// <param name="useLog">امكانية تطبيق تتبع المستخدم فى هذه العملية </param>
        /// <returns>نتيجة عملية الحفظ </returns>
        public virtual TransactionResult SaveList(Expression<Func<T, bool>> wherecond, List<T> currentList, string headerkeyvalue = null, bool useLog = true)
        {
            if (Context.Database.Connection.State != ConnectionState.Open)
                Context.Database.Connection.Open();

            #region Create Collection from Rows Updated
            var updateList = new List<T>();
            foreach (T row in currentList)
            {
                if (Exists(row))
                {
                    var obj = Find(row);
                    Context.Entry(obj).CurrentValues.SetValues(row);
                    if (Context.Entry(obj).State == EntityState.Modified)
                    {
                        Context.Entry(obj).State = EntityState.Unchanged;
                        updateList.Add(row);
                    }
                }
            }
            #endregion

            #region Create Collection from Rows Inserted
            var inserList = new List<T>();
            foreach (T row in currentList)
            {
                if (!Exists(row))
                {
                    inserList.Add(row);
                }
            }
            #endregion

            #region Create Collection from Rows Deleted
            var all = Context.Set<T>().Where(wherecond).ToList();
            var existsList = new List<T>();
            foreach (var row in currentList)
            {
                if (Exists(row))
                    existsList.Add(Find(row));
            }
            var deleteList = all.Except(existsList).ToList();
            #endregion

            #region Save , Update , Delete
            try
            {

                foreach (var row in inserList)
                {
                    var msg = Save(row, false, headerkeyvalue, useLog);
                    if (msg != TransactionResult.SaveSuccess)
                        return msg;
                }

                foreach (var row in updateList)
                {
                    var msg = Save(row, true, headerkeyvalue, useLog);
                    if (msg != TransactionResult.SaveSuccess)
                        return msg;
                }


                foreach (var row in deleteList)
                {
                    var msg = Delete(row, headerkeyvalue, useLog);
                    if (msg != TransactionResult.DeleteSuccess)
                        return msg;
                }

                return TransactionResult.SaveSuccess;
            }
            catch (Exception e)
            {
                HandleException(e);
                return TransactionResult.SaveFailed;
            }
            #endregion
        }

        public virtual TransactionResult Delete(T entity, string headerkeyvalue = null, bool useLog = true)
        {
            if (Context.Database.Connection.State != ConnectionState.Open)
                Context.Database.Connection.Open();

            TransactionScope scope = new TransactionScope();
            try
            {
                var keyvalue = entity.GetValue(MasterKey.IsNullOrEmpty() ? GetKeys[0] : MasterKey);
                var row = Find(entity);
                entity = row;Context.Entry(entity).State = EntityState.Deleted;
                if (BeforeDelete != null)
                {
                    var eventUseData = new EventUseData();
                    BeforeDelete.Invoke(entity, Context, eventUseData);
                    if (eventUseData.Cancel)
                    {
                        scope.Dispose();
                        return eventUseData.Message;
                    }
                }

                //if (_user.FollowUp && useLog)
                //{
                //    Context.LogEntity(entity, _user, GetKeys[0], _formType, headerkeyvalue, headerkeyvalue);
                //}
                Context.SaveChanges();

                //var lkpWebControllers = Context.lkp_WebControllers.FirstOrDefault(c => c.formType == _formType); //c.ControllerName.Equals(_controllername, StringComparison.OrdinalIgnoreCase) || 
                //if (lkpWebControllers != null)
                //{
                //    int formType = lkpWebControllers.formType;
                //    RemoveAttachments(formType, keyvalue.ToString());
                //}

                scope.Complete();
                if (AfterDelete != null)
                {
                    EventBase eventMessage = new EventBase { Message = TransactionResult.None };
                    AfterDelete.Invoke(entity, Context, eventMessage);
                    if (eventMessage.Message != TransactionResult.None)
                    {
                        return eventMessage.Message;
                    }
                }
                return TransactionResult.DeleteSuccess;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                scope.Dispose();
                Context.Database.Connection.Close();
                //Logger.LogSystemError(_user.UserId.ToString(), ex);
                return TransactionResult.DeleteFailed;
            }
            finally
            {
                scope.Dispose();
            }
        }
        private void HandleException(Exception ex)
        {
            var sqlException = ex.GetBaseException() as SqlException;
            if (sqlException != null && sqlException.Errors.Count > 0)
            {
                switch (sqlException.Errors[0].Number)
                {
                    case 4060: LastKeysErrorMsg.Add("ErrorSQL4060"); break;// Invalid Database 
                    case 18456: LastKeysErrorMsg.Add("ErrorSQL18456"); break;// Login Failed
                    case 2627: LastKeysErrorMsg.Add("ErrorSQL2627"); break; // Unique Index/ Primary key Violation/ Constriant Violation 
                    case 2601: LastKeysErrorMsg.Add("ErrorSQL2601"); break;// Unique Index/Constriant Violation 
                    case 547: LastKeysErrorMsg.Add("ErrorSQL547"); break; // Foreign Key violation
                    default: LastKeysErrorMsg.Add($"ErrorSQL{sqlException.Errors[0].Number}"); break;
                }
            }
            else
                LastKeysErrorMsg.Add(ex.Message);

        }
        public virtual TransactionResult DeleteByKeys(params object[] id)
        {
            T entity = Context.Set<T>().Find(id);
            return Delete(entity);
        }
        /*
        public void RemoveAttachments(int formType, string key1)
        {
            Context.tbl_Attachments.Where(att => att.formType == formType && att.Key1 == key1)
                .ToList()
                .ForEach(row =>
                {
                    Context.Entry(row).State = EntityState.Deleted;
                    if (System.IO.File.Exists(row.FullPath))
                        System.IO.File.Delete(row.FullPath);
                });

        }
        */
        #endregion
    }

    #region Event classes
    public class EventBase
    {
        public TransactionResult Message { get; set; }
    }
    public class EventUseData : EventBase
    {
        public EventUseData()
        {
            Cancel = false;
        }
        public bool Cancel { get; set; }

    }
    #endregion
}