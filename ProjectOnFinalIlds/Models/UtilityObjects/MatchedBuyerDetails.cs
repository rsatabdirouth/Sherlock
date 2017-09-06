
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOnFinalIlds.Models.UtilityObjects
{
    public class MatchedBuyerDetails
    {     
        public int BuyerId { get; set; }
        public int Priority { get; set; }
        public int SlabId { get; set; }
        public string SlabName { get; set; }
        public double AvgPrice { get; set; }

        #region ScheduleDemands
        public int ScheduleDemand { get; set; }
        public int ScheduleRemainingDemand { get; set; }
        public int ScheduleDailyDemand { get; set; }
        public int ScheduleRemainingDailyDemand { get; set; }
        #endregion ScheduleDemands
        public double TotalRemainingScheduleInHour { get; set; }
        public double TodayRemainingScheduleInHour { get; set; }
        #region SlabDemands
        public int SlabDemand { get; set; }
        public int SlabDailyDemand { get; set; }
        public int SlabRemainingDemand { get; set; }
        public int SlabRemainingDailyDemand { get; set; }
        #endregion SlabDemands
        public double Budget { get; set; }
        public double RemainigBudget { get; set; }
        public double Score { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public string WSDL { get; set; }
        public string AffiliateId { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public IntegrationType IntegrationType { get; set; }
        public string BuyerName { get; set; }
        public int BuyerProductWeightage { get; set; }
        public int SlabWeightage { get; set; }
        public int ProductScheduleId { get; set; }
        public bool IsTransferDelay { get; set; } = false;
    }
}
