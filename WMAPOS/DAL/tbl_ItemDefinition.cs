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
    
    public partial class tbl_ItemDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ItemDefinition()
        {
            this.tbl_Barcodes = new HashSet<tbl_Barcodes>();
        }
    
        public string CompanyCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemService { get; set; }
        public string ItemNameAr { get; set; }
        public string ItemNameEn { get; set; }
        public string ItemGroupCode { get; set; }
        public string ItemTypeCode { get; set; }
        public string ItemCategoryCode { get; set; }
        public string ItemUnitCode { get; set; }
        public Nullable<decimal> MaxDiscountRatio { get; set; }
        public Nullable<decimal> MinQuantity { get; set; }
        public Nullable<decimal> MaxQuantity { get; set; }
        public Nullable<decimal> ReOrderQuantity { get; set; }
        public string ItemVendorCode { get; set; }
        public string OriginalItemCode { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> LastUpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Barcodes> tbl_Barcodes { get; set; }
        public virtual tbl_Company tbl_Company { get; set; }
        public virtual tbl_ItemCategory tbl_ItemCategory { get; set; }
        public virtual tbl_ItemGroup tbl_ItemGroup { get; set; }
        public virtual tbl_ItemType tbl_ItemType { get; set; }
        public virtual tbl_ItemUnit tbl_ItemUnit { get; set; }
    }
}
