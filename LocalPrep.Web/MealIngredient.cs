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
    
    public partial class MealIngredient
    {
        public int MealIngredientId { get; set; }
        public int MealId { get; set; }
        public string IngredientName { get; set; }
    
        public virtual Meal Meal { get; set; }
    }
}
