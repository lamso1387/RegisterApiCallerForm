﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegisterApiCallerForm
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SemnanEntities3 : DbContext
    {
        public SemnanEntities3()
            : base("name=SemnanEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Anbar> Anbars { get; set; }
        public DbSet<Key> Keys { get; set; }
        public DbSet<TimeTaken> TimeTakens { get; set; }
        public DbSet<EstelamTime> EstelamTimes { get; set; }
        public DbSet<countround> countrounds { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<OrganEstelam> OrganEstelams { get; set; }
    }
}
