//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RT.DL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupplierSisterConcern
    {
        public int SisterConcernId { get; set; }
        public Nullable<int> fkSupplierId { get; set; }
        public string SisterConcernDescription { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> fkSupplierSisterConcernId { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual Supplier Supplier1 { get; set; }
    }
}
