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
    
    public partial class CustomerAccountant
    {
        public int CustomerAccountantId { get; set; }
        public Nullable<int> fkCustomerInfoId { get; set; }
        public string AccountantName { get; set; }
        public string ContactNumber { get; set; }
    
        public virtual CustomerInfo CustomerInfo { get; set; }
    }
}
