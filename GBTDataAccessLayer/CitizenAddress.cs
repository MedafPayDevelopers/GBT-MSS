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
    
    public partial class CitizenAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CitizenAddress()
        {
            this.Membershipdatas = new HashSet<Membershipdata>();
        }
    
        public int ID { get; set; }
        public string Addresse { get; set; }
        public Nullable<int> PersonalID { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Membershipdata> Membershipdatas { get; set; }
        public virtual Personaldata Personaldata { get; set; }
    }
}