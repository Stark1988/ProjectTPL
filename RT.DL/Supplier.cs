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
    
    public partial class Supplier
    {
        public Supplier()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.SupplierBillingDetails = new HashSet<SupplierBillingDetail>();
            this.SupplierContactInfoes = new HashSet<SupplierContactInfo>();
            this.SupplierProprietors = new HashSet<SupplierProprietor>();
            this.SupplierSisterConcerns = new HashSet<SupplierSisterConcern>();
            this.SaleLREntries = new HashSet<SaleLREntry>();
            this.Ledgers = new HashSet<Ledger>();
            this.DiscountEntries = new HashSet<DiscountEntry>();
            this.GRNDebitNotes = new HashSet<GRNDebitNote>();
            this.CollectionEntries = new HashSet<CollectionEntry>();
            this.ReturnDraftCheques = new HashSet<ReturnDraftCheque>();
            this.SupplierSisterConcerns1 = new HashSet<SupplierSisterConcern>();
            this.FinalBills = new HashSet<FinalBill>();
            this.SuppCollectionEntries = new HashSet<SuppCollectionEntry>();
            this.SuppDiscounts = new HashSet<SuppDiscount>();
        }
    
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierACNumber { get; set; }
        public string Alias { get; set; }
        public string SupplierGroup { get; set; }
        public string SupplierZone { get; set; }
        public Nullable<int> ODDays { get; set; }
        public string BillTerms { get; set; }
        public string Priority { get; set; }
        public string Variety { get; set; }
        public Nullable<int> FrequencyPerMonth { get; set; }
        public string TanName { get; set; }
        public string TanNumber { get; set; }
        public string Remarks { get; set; }
        public string GlobalCode { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public string ServiceTaxOn { get; set; }
        public Nullable<decimal> Commission { get; set; }
        public string PriorityMember { get; set; }
        public Nullable<bool> IsStartDailyBilling { get; set; }
        public Nullable<bool> IsBK { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<SupplierBillingDetail> SupplierBillingDetails { get; set; }
        public virtual ICollection<SupplierContactInfo> SupplierContactInfoes { get; set; }
        public virtual ICollection<SupplierProprietor> SupplierProprietors { get; set; }
        public virtual ICollection<SupplierSisterConcern> SupplierSisterConcerns { get; set; }
        public virtual ICollection<SaleLREntry> SaleLREntries { get; set; }
        public virtual ICollection<Ledger> Ledgers { get; set; }
        public virtual ICollection<DiscountEntry> DiscountEntries { get; set; }
        public virtual ICollection<GRNDebitNote> GRNDebitNotes { get; set; }
        public virtual ICollection<CollectionEntry> CollectionEntries { get; set; }
        public virtual ICollection<ReturnDraftCheque> ReturnDraftCheques { get; set; }
        public virtual ICollection<SupplierSisterConcern> SupplierSisterConcerns1 { get; set; }
        public virtual ICollection<FinalBill> FinalBills { get; set; }
        public virtual ICollection<SuppCollectionEntry> SuppCollectionEntries { get; set; }
        public virtual ICollection<SuppDiscount> SuppDiscounts { get; set; }
    }
}
