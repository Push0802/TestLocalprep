//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocalPrep.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class MealTransactionDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MealTransactionDetail()
        {
            this.MealTransactionDetailAddOns = new HashSet<MealTransactionDetailAddOn>();
        }
    
        public int MealTransactionDetailId { get; set; }
        public int MealTransactionId { get; set; }
        public int MealId { get; set; }
        public int MealQty { get; set; }
        public decimal Price { get; set; }
        public string PickupDelivery { get; set; }
        public System.DateTime PickupDeliveryDt { get; set; }
        public string RemoveIngredients { get; set; }
    
        public virtual Meal Meal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealTransactionDetailAddOn> MealTransactionDetailAddOns { get; set; }
        public virtual MealTransaction MealTransaction { get; set; }
    }
}