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
    
    public partial class MethodSet
    {
        public int MethodId { get; set; }
        public string Description { get; set; }
        public Nullable<int> DatasetMethod_Method_DatasetId { get; set; }
    
        public virtual DatasetSet DatasetSet { get; set; }
    }
}