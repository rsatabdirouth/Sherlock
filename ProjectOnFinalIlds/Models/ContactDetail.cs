//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOnFinalIlds.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int ContactTime { get; set; }
        public int SiteId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public int Status { get; set; }
        public System.DateTime GeneratedDatetime { get; set; }
    
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual WebsiteMaster WebsiteMaster { get; set; }
    }
}
