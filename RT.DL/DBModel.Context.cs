﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TPLDBEntities : DbContext
    {
        public TPLDBEntities()
            : base("name=TPLDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerContactInfo> CustomerContactInfoes { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<CustomerProprietor> CustomerProprietors { get; set; }
        public virtual DbSet<CustomerSalesman> CustomerSalesmen { get; set; }
        public virtual DbSet<CustomerSisterConcern> CustomerSisterConcerns { get; set; }
        public virtual DbSet<MstBank> MstBanks { get; set; }
        public virtual DbSet<MstBranch> MstBranches { get; set; }
        public virtual DbSet<MstCity> MstCities { get; set; }
        public virtual DbSet<MstCourier> MstCouriers { get; set; }
        public virtual DbSet<MstState> MstStates { get; set; }
        public virtual DbSet<MstSubAgent> MstSubAgents { get; set; }
        public virtual DbSet<MstTransport> MstTransports { get; set; }
        public virtual DbSet<MstUser> MstUsers { get; set; }
        public virtual DbSet<MstUserRole> MstUserRoles { get; set; }
        public virtual DbSet<MstUserType> MstUserTypes { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<UserType> UserTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<SupplierBillingDetail> SupplierBillingDetails { get; set; }
        public virtual DbSet<SupplierContactInfo> SupplierContactInfoes { get; set; }
        public virtual DbSet<SupplierProprietor> SupplierProprietors { get; set; }
        public virtual DbSet<SupplierSisterConcern> SupplierSisterConcerns { get; set; }
        public virtual DbSet<CustomerAccountant> CustomerAccountants { get; set; }
        public virtual DbSet<SaleLREntry> SaleLREntries { get; set; }
        public virtual DbSet<OrderEntry> OrderEntries { get; set; }
        public virtual DbSet<OrderTransaction> OrderTransactions { get; set; }
    }
}
