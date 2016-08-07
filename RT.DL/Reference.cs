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
    
    public partial class Reference
    {
        public Reference()
        {
            this.Parties = new HashSet<Party>();
        }
    
        public int ReferenceId { get; set; }
        public string ReferenceType { get; set; }
        public string TourBy { get; set; }
        public Nullable<System.DateTime> TourDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Party> Parties { get; set; }
    }
}
