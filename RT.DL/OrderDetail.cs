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
    
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            this.OrderTransactions = new HashSet<OrderTransaction>();
        }
    
        public int OrderDetailId { get; set; }
        public Nullable<int> fkOrderId { get; set; }
        public Nullable<int> fkSupplierId { get; set; }
        public Nullable<int> RedQty { get; set; }
        public Nullable<int> OrQty { get; set; }
        public Nullable<int> BalQty { get; set; }
        public string Accompany { get; set; }
        public string QNK { get; set; }
        public Nullable<int> TotalQty { get; set; }
        public Nullable<bool> IsNullify { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual OrderEntry OrderEntry { get; set; }
        public virtual ICollection<OrderTransaction> OrderTransactions { get; set; }
    }
}
