﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TravelEntities : DbContext
    {
        public TravelEntities()
            : base("name=TravelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<T_Agents> T_Agents { get; set; }
        public virtual DbSet<T_AirportDetails> T_AirportDetails { get; set; }
        public virtual DbSet<T_Bills> T_Bills { get; set; }
        public virtual DbSet<T_CarDetails> T_CarDetails { get; set; }
        public virtual DbSet<T_Customers> T_Customers { get; set; }
        public virtual DbSet<T_Drivers> T_Drivers { get; set; }
        public virtual DbSet<T_Functions> T_Functions { get; set; }
        public virtual DbSet<T_GuideDetails> T_GuideDetails { get; set; }
        public virtual DbSet<T_Guides> T_Guides { get; set; }
        public virtual DbSet<T_LiveDetails> T_LiveDetails { get; set; }
        public virtual DbSet<T_LiveProjects> T_LiveProjects { get; set; }
        public virtual DbSet<T_Logs> T_Logs { get; set; }
        public virtual DbSet<T_Moneys> T_Moneys { get; set; }
        public virtual DbSet<T_RoleFunction> T_RoleFunction { get; set; }
        public virtual DbSet<T_Roles> T_Roles { get; set; }
        public virtual DbSet<T_Status> T_Status { get; set; }
        public virtual DbSet<T_Suppliers> T_Suppliers { get; set; }
        public virtual DbSet<T_TravelDetails> T_TravelDetails { get; set; }
        public virtual DbSet<T_TravelProjects> T_TravelProjects { get; set; }
        public virtual DbSet<T_TravelProjectTypes> T_TravelProjectTypes { get; set; }
        public virtual DbSet<T_Users> T_Users { get; set; }
        public virtual DbSet<T_VIPs> T_VIPs { get; set; }
        public virtual DbSet<T_Schedule> T_Schedule { get; set; }
        public virtual DbSet<T_ScheduleDetail> T_ScheduleDetail { get; set; }
    }
}
