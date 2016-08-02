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
    
    public partial class MstCourier
    {
        public int CourierMasterId { get; set; }
        public string CourierName { get; set; }
        public string ShortName { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<int> fkBranchId { get; set; }
        public string Address { get; set; }
        public Nullable<int> fkCityId { get; set; }
        public string OfficePhone { get; set; }
        public string Fax { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual MstBranch MstBranch { get; set; }
        public virtual MstCity MstCity { get; set; }
    }
}
