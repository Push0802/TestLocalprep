﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalPrep.Data.db
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class localprepdbEntities : DbContext
    {
        public localprepdbEntities()
            : base("name=localprepdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Cuisine> Cuisines { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<Diet> Diets { get; set; }
        public virtual DbSet<MealAddOn> MealAddOns { get; set; }
        public virtual DbSet<MealIngredient> MealIngredients { get; set; }
        public virtual DbSet<MealPic> MealPics { get; set; }
        public virtual DbSet<MealRating> MealRatings { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<MealTransactionDetailAddOn> MealTransactionDetailAddOns { get; set; }
        public virtual DbSet<MealTransactionDetail> MealTransactionDetails { get; set; }
        public virtual DbSet<MealTransaction> MealTransactions { get; set; }
        public virtual DbSet<ShoppingCartAddOn> ShoppingCartAddOns { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<VendorPayment> VendorPayments { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
    }
}