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
    
    public partial class tbl_operators
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_operators()
        {
            this.tbl_PosClose = new HashSet<tbl_PosClose>();
        }
    
        public string CompanyCode { get; set; }
        public string OperatorCode { get; set; }
        public string OperatorNameAr { get; set; }
        public string OperatorNameEn { get; set; }
        public string UserID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
    
        public virtual tbl_Company tbl_Company { get; set; }
        public virtual tbl_Users tbl_Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PosClose> tbl_PosClose { get; set; }
    }
}
