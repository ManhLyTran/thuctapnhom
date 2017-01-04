﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
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
    
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
        public DbSet<CONFIGCOMP> CONFIGCOMPs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<RevervationRoom> RevervationRooms { get; set; }
        public DbSet<Revervation> Revervations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<UseAmenity> UseAmenities { get; set; }
        public DbSet<UsedService> UsedServices { get; set; }
        public DbSet<UsedServiceCode> UsedServiceCodes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<checkin_Custommer> checkin_Custommer { get; set; }
    
        public virtual ObjectResult<Nullable<long>> GetNextAmenitySeq()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("GetNextAmenitySeq");
        }
    
        public virtual ObjectResult<Nullable<long>> GetNextRoomSeq()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("GetNextRoomSeq");
        }
    
        public virtual ObjectResult<Nullable<long>> GetNextRoomTypeSeq()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("GetNextRoomTypeSeq");
        }
    }
}
