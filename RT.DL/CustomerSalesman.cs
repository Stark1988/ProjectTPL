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
    
    public partial class CustomerSalesman
    {
        public int SalesmanId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public string SalesmanName { get; set; }
        public string ContactNumber { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}