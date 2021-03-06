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
    
    public partial class ProductSlab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductSlab()
        {
            this.BuyerProductScheduleSlabs = new HashSet<BuyerProductScheduleSlab>();
            this.TransferLogs = new HashSet<TransferLog>();
        }
    
        public int ID { get; set; }
        public int ProductMasterId { get; set; }
        public string SlabName { get; set; }
        public string BuyerSlabName { get; set; }
        public int State { get; set; }
        public string ProductFormula { get; set; }
        public string CommonFormula { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public int DeleteStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BuyerProductScheduleSlab> BuyerProductScheduleSlabs { get; set; }
        public virtual ProductMaster ProductMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransferLog> TransferLogs { get; set; }
    }
}
