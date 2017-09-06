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
    
    public partial class InjuryClaimLead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InjuryClaimLead()
        {
            this.InjuryClaimLeadLogs = new HashSet<InjuryClaimLeadLog>();
        }
    
        public int ID { get; set; }
        public int LeadId { get; set; }
        public int InjureTime { get; set; }
        public int AccidentType { get; set; }
        public bool IsMedicalAttention { get; set; }
        public bool IsAlreadyClaimed { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
        public string AccidentLocation { get; set; }
    
        public virtual CommonLead CommonLead { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InjuryClaimLeadLog> InjuryClaimLeadLogs { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}