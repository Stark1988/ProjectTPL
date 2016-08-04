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
    
    public partial class MstSubAgent
    {
        public MstSubAgent()
        {
            this.Customers = new HashSet<Customer>();
        }
    
        public int SubAgentId { get; set; }
        public string SubAgentName { get; set; }
        public string Address { get; set; }
        public Nullable<int> fkCityId { get; set; }
        public string OfficePhone { get; set; }
        public string Fax { get; set; }
        public string ResPhone { get; set; }
        public string MobileNumber { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual MstCity MstCity { get; set; }
    }
}