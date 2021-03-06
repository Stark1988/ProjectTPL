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
    
    public partial class ReturnDraftCheque
    {
        public ReturnDraftCheque()
        {
            this.ReturnDraftChequeBillDetails = new HashSet<ReturnDraftChequeBillDetail>();
        }
    
        public int ReturnDraftChequeId { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public string DraftOrCheque { get; set; }
        public Nullable<int> fkCustomerId { get; set; }
        public Nullable<int> fkSupplierId { get; set; }
        public string Documents { get; set; }
        public string Enclosed { get; set; }
        public string Type { get; set; }
        public string PrintLetter { get; set; }
        public Nullable<int> NoOfCopies { get; set; }
        public string DDChequeNumber { get; set; }
        public Nullable<System.DateTime> DDChequeDate { get; set; }
        public string DrawnOn { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Reason { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ReturnDraftChequeBillDetail> ReturnDraftChequeBillDetails { get; set; }
    }
}
