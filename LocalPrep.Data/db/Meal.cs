//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Meal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meal()
        {
            this.MealAddOns = new HashSet<MealAddOn>();
            this.MealIngredients = new HashSet<MealIngredient>();
            this.MealPics = new HashSet<MealPic>();
            this.MealRatings = new HashSet<MealRating>();
            this.MealTransactionDetails = new HashSet<MealTransactionDetail>();
            this.MealTransactionDetails1 = new HashSet<MealTransactionDetail>();
            this.MealTransactionDetails2 = new HashSet<MealTransactionDetail>();
            this.ShoppingCarts = new HashSet<ShoppingCart>();
        }
    
        public int MealId { get; set; }
        public int VendorId { get; set; }
        public string MealName { get; set; }
        public decimal MealPrice { get; set; }
        public int CuisineId { get; set; }
        public Nullable<int> DietId { get; set; }
        public System.DateTime SubmitDt { get; set; }
        public Nullable<System.DateTime> UpdateDt { get; set; }
        public bool IsActive { get; set; }
        public string MealDescription { get; set; }
        public string HeatingInstructions { get; set; }
        public string Servings { get; set; }
        public string CaloriesServing { get; set; }
        public string Calories { get; set; }
        public string Fat { get; set; }
        public string Protein { get; set; }
        public string Sugar { get; set; }
        public string Sodium { get; set; }
        public string Cholesterol { get; set; }
        public string TotalCarb { get; set; }
    
        public virtual Cuisine Cuisine { get; set; }
        public virtual Diet Diet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealAddOn> MealAddOns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealIngredient> MealIngredients { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealPic> MealPics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealRating> MealRatings { get; set; }
        public virtual Vendor Vendor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealTransactionDetail> MealTransactionDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealTransactionDetail> MealTransactionDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealTransactionDetail> MealTransactionDetails2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}