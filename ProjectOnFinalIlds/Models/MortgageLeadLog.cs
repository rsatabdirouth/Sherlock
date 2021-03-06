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
    
    public partial class MortgageLeadLog
    {
        public int ID { get; set; }
        public int MortgageLeadId { get; set; }
        public int Stage { get; set; }
        public int CommonLeadId { get; set; }
        public System.DateTime Dob { get; set; }
        public Nullable<int> Age { get; set; }
        public int EmploymentStatus { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public int Period { get; set; }
        public int PropertyValue { get; set; }
        public int LoanValue { get; set; }
        public int CurrentDebt { get; set; }
        public int PropertyType { get; set; }
        public int PropertyLocation { get; set; }
        public int CreditHistory { get; set; }
        public int AnnualIncome { get; set; }
        public bool MissAnyLoan { get; set; }
        public bool HadBankruptcy { get; set; }
        public bool AppliedIva { get; set; }
        public bool HadCcj { get; set; }
        public int RateType { get; set; }
        public int RepaymentType { get; set; }
        public decimal LTV { get; set; }
        public bool AdverseCredit { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        public virtual MortgageLead MortgageLead { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
