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
    
    public partial class FinalBillDetail
    {
        public int FBillDetailId { get; set; }
        public Nullable<int> fkFinalBillId { get; set; }
        public string BillNo { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<double> DraftAmt { get; set; }
        public Nullable<double> STaxAmt { get; set; }
        public Nullable<double> ECAmt { get; set; }
        public Nullable<double> Per { get; set; }
        public Nullable<double> Commission { get; set; }
        public string Others { get; set; }
        public Nullable<double> Tax { get; set; }
        public Nullable<double> SwachhTax { get; set; }
        public Nullable<double> RoundOff { get; set; }
    
        public virtual FinalBill FinalBill { get; set; }
    }
}
