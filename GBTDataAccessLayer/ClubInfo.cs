//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GBTDataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClubInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClubInfo()
        {
            this.Branches = new HashSet<Branch>();
            this.Membershipdatas = new HashSet<Membershipdata>();
        }
    
        public int ID { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public Nullable<int> Active { get; set; }
        public string Addresses { get; set; }
        public string Tel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Branch> Branches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Membershipdata> Membershipdatas { get; set; }
    }
}