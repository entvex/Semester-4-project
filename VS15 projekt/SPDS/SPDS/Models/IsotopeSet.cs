//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPDS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IsotopeSet
    {
        public int IsotopeId { get; set; }
        public decimal Charge { get; set; }
        public Nullable<int> IonIsotope_Isotope_IonId { get; set; }
    
        public virtual IonSet IonSet { get; set; }
    }
}