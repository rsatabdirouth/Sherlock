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
    
    public partial class CorporateHealthLead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CorporateHealthLead()
        {
            this.CorporateHealthLeadLogs = new HashSet<CorporateHealthLeadLog>();
        }
    
        public int ID { get; set; }
        public int LeadId { get; set; }
        public System.DateTime Dob { get; set; }
        public Nullable<int> Age { get; set; }
        public int Period { get; set; }
        public int PremiumTypeId { get; set; }
        public int InsuranceTypeId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPostCode { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyAddress { get; set; }
        public int EmployeeNumber { get; set; }
        public bool ExistingPolicy { get; set; }
        public string PartnerGender { get; set; }
        public int CorporateCoverTypeHealth { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorporateHealthLeadLog> CorporateHealthLeadLogs { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
