﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WaterSupply
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WaterUtilityEntities : DbContext
    {
        public WaterUtilityEntities()
            : base("name=WaterUtilityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Drinking_water_quality_indicator> Drinking_water_quality_indicator { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Place_execution> Place_execution { get; set; }
        public virtual DbSet<Subscriber> Subscriber { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Volume_of_drinking_water_consumption> Volume_of_drinking_water_consumption { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
