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
    
    public partial class RenewalData
    {
        public int ID { get; set; }
        public Nullable<int> MembershipID { get; set; }
        public Nullable<System.DateTime> Renwaldate { get; set; }
        public Nullable<int> status { get; set; }
    
        public virtual Membershipdata Membershipdata { get; set; }
    }
}
