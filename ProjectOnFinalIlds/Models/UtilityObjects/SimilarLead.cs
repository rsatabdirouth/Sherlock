using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOnFinalIlds.Models.UtilityObjects
{
    public class SimilarLead
    {
        public int LeadId { get; set; }
        public string Buyer { get; set; }
        public string ProductName { get; set; }
        public DateTime? TransferTime { get; set; }
        public DateTime GeneratedTime { get; set; }
        public string FullName { get; set; }
        public string HomePhone { get; set; }
        public string workPhone { get; set; }
        public string IPAdress { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string TransferBy { get; set; }
    }
}
