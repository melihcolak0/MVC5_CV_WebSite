﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _41MY_MVCWebSiteCV.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Abilities> Tbl_Abilities { get; set; }
        public virtual DbSet<Tbl_AboutMe> Tbl_AboutMe { get; set; }
        public virtual DbSet<Tbl_Certificates> Tbl_Certificates { get; set; }
        public virtual DbSet<Tbl_Contact> Tbl_Contact { get; set; }
        public virtual DbSet<Tbl_Education> Tbl_Education { get; set; }
        public virtual DbSet<Tbl_Experiences> Tbl_Experiences { get; set; }
        public virtual DbSet<Tbl_Interests> Tbl_Interests { get; set; }
        public virtual DbSet<Tbl_Users> Tbl_Users { get; set; }
        public virtual DbSet<Tbl_SocialMedia> Tbl_SocialMedia { get; set; }
    }
}
