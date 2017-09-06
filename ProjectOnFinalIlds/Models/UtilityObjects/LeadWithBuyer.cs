using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOnFinalIlds.Models.UtilityObjects
{
    public class LeadWithBuyer
    {       
        public int LeadId { get; set; }
        public DateTime? TransferDateTime { get; set; }
        public string Source { get; set; }
        public string BuyerName { get; set; }
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int BuyerId { get; set; }
        public string BuyerRefId { get; set; }
        public bool Returned { get; set; } = false;
        public DateTime GeneratedDateTime { get; set; }
        public LeadStatusEnum Status { get; set; }
        public int TransferLogId { get; set; }
        public double Price { get; set; }
        public string ActualPrice { get; set; }
        public int? ScheduleId { get; set; }
        public DateTime? ScheduleStartDate { get; set; }
        public DateTime? ScheduleEndDate { get; set; }
        public int? SlabId { get; set; }
        public string SlabName { get; set; }
    }
}
