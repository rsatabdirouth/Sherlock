using ProjectOnFinalIlds.Models;
using ProjectOnFinalIlds.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnFinalIlds.Controllers
{
    public class HomeController : Controller
    {
        SherlockEntities1 _db = new SherlockEntities1();
        // GET: Home
     [HttpGet]
        //public ActionResult Index()
        //{

        //    var leads = new List<Lead>();

        //   var products = _db.ProductMasters.ToList();
        //   var buyer = _db.BuyerMasters.ToList();
        //   var  website = _db.WebsiteMasters.ToList();
        //   var status = _db.LeadStatusByNames.ToList();
        //    leads = _db.Database.SqlQuery<Lead>("exec TEST_SP_SEARCH_LEADINFO").ToList();



        //    var Dashboard = new Dashboard()
        //    {

        //        ProductList = products,
        //        BuyerList = buyer,
        //        WebsiteList = website,
        //        status = status,
        //        Lead = leads,
        //    };


        //    return View(Dashboard);

        //}
        public ActionResult Index()
        {
           

           var products = _db.ProductMasters.ToList();
           var buyer = _db.BuyerMasters.ToList();
          var  website = _db.WebsiteMasters.ToList();
          var  status = _db.LeadStatusByNames.ToList();
          var  leads = _db.Database.SqlQuery<Lead>("exec PREV_SP_LEAD_INFO_SMALLDATA").ToList();
         



            var Dashboard = new Dashboard()
            {

                ProductList = products,
                BuyerList = buyer,
                WebsiteList = website,
                LeadStatus = status,
                Lead = leads,
            };


            return View(Dashboard);





        }

        [HttpPost]
        public ActionResult Index(DateTime? startDate,DateTime? endDate,DateTime? trnsfrStart,DateTime? transfrEnd,int? leadId,string productName = null, string websiteName = null, string email = null,string leadStatus = null,string buyerName = null,string workPhone = null,string homePhone = null,string fullName = null)
        {
            //var products = new List<ProductMaster>();
            //var buyer = new List<BuyerMaster>();
            //var website = new List<WebsiteMaster>();
            //var status = new List<LeadStatusByName>();
            var leads = new List<Lead>();
      

          var  products = _db.ProductMasters.ToList();
          var  buyer = _db.BuyerMasters.ToList();
          var  website = _db.WebsiteMasters.ToList();
          var status = _db.LeadStatusByNames.ToList();


          var leadsInfos = _db.PREV_SP_LEAD_INFO(startDate,endDate,trnsfrStart,transfrEnd,productName,websiteName,leadStatus,buyerName,fullName,email,workPhone,homePhone,
                leadId).ToList();

           
            foreach (var lead in leadsInfos)
            {
                leads.Add(new Lead()
                {
                    AdditionalInformation = lead?.AdditionalInformation,
                    //AsuAdditionalInformation = lead.AsuAdditionalInformation,
                    //AsuAge = lead.AsuAge,
                    //AsuAmount = lead.AsuAmount,
                    //AsuCoverFromType = (CoverFromTypeEnum)lead.AsuCoverFromType,
                    //AsuCoverType = (CoverTypeEnum)lead.AsuCoverType,
                    //AsuCreatedBy = lead.AsuCreatedBy,
                    //AsuCreatedOn = lead.AsuCreatedOn,
                    //AsuDob = lead.AsuDob,
                    //AsuGeneratedDate = lead.AsuGeneratedDate,
                    //AsuID = lead.AsuID,
                    //AsuIPASUEmploymentStatus = (IPASUEmploymentStatusEnum)lead.AsuIPASUEmploymentStatus,
                    //AsuIsDeleted = (ActiveState)lead.AsuIsDeleted,
                    //AsuPeriod = lead.AsuPeriod,
                    //AsuPremiumType = (PensionPremiumTypeEnum)lead.AsuPremiumType,
                    //AsuSmoker = lead.AsuSmoker,
                    //AsuUpdatedBy = lead.AsuUpdatedBy,
                    //AsuUpdatedOn = lead.AsuUpdatedOn,
                    //BuyerAddress = lead.BuyerAddress,
                    //BuyerCompanyRegistrationNo = lead.BuyerCompanyRegistrationNo,
                    //BuyerContactNumber = lead.BuyerContactNumber,
                    //BuyerCreatedBy = lead.BuyerCreatedBy,
                    //BuyerCreatedOn = lead.BuyerCreatedOn,
                    //BuyerEmail = lead.BuyerEmail,
                    //BuyerFcaNo = lead.BuyerFcaNo,
                    //BuyerIcoExpDate = lead.BuyerIcoExpDate,
                    //BuyerIcoNo = lead.BuyerIcoNo,
                    //BuyerIsDeleted = (ActiveState)lead.BuyerIsDeleted,
                    //BuyerPincode = lead.BuyerPincode,
                    //BuyerPocContactNumber = lead.BuyerPocContactNumber,
                    //BuyerPocName = lead.BuyerPocName,
                    //BuyerScheduleActiveState = (ActiveState)lead.BuyerScheduleActiveState,
                    //BuyerScheduleBuyerProductScheduleId = lead.BuyerScheduleBuyerProductScheduleId,
                    //BuyerScheduleCreatedBy = lead.BuyerScheduleCreatedBy,
                    //BuyerScheduleCreatedOn = lead.BuyerScheduleCreatedOn,
                    //BuyerScheduleDailyDemand = lead.BuyerScheduleDailyDemand,
                    //BuyerScheduleDemand = lead.BuyerScheduleDemand,
                    //BuyerScheduleEndDateTime = lead.BuyerScheduleEndDateTime,
                    //BuyerScheduleIsBuyerDeleted = (ActiveState)lead.BuyerScheduleIsBuyerDeleted,
                    //BuyerSchedulePaymentMode = (PaymentTypeEnum)lead.BuyerSchedulePaymentMode,
                    //BuyerScheduleStartDateTime = lead.BuyerScheduleStartDateTime,
                    //BuyerScheduleTimePeriod = lead.BuyerScheduleTimePeriod,
                    //BuyerScheduleUpdatedBy = lead.BuyerScheduleUpdatedBy,
                    //BuyerScheduleUpdatedOn = lead.BuyerScheduleUpdatedOn,
                    //BuyerType = lead.BuyerType,
                    //BuyerUpdatedBy = lead.BuyerUpdatedBy,
                    //BuyerUpdatedOn = lead.BuyerUpdatedOn,
                    //City = lead.City,
                    commonleadID = lead.commonleadID,
                    //ContactTime = (ContactTimeEnum)lead.ContactTime,
                    //CorporateHealthCompanyAddress = lead.CorporateHealthCompanyAddress,
                    //CorporateHealthCompanyCity = lead.CorporateHealthCompanyCity,
                    //CorporateHealthCompanyName = lead.CorporateHealthCompanyName,
                    //CorporateHealthCompanyPostCode = lead.CorporateHealthCompanyPostCode,
                    //CorporateHealthCorporateCoverTypeHealth = (HealthCoverTypeEnum)lead.CorporateHealthCorporateCoverTypeHealth,
                    //CorporateHealthCreatedBy = lead.CorporateHealthCreatedBy,
                    //CorporateHealthCreatedOn = lead.CorporateHealthCreatedOn,
                    //CorporateHealthDeleteStatus = (ActiveState)lead.CorporateHealthDeleteStatus,
                    //CorporateHealthEmployeeNumber = (EmployeeNumberEnum)lead.CorporateHealthEmployeeNumber,
                    //CorporateHealthExistingPolicy = lead.CorporateHealthExistingPolicy,
                    //CorporateHealthID = lead.CorporateHealthID,
                    //CorporateHealthLeadsAge = lead.CorporateHealthLeadsAge,
                    //CorporateHealthLeadsdob = lead.CorporateHealthLeadsdob,
                    //CorporateHealthPartnerGender = lead.CorporateHealthPartnerGender,
                    //CorporateHealthPremiumTypeId = (PensionPremiumTypeEnum)lead.CorporateHealthPremiumTypeId,
                    //CorporateHealthTypeId = (InsuranceTypeEnum)lead.CorporateHealthTypeId,
                    //CorporateHealthUpdatedBy = lead.CorporateHealthUpdatedBy,
                    //CorporateHealthUpdatedOn = lead.CorporateHealthUpdatedOn,
                    CreatedBy = lead.CreatedBy,
                    CreatedOn = lead.CreatedOn,
                    //DebtAge = lead.DebtAge,
                    //DebtCategory = (DebtCategory)lead.DebtCategory,
                    //DebtCreatedBy = lead.DebtCreatedBy,
                    //DebtCreatedOn = lead.DebtCreatedOn,
                    //DebtDob = lead.DebtDob,
                    //DebtEmploymentStatus = (EmploymentStatus)lead.DebtEmploymentStatus,
                    //DebtGeneratedDate = lead.DebtGeneratedDate,
                    //DebtHadCCJ = lead.DebtHadCCJ,
                    //DebtID = lead.DebtID,
                    //DebtIsDeleted = (ActiveState)lead.DebtIsDeleted,
                    //DebtMonthlyDisposable = lead.DebtMonthlyDisposable,
                    //DebtMonthlyIncome = lead.DebtMonthlyIncome,
                    //DebtMonthlyRepayments = lead.DebtMonthlyRepayments,
                    //DebtResidentialLocation = (PropertyLocation)lead.DebtResidentialLocation,
                    //DebtTotalCreditors = lead.DebtTotalCreditors,
                    //DebtTotalUnsecuredDebt = lead.DebtTotalUnsecuredDebt,
                    //DebtType = (DebtTypeEnum)lead.DebtType,
                    //DebtUpdatedBy = lead.DebtUpdatedBy,
                    //DebtUpdatedOn = lead.DebtUpdatedOn,
                    //DeptTypes = lead.DeptTypes,
                    Description = lead.TransferlogDescription,
                    //DNC = (DNCEnum)lead.DNC,
                    Email = lead.Email,
                    //EquityreleaseAge = lead.EquityreleaseAge,
                    //EquityreleaseAgeType = lead.EquityreleaseAgeType,
                    //EquityreleaseCreatedBy = lead.EquityreleaseCreatedBy,
                    //EquityreleaseCreatedOn = lead.EquityreleaseCreatedOn,
                    //EquityreleaseDob = lead.EquityreleaseDob,
                    //EquityreleaseEquityType = lead.EquityreleaseEquityType,
                    //EquityreleaseGeneratedDate = lead.EquityreleaseGeneratedDate,
                    //EquityreleaseHomeValue = lead.EquityreleaseHomeValue,
                    //EquityreleaseID = lead.EquityreleaseID,
                    //EquityreleaseIsDeleted = (ActiveState)lead.EquityreleaseIsDeleted,
                    //EquityreleaseOutstandingMortgageValue = lead.EquityreleaseOutstandingMortgageValue,
                    //EquityreleaseUpdatedBy = lead.EquityreleaseUpdatedBy,
                    //EquityreleaseUpdatedOn = lead.EquityreleaseUpdatedOn,
                    //FirstName = lead.FirstName,
                    FullName = lead?.FullName,
                    //FuneralAge = lead.FuneralAge,
                    //FuneralCreatedBy = lead.FuneralCreatedBy,
                    //FuneralCreatedOn = lead.FuneralCreatedOn,
                    //FuneralDob = lead.FuneralDob,
                    //FuneralGeneratedDate = lead.FuneralGeneratedDate,
                    //FuneralID = lead.FuneralID,
                    //FuneralIsDeleted = (ActiveState)lead.FuneralIsDeleted,
                    //FuneralUpdatedBy = lead.FuneralUpdatedBy,
                    //FuneralUpdatedOn = lead.FuneralUpdatedOn,
                    //HealthAge = lead.HealthAge,
                    //HealthCoverTypeHealth = (CoverFromTypeEnum)lead.HealthCoverTypeHealth,
                    //HealthCreatedBy = lead.HealthCreatedBy,
                    //HealthCreatedOn = lead.HealthCreatedOn,
                    //HealthDeleteStatus = (ActiveState)lead.HealthDeleteStatus,
                    //HealthDOB = lead.HealthDOB,
                    //HealthExistingPolicy = lead.HealthExistingPolicy,
                    //HealthFamilyMember = lead.HealthFamilyMember,
                    //HealthGeneratedDate = lead.HealthGeneratedDate,
                    //HealthID = lead.HealthID,
                    //HealthInsuranceTypeId = (InsuranceTypeEnum)lead.HealthInsuranceTypeId,
                    //HealthIsSmoker = lead.HealthIsSmoker,
                    //HealthPartnerAge = lead.HealthPartnerAge,
                    //HealthPeriod = lead.HealthPeriod,
                    //HealthPremiumAmount = lead.HealthPremiumAmount,
                    //HealthPremiumType = (PensionPremiumTypeEnum)lead.HealthPremiumType,
                    //HealthUpdatedBy = lead.HealthUpdatedBy,
                    //HealthUpdatedOn = lead.HealthUpdatedOn,
                    HomePhone = lead.HomePhone,
                    //IpAddress = lead.IpAddress,
                    //IsDeleted = (EntityStatus)lead.IsDeleted,
                    //IsMultipleBuyer = lead.IsMultipleBuyer,
                    //LifeAdditionalInformation = lead.LifeAdditionalInformation,
                    //loanHomeOwner = lead.loanHomeOwner,
                    //loanID = lead.loanID,
                    //LastName = lead.LastName,
                    //LeadCategory = (LeadCategoryEnum)lead.LeadCategory,
                    //LeadComment = lead.LeadComment,
                    LeadStatus = lead.LeadStatus,
                    //LeadType = (LeadTypeEnum)lead.LeadType,
                    //LifeAge = lead.LifeAge,
                    //LifeAmount = lead.LifeAmount,
                    //LifeCreatedBy = lead.LifeCreatedBy,
                    //LifeCreatedOn = lead.LifeCreatedOn,
                    //LifeCriticalIllness = lead.LifeCriticalIllness,
                    //LifeDob = lead.LifeDob,
                    //LifeGeneratedDate = lead.LifeGeneratedDate,
                    //LifeID = lead.LifeID,
                    //LifeInsuranceType = (InsuranceTypeEnum)lead.LifeInsuranceType,
                    //LifeIsDeleted = (ActiveState)lead.LifeIsDeleted,
                    //LifeIsSmoker = lead.LifeIsSmoker,
                    //LifePartnerDob = lead.LifePartnerDob,
                    //LifePartnerSmoker = lead.LifePartnerSmoker,
                    //LifePartnersName = lead.LifePartnersName,
                    //LifePeriod = lead.LifePeriod,
                    //LifePremiumType = (PensionPremiumTypeEnum)lead.LifePremiumType,
                    //LifeProductType = lead.LifeProductType,
                    //LifeSingleOwnership = lead.LifeSingleOwnership,
                    //LifeUpdatedBy = lead.LifeUpdatedBy,
                    //LifeUpdatedOn = lead.LifeUpdatedOn,
                    //LoanAddressStartDate = lead.LoanAddressStartDate,
                    //LoanAge = lead.LoanAge,
                    //LoanAnnualIncome = lead.LoanAnnualIncome,
                    //LoanBeenInDebt = lead.LoanBeenInDebt,
                    //LoanCountryOfResidenceget = (Models.UtilityObjects.LoanEnum.LoanCountryOfResidenceEnum)lead.LoanCountryOfResidence,
                    //LoanCreatedBy = lead.LoanCreatedBy,
                    //LoanCreatedOn = lead.LoanCreatedOn,
                    //LoanCreditRating = (Models.UtilityObjects.LoanEnum.CreditRatingEnum)lead.LoanCreditRating,
                    //LoanDeleteStatus = (ActiveState)lead.LoanDeleteStatus,
                    //LoanDob = lead.LoanDob,
                    //LoanEmployerName = lead.LoanEmployerName,
                    //LoanEmployerSince = lead.LoanEmployerSince,
                    //LoanEmploymentStatus = (Models.UtilityObjects.LoanEnum.LoanEmploymentStatusEnum)lead.LoanEmploymentStatus,
                    //LoanGeneratedDate = lead.LoanGeneratedDate,
                    //LoanGuarantorEmail = lead.LoanGuarantorEmail,
                    //LoanGuarantorName = lead.LoanGuarantorName,
                    //LoanGuarantorPhone = lead.LoanGuarantorPhone,
                    //LoanGurantor = lead.LoanGurantor,
                    //LoanHadBankruptcy = lead.LoanHadBankruptcy,
                    //LoanMaritalStatus = (Models.UtilityObjects.LoanEnum.MaritalStatusEnum)lead.LoanMaritalStatus,
                    //LoanMortgageBalance = lead.LoanMortgageBalance,
                    //LoanMortgageLoanValue = lead.LoanMortgageLoanValue,
                    //LoanOccupation = lead.LoanOccupation,
                    //LoanPeriod = lead.LoanPeriod,
                    //LoanPreviousAddress = lead.LoanPreviousAddress,
                    //LoanPreviousAddressSince = lead.LoanPreviousAddressSince,
                    //LoanPreviousCity = lead.LoanPreviousCity,
                    //LoanPreviousPostCode = lead.LoanPreviousPostCode,
                    //LoanPropertyValue = lead.LoanPropertyValue,
                    //LoanPurpose = (Models.UtilityObjects.LoanEnum.LoanPurposeEnum)lead.LoanPurpose,
                    //LoanTotalCreditors = lead.LoanTotalCreditors,
                    //LoanUpdatedBy = lead.LoanUpdatedBy,
                    //LoanUpdatedOn = lead.LoanUpdatedOn,
                    Keyword = lead.Keyword,
                    //MatchType = lead.MatchType,
                    //MortgageAge = lead.MortgageAge,
                    //MortgageAnnualIncome = lead.MortgageAnnualIncome,
                    //MortgageAppliedIva = lead.MortgageAppliedIva,
                    //MortgageCreatedBy = lead.MortgageCreatedBy,
                    //MortgageCreatedOn = lead.MortgageCreatedOn,
                    //MortgageCreditHistory = (CreditHistory)lead.MortgageCreditHistory,
                    //MortgageCurrentDebt = lead.MortgageCurrentDebt,
                    //MortgageDOB = lead.MortgageDOB,
                    //MortgageEmplomentStatus = (EmploymentStatus)lead.MortgageEmplomentStatus,
                    //MortgageGeneratedDate = lead.MortgageGeneratedDate,
                    //MortgageHadBankruptcy = lead.MortgageHadBankruptcy,
                    //MortgageHadCCJ = lead.MortgageHadCCJ,
                    //MortgageID = lead.MortgageID,
                    //MortgageIsAdverseCredit = lead.MortgageIsAdverseCredit,
                    //MortgageIsLeadDeleted = (ActiveState)lead.MortgageIsLeadDeleted,
                    //MortgageLoanValue = lead.MortgageLoanValue,
                    //MortgageMissAnyLoan = lead.MortgageMissAnyLoan,
                    //MortgagePeriod = lead.MortgagePeriod,
                    //MortgagePropertyLocation = (PropertyLocation)lead.MortgagePropertyLocation,
                    //MortgagePropertyType = (PropertyType)lead.MortgagePropertyType,
                    //MortgagePropertyValue = lead.MortgagePropertyValue,
                    //MortgageRateType = (RateType)lead.MortgageRateType,
                    //MortgageRepaymentType = (RepaymentType)lead.MortgageRepaymentType,
                    //MortgageUpdatedBy = lead.MortgageUpdatedBy,
                    //MortgageUpdatedOn = lead.MortgageUpdatedOn,
                    //OrganizationMasterId = lead.OrganizationMasterId,
                    //OperatorName = lead.OperatorName,
                    //OperatorSpecificComments = lead.OperatorSpecificComments,
                    //Opt = lead.Opt,
                    //OrganizationHashCode = lead.OrganizationHashCode,
                    //ParentProductId = lead.ParentProductId,
                    //PensionAccessFund = (PensionAccessFundEnum)lead.PensionAccessFund,
                    //PensionAge = lead.PensionAge,
                    //PensionCreatedBy = lead.PensionCreatedBy,
                    //PensionCreatedOn = lead.PensionCreatedOn,
                    //PensionDeleteStatus = (ActiveState)lead.PensionDeleteStatus,
                    //PensionDob = lead.PensionDob,
                    //PensionExistPensions = lead.PensionExistPensions,
                    //PensionGeneratedDate = lead.PensionGeneratedDate,
                    //PensionID = lead.PensionID,
                    //PensionIsCurrentlyPayingMoney = lead.PensionIsCurrentlyPayingMoney,
                    //PensionPremiumType = (PensionPremiumTypeEnum)lead.PensionPremiumType,
                    //PensionTotalPensionValue = lead.PensionTotalPensionValue,
                    //PensionType = (PensionTypeEnum)lead.PensionType,
                    //PensionTypeOther = lead.PensionTypeOther,
                    //PensionUpdatedBy = lead.PensionUpdatedBy,
                    //PensionUpdatedOn = lead.PensionUpdatedOn,
                    //PensionValue = lead.PensionValue,
                    //PersonalPensionType = (PersonalPensionTypeEnum)lead.PersonalPensionType,
                    PostCode = lead?.PostCode,
                    //PostcodeInWard = lead.PostcodeInWard,
                    //PostcodeOutWard = lead.PostcodeOutWard,
                    //ProductCreatedBy = lead.ProductCreatedBy,
                    //ProductCreatedOn = lead.ProductCreatedOn,
                    //ProductIsProductDeleted = (EntityStatus)lead.ProductIsProductDeleted,
                    //ProductMasterId = lead.ProductMasterId,
                    ProductName = lead.ProductName,
                    //ProductSlabBuyerSlabName = lead.ProductSlabBuyerSlabName,
                    //ProductSlabCommonFormula = lead.ProductSlabCommonFormula,
                    //ProductSlabCreatedBy = lead.ProductSlabCreatedBy,
                    //ProductSlabCreatedOn = lead.ProductSlabCreatedOn,
                    //ProductSlabIsDeleted = (ActiveState)lead.ProductSlabIsDeleted,
                    //ProductSlabProductFormula = lead.ProductSlabProductFormula,
                    //ProductSlabSlabName = lead.ProductSlabSlabName,
                    //ProductSlabUpdatedBy = lead.ProductSlabUpdatedBy,
                    //ProductSlabUpdatedOn = lead.ProductSlabUpdatedOn,
                    //ProductUpdatedBy = lead.ProductUpdatedBy,
                    //ProductUpdatedOn = lead.ProductUpdatedOn,
                    //NotifyPrice = lead.NotifyPrice,
                    //Query = lead.Query,
                    //SiteCreatorCompany = lead.SiteCreatorCompany,
                    //SiteDeveloperCompany = lead.SiteDeveloperCompany,
                    Source = lead.Source,
                    //SourceUid = lead.SourceUid,
                    //Title = lead.Title,
                    //TransferlogBuyerIntegrationTypeID = lead.TransferlogBuyerIntegrationTypeID,
                    //TransferlogDescription = lead.TransferlogDescription,
                    //Transferloggeneratedon = lead.Transferloggeneratedon,
                    //TransferlogID = lead.TransferlogID,
                    TransferlogIsActualPrice = lead.TransferlogIsActualPrice,
                    TransferlogPrice = lead.TransferlogPrice,
                    //TransferlogProductSlabId = lead.TransferlogProductSlabId,
                    TransferlogTransferredOn = lead.TransferlogTransferredOn,
                    BuyerName = lead.BuyerName,
                    //TransferlogUpdatedOn = lead.TransferlogUpdatedOn,
                    //TransferlogUserId = lead.TransferlogUserId,
                    UpdatedBy = lead.UpdatedBy,
                    UpdatedOn = lead.UpdatedOn,
                    //UserAgent = lead.UserAgent,
                    //WebsiteAddress = lead.WebsiteAddress,
                    //WebsiteCreatedBy = lead.WebsiteCreatedBy,
                    //WebsiteCreatedOn = lead.WebsiteCreatedOn,
                    //WebsiteID = lead.WebsiteID,
                    //WebsiteIsWebsiteDeleted = (EntityStatus)lead.WebsiteIsWebsiteDeleted,
                    WebsiteName = lead?.WebsiteName,
                    WebsiteStatus = lead.WebsiteStatus,
                    //WebsiteUpdatedBy = lead.WebsiteUpdatedBy,
                    //WebsiteUpdatedOn = lead.WebsiteUpdatedOn,
                    //WorkPhone = lead.WorkPhone

                });
            }



            var Dashboard = new Dashboard()
            {

                ProductList = products,
                BuyerList = buyer,
                WebsiteList = website,
                LeadStatus = status,
                Lead = leads,
            };


            return View(Dashboard);

           }


    }
}