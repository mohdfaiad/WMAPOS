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
    
    public partial class tbl_CashBank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CashBank()
        {
            this.tbl_PosClose = new HashSet<tbl_PosClose>();
            this.tbl_PosClose1 = new HashSet<tbl_PosClose>();
        }
    
        public string CompanyCode { get; set; }
        public string CB_Code { get; set; }
        public string CB_Type { get; set; }
        public string CB_NameA { get; set; }
        public string CB_NameE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PosClose> tbl_PosClose { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PosClose> tbl_PosClose1 { get; set; }
    }
}
