﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pbl
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PBL3 : DbContext
    {
        public PBL3()
            : base("name=PBL3-Phong")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LOGIN> LOGINs { get; set; }
        public virtual DbSet<PEOPLE> PEOPLE { get; set; }
        public virtual DbSet<POSITION> POSITIONs { get; set; }
        public virtual DbSet<SCHEDULE> SCHEDULEs { get; set; }
        public virtual DbSet<STATION> STATIONs { get; set; }
        public virtual DbSet<TICKET> TICKETs { get; set; }
        public virtual DbSet<TICKET_MANAGER> TICKET_MANAGER { get; set; }
        public virtual DbSet<TRAIN> TRAINs { get; set; }
    }
}
