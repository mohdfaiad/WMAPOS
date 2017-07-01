using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{

    public enum FormMode
    {
        Add = 0,
        Edit = 1
    }

    public enum SystemLanguages
    {
        Arabic = 1,
        English = 2
    }
    [Flags]
    public enum EditFormActionType
    {
        First,
        Last,
        Next,
        Previous,
        Edit,
        New,
        Save,
        SaveAndNew,
        SaveAndClose,
        Delete
    }

    public enum TransactionResult
    {
        None,
        SaveSuccess, // when insert or update success
        SaveFailed, // when inset or update error occured
        DeleteSuccess, // when delete success
        DeleteFailed, // when delete faild
        ErrorOccured, // when an error occured for any reason
        IsExists, // save record has the same unique key 
        ApproveSuccess, // when approve success
        UnApproveSuccess, // when unapprove success
        ApproveFailed, // when approve error occured
        UnApproveFailed, // when unapprove error occured
        Authenticated, // when user login success
        NotAuthenticated, // when user login failed
        ReferenceToAnotherTable, // when user login failed
        Balanced,
        UnBalanced,
        IsDuplicateDetailsData // when user create duplicate data in details
    }

}
