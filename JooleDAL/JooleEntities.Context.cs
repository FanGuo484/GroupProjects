﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JooleDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyConnectionString : DbContext
    {
        public MyConnectionString()
            : base("name=MyConnectionString")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }
        public virtual DbSet<tblProductsDetal> tblProductsDetals { get; set; }
        public virtual DbSet<tblProductSeriesInfo> tblProductSeriesInfoes { get; set; }
        public virtual DbSet<tblSubCategory> tblSubCategories { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}
