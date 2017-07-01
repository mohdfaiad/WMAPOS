//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_PosClose
    {
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public string TrxNo { get; set; }
        public Nullable<System.DateTime> TrxDate { get; set; }
        public string TrxStatus { get; set; }
        public string TrxDescA { get; set; }
        public string TrxDescE { get; set; }
        public string POSCode { get; set; }
        public string CashCode { get; set; }
        public string BankCode { get; set; }
        public Nullable<decimal> Cash { get; set; }
        public Nullable<decimal> CreditCard { get; set; }
        public Nullable<decimal> ATM { get; set; }
        public Nullable<decimal> Credit { get; set; }
        public Nullable<decimal> Checks { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string POSShift { get; set; }
        public string OperatorCode { get; set; }
        public Nullable<decimal> ActualCash { get; set; }
        public Nullable<decimal> OldOpenBalance { get; set; }
        public Nullable<decimal> NewOpenBalance { get; set; }
        public string MainCashCode { get; set; }
    
        public virtual tbl_CashBank tbl_CashBank { get; set; }
        public virtual tbl_CashBank tbl_CashBank1 { get; set; }
        public virtual tbl_operators tbl_operators { get; set; }
        public virtual tbl_POS_Definition tbl_POS_Definition { get; set; }
    }
}