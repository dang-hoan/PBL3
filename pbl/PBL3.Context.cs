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
<<<<<<< HEAD
            : base("name=PBL3-Phong")
=======
            : base("name=PBL3-Duc")
>>>>>>> cfd09818259f6e9a4528ca189d6a4191523d83a1
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LOGIN> LOGINs { get; set; }
        public virtual DbSet<NOTICE> NOTICEs { get; set; }
        public virtual DbSet<PEOPLE> PEOPLE { get; set; }
        public virtual DbSet<POSITION> POSITIONs { get; set; }
        public virtual DbSet<SCHEDULE> SCHEDULEs { get; set; }
        public virtual DbSet<SECURITY> SECURITies { get; set; }
        public virtual DbSet<STATION> STATIONs { get; set; }
        public virtual DbSet<TICKET> TICKETs { get; set; }
        public virtual DbSet<TRAIN> TRAINs { get; set; }
        public virtual DbSet<TRIP> TRIPs { get; set; }
    }
}
