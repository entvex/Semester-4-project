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
    
    public partial class UserSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserSet()
        {
            this.DatasetSet = new HashSet<DatasetSet>();
        }
    
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Institute { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PermissionPermissionId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatasetSet> DatasetSet { get; set; }
        public virtual PermissionSet PermissionSet { get; set; }
    }
}