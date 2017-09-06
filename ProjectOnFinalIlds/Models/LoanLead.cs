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
    
    public partial class LoanLead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoanLead()
        {
            this.LoanLeadLogs = new HashSet<LoanLeadLog>();
        }
    
        public int ID { get; set; }
        public int LeadId { get; set; }
        public System.DateTime Dob { get; set; }
        public Nullable<int> Age { get; set; }
        public int LoanPurpose { get; set; }
        public Nullable<System.DateTime> PreviousAddressSince { get; set; }
        public string PreviousPostCode { get; set; }
        public string PreviousCity { get; set; }
        public string PreviousAddress { get; set; }
        public string EmployerName { get; set; }
        public Nullable<System.DateTime> EmployedSince { get; set; }
        public string Occupation { get; set; }
        public bool BeenInDebt { get; set; }
        public bool LoanGurantor { get; set; }
        public string TotalCreditors { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public string GuarantorName { get; set; }
        public string GuarantorPhone { get; set; }
        public string GuarantorEmail { get; set; }
        public int Period { get; set; }
        public int LoanEmploymentStatus { get; set; }
        public int LoanCreditRating { get; set; }
        public Nullable<int> LoanAnnualIncome { get; set; }
        public int LoanCountryOfResidence { get; set; }
        public int LoanMaritalStatus { get; set; }
        public int MortgageBalance { get; set; }
        public Nullable<int> LoanPropertyValue { get; set; }
        public Nullable<bool> HomeOwner { get; set; }
        public int MortgageLoanValue { get; set; }
        public Nullable<System.DateTime> AddressStartDate { get; set; }
        public bool HadBankruptcy { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanLeadLog> LoanLeadLogs { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
