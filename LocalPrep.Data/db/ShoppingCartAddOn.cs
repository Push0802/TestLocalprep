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
    
    public partial class ShoppingCartAddOn
    {
        public int CartAddOnId { get; set; }
        public int CartId { get; set; }
        public int MealAddOnId { get; set; }
        public decimal Price { get; set; }
    
        public virtual MealAddOn MealAddOn { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}