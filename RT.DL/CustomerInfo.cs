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
    
    public partial class CustomerInfo
    {
        public int CustomerInfoId { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public string Abuse { get; set; }
        public string OtherAgent { get; set; }
        public string MBoy1 { get; set; }
        public string MBoy2 { get; set; }
        public string MBoy3 { get; set; }
        public string WorkNature { get; set; }
        public string VisitFrequency { get; set; }
        public string AdmitType { get; set; }
        public string RapportType { get; set; }
        public string DealingType { get; set; }
        public string PaymentHabbit { get; set; }
        public string GRHabbit { get; set; }
        public string TransportReference { get; set; }
        public string Hotel { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public string Restriction { get; set; }
        public string Remarks { get; set; }
        public string DirectDealing { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
