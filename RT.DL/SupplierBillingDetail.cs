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
    
    public partial class SupplierBillingDetail
    {
        public int SupplierBillingDetailId { get; set; }
        public Nullable<int> fkSupplierId { get; set; }
        public Nullable<bool> IsStopMonthlyBilling { get; set; }
        public Nullable<int> BillFrequency { get; set; }
        public string SupplierCompany { get; set; }
        public string ITPanNumber { get; set; }
    
        public virtual Supplier Supplier { get; set; }
    }
}
