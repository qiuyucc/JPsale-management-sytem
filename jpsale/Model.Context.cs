﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jpsale
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JPsaleEntities : DbContext
    {
        public JPsaleEntities()
            : base("name=JPsaleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AdminInfo> AdminInfoes { get; set; }
        public DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public DbSet<ProductInfo> ProductInfoes { get; set; }
        public DbSet<OrderInfo> OrderInfoes { get; set; }
    }
}