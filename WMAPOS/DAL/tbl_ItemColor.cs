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
    
    public partial class tbl_ItemColor
    {
        public string CompanyCode { get; set; }
        public string ItemColorCode { get; set; }
        public string ItemColorNameAr { get; set; }
        public string ItemColorNameEn { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
    
        public virtual tbl_Company tbl_Company { get; set; }
    }
}
