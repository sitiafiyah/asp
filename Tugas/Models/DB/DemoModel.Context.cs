﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tugas.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DemoModelEntities : DbContext
    {
        public DemoModelEntities()
            : base("name=DemoModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<LOOKUPRole> LOOKUPRoles { get; set; }
        public DbSet<SYSUser> SYSUsers { get; set; }
        public DbSet<SYSUserProfile> SYSUserProfiles { get; set; }
        public DbSet<SYSUserRole> SYSUserRoles { get; set; }
    }
}
