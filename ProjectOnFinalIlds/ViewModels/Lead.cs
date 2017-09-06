using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectOnFinalIlds.Models.UtilityObjects;
using ProjectOnFinalIlds.Models.UtilityObjects.HealthEnum;
using ProjectOnFinalIlds.Models.UtilityObjects.LoanEnum;

namespace ProjectOnFinalIlds.ViewModels
{
  
        public class Lead
        {


            public int commonleadID { get; set; }
            public string Title { get; set; } = "";
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";
            public string FullName { get; set; } = "";
            public string City { get; set; } = "";
            public string PostCode { get; set; } = "";
            public string WorkPhone { get; set; } = "";
            public string HomePhone { get; set; } = "";

            public string Address { get; set; } = "";

            public string Email { get; set; } = "";

            public int? WebsiteID { get; set; }

            public string WebsiteName { get; set; } = "";
            public string WebsiteAddress { get; set; } = "";

            public string WebsiteStatus { get; set; } = "";
            public DateTime? WebsiteCreatedOn { get; set; }

            public DateTime? WebsiteUpdatedOn { get; set; }
            public string WebsiteCreatedBy { get; set; } = "";
            public string WebsiteUpdatedBy { get; set; } = "";
            public EntityStatus WebsiteIsWebsiteDeleted { get; set; }

            public string SiteCreatorCompany { get; set; } = "";
            public string SiteDeveloperCompany { get; set; } = "";

            public string ProductName { get; set; } = "";
            public int? ProductMasterId { get; set; }

            public int? ParentProductId { get; set; }
            public bool? IsMultipleBuyer { get; set; }

            public DateTime? ProductCreatedOn { get; set; }
            public DateTime? ProductUpdatedOn { get; set; }

            public string ProductCreatedBy { get; set; } = "";

            public string ProductUpdatedBy { get; set; } = "";
            public EntityStatus ProductIsProductDeleted { get; set; }
            public string IpAddress { get; set; } = "";
            public string Source { get; set; } = "";

            public string MatchType { get; set; } = "";


            public string Keyword { get; set; } = "";

            public string LeadStatus { get; set; } = "";
            public DNCEnum? DNC { get; set; }

            public string SourceUid { get; set; } = "";

            public string PostcodeOutWard { get; set; } = "";
            public string PostcodeInWard { get; set; } = "";

            public int? OrganizationMasterId { get; set; }
            public string OrganizationHashCode { get; set; } = "";
            public string OperatorName { get; set; } = "";

            public string OperatorSpecificComments { get; set; } = "";
            public bool? Opt { get; set; }

            public string LeadComment { get; set; } = "";

            public Double? NotifyPrice { get; set; }

            public string AdditionalInformation { get; set; } = "";

            public string Description { get; set; } = "";

            public string UserAgent { get; set; } = "";
            public string Query { get; set; } = "";

            public ContactTimeEnum? ContactTime { get; set; }

            public DateTime? CreatedOn { get; set; }
            public DateTime? UpdatedOn { get; set; }
            public string CreatedBy { get; set; } = "";
            public string UpdatedBy { get; set; } = "";
            public EntityStatus? IsDeleted { get; set; }

            public LeadCategoryEnum? LeadCategory { get; set; }

            public LeadTypeEnum? LeadType { get; set; }

            public int? TransferlogID { get; set; }
            public string TransferlogDescription { get; set; } = "";
            public DateTime? Transferloggeneratedon { get; set; }
            public string BuyerName { get; set; } = "";
            public DateTime? TransferlogTransferredOn { get; set; }
            public DateTime? TransferlogUpdatedOn { get; set; }
            public double? TransferlogPrice { get; set; }
            public bool? TransferlogIsActualPrice { get; set; }
            public int? TransferlogBuyerIntegrationTypeID { get; set; }
            public int? TransferlogUserId { get; set; }


            public int? BuyerScheduleBuyerProductScheduleId { get; set; }
            public DateTime? BuyerScheduleStartDateTime { get; set; }
            public DateTime? BuyerScheduleEndDateTime { get; set; }

            public int? BuyerScheduleTimePeriod { get; set; }

            // public ActiveState? BuyerScheduleActiveState { get; set; }
            public DateTime? BuyerScheduleCreatedOn { get; set; }
            public DateTime? BuyerScheduleUpdatedOn { get; set; }
            public string BuyerScheduleCreatedBy { get; set; } = "";
            public string BuyerScheduleUpdatedBy { get; set; } = "";
            public int? BuyerScheduleDemand { get; set; }

            public int? BuyerScheduleDailyDemand { get; set; }
            public PaymentTypeEnum? BuyerSchedulePaymentMode { get; set; }
            //  public ActiveState? BuyerScheduleIsBuyerDeleted { get; set; }
            public string BuyerAddress { get; set; } = "";
            public string BuyerPincode { get; set; } = "";
            public string BuyerPocName { get; set; } = "";
            public string BuyerContactNumber { get; set; } = "";
            public string BuyerPocContactNumber { get; set; } = "";
            public string BuyerType { get; set; } = "";
            public string BuyerIcoNo { get; set; } = "";
            public string BuyerEmail { get; set; } = "";
            public string BuyerFcaNo { get; set; } = "";
            public DateTime? BuyerIcoExpDate { get; set; }
            public string BuyerCompanyRegistrationNo { get; set; } = "";
            public DateTime? BuyerCreatedOn { get; set; }
            public DateTime? BuyerUpdatedOn { get; set; }
            public string BuyerCreatedBy { get; set; } = "";
            public string BuyerUpdatedBy { get; set; } = "";
            // public ActiveState BuyerIsDeleted { get; set; }
            public int? TransferlogProductSlabId { get; set; }
            public string ProductSlabSlabName { get; set; } = "";
            public string ProductSlabBuyerSlabName { get; set; } = "";
            public string ProductSlabProductFormula { get; set; } = "";
            public string ProductSlabCommonFormula { get; set; } = "";
            public DateTime? ProductSlabCreatedOn { get; set; }
            public DateTime? ProductSlabUpdatedOn { get; set; }
            public string ProductSlabCreatedBy { get; set; } = "";
            public string ProductSlabUpdatedBy { get; set; } = "";
            //public ActiveState ProductSlabIsDeleted { get; set; }

            //
            public int? MortgageID { get; set; }
            public DateTime? MortgageDOB { get; set; }
            public int? MortgageAge { get; set; }
            public EmploymentStatus? MortgageEmplomentStatus { get; set; }
            public DateTime? MortgageGeneratedDate { get; set; }
            public int? MortgagePeriod { get; set; }
            public int? MortgagePropertyValue { get; set; }
            public PropertyLocation? MortgagePropertyLocation { get; set; }
            public CreditHistory? MortgageCreditHistory { get; set; }
            public int? MortgageLoanValue { get; set; }
            public int? MortgageCurrentDebt { get; set; }
            public int? MortgageAnnualIncome { get; set; }
            public PropertyType? MortgagePropertyType { get; set; }
            public bool? MortgageMissAnyLoan { get; set; }
            public bool? MortgageHadBankruptcy { get; set; }
            public bool? MortgageHadCCJ { get; set; }
            public bool? MortgageAppliedIva { get; set; }
            public RateType? MortgageRateType { get; set; }
            public RepaymentType? MortgageRepaymentType { get; set; }
            public bool? MortgageIsAdverseCredit { get; set; }
            public DateTime? MortgageCreatedOn { get; set; }
            public DateTime? MortgageUpdatedOn { get; set; }

            public string MortgageCreatedBy { get; set; } = "";
            public string MortgageUpdatedBy { get; set; } = "";
            // public ActiveState? MortgageIsLeadDeleted { get; set; }


            //
            public int? HealthID { get; set; }
            public DateTime? HealthDOB { get; set; }
            public int? HealthAge { get; set; }
            public int? HealthPeriod { get; set; }
            public PensionPremiumTypeEnum? HealthPremiumType { get; set; }
            public InsuranceTypeEnum? HealthInsuranceTypeId { get; set; }
            public int? HealthFamilyMember { get; set; }
            public bool? HealthIsSmoker { get; set; }
            public int? HealthPremiumAmount { get; set; }
            public CoverFromTypeEnum? HealthCoverTypeHealth { get; set; }
            public DateTime? HealthGeneratedDate { get; set; }
            public int? HealthPartnerAge { get; set; }
            public bool? HealthExistingPolicy { get; set; }
            public DateTime? HealthCreatedOn { get; set; }
            public DateTime? HealthUpdatedOn { get; set; }
            public string HealthCreatedBy { get; set; } = "";
            public string HealthUpdatedBy { get; set; } = "";
            // public ActiveState? HealthDeleteStatus { get; set; } 

            //

            public int? CorporateHealthID { get; set; }
            public DateTime? CorporateHealthLeadsdob { get; set; }
            public int? CorporateHealthLeadsAge { get; set; }
            public string CorporateHealthCompanyName { get; set; } = "";
            public string CorporateHealthCompanyCity { get; set; } = "";
            public string CorporateHealthCompanyPostCode { get; set; } = "";
            public string CorporateHealthCompanyAddress { get; set; } = "";
            public EmployeeNumberEnum? CorporateHealthEmployeeNumber { get; set; }
            public string CorporateHealthPartnerGender { get; set; } = "";
            public DateTime? CorporateHealthCreatedOn { get; set; }
            public DateTime? CorporateHealthUpdatedOn { get; set; }
            public PensionPremiumTypeEnum? CorporateHealthPremiumTypeId { get; set; }
            public InsuranceTypeEnum? CorporateHealthTypeId { get; set; }
            public bool? CorporateHealthExistingPolicy { get; set; }
            public HealthCoverTypeEnum? CorporateHealthCorporateCoverTypeHealth { get; set; }
            // public ActiveState? CorporateHealthDeleteStatus { get; set; }
            public string CorporateHealthCreatedBy { get; set; } = "";
            public string CorporateHealthUpdatedBy { get; set; } = "";

            //


            public int? PensionID { get; set; }
            public DateTime? PensionGeneratedDate { get; set; }
            public int? PensionAge { get; set; }
            public DateTime? PensionDob { get; set; }
            public PersonalPensionTypeEnum? PersonalPensionType { get; set; }
            public PensionPremiumTypeEnum? PensionPremiumType { get; set; }
            public int? PensionValue { get; set; }
            public PensionTypeEnum? PensionType { get; set; }
            public PensionAccessFundEnum? PensionAccessFund { get; set; }
            public int? PensionExistPensions { get; set; }
            public string PensionTypeOther { get; set; } = "";
            public bool? PensionIsCurrentlyPayingMoney { get; set; }
            public DateTime? PensionCreatedOn { get; set; }
            public DateTime? PensionUpdatedOn { get; set; }
            public int? PensionTotalPensionValue { get; set; }
            public string PensionCreatedBy { get; set; } = "";
            public string PensionUpdatedBy { get; set; } = "";
            // public ActiveState? PensionDeleteStatus { get; set; }


            //

            public int? LifeID { get; set; }
            public int? LifeAge { get; set; }
            public DateTime? LifeDob { get; set; }
            public bool? LifeSingleOwnership { get; set; }
            public int? LifePeriod { get; set; }
            public DateTime? LifeCreatedOn { get; set; }
            public DateTime? LifeUpdatedOn { get; set; }
            public DateTime? LifeGeneratedDate { get; set; }
            public string LifeProductType { get; set; } = "";
            public string LifePartnersName { get; set; } = "";
            public string LifeAdditionalInformation { get; set; } = "";
            public bool? LifePartnerSmoker { get; set; }
            public bool? LifeIsSmoker { get; set; }
            public PensionPremiumTypeEnum? LifePremiumType { get; set; }
            public bool? LifeCriticalIllness { get; set; }
            public InsuranceTypeEnum? LifeInsuranceType { get; set; }
            public int? LifeAmount { get; set; }
            public DateTime? LifePartnerDob { get; set; }
            public string LifeCreatedBy { get; set; } = "";
            public string LifeUpdatedBy { get; set; } = "";
            // public ActiveState? LifeIsDeleted { get; set; }


            public int? DebtID { get; set; }
            public EmploymentStatus? DebtEmploymentStatus { get; set; }
            public PropertyLocation? DebtResidentialLocation { get; set; }
            public DebtTypeEnum? DebtType { get; set; }
            public bool? DebtHadCCJ { get; set; }
            public int? DebtTotalUnsecuredDebt { get; set; }
            public int? DebtTotalCreditors { get; set; }
            public int? DebtMonthlyRepayments { get; set; }
            public int? DebtMonthlyDisposable { get; set; }
            public int? DebtMonthlyIncome { get; set; }
            public int? DebtAge { get; set; }
            public DateTime? DebtDob { get; set; }
            public DateTime? DebtGeneratedDate { get; set; }
            public DateTime? DebtCreatedOn { get; set; }
            public DateTime? DebtUpdatedOn { get; set; }
            public string DebtCreatedBy { get; set; } = "";
            public string DebtUpdatedBy { get; set; } = "";
            public DebtCategory? DebtCategory { get; set; }
            public string DeptTypes { get; set; } = "";
            // public ActiveState? DebtIsDeleted { get; set; }

            //


            public int? AsuID { get; set; }
            public int? AsuAge { get; set; }
            public DateTime? AsuDob { get; set; }
            public int? AsuPeriod { get; set; }
            public bool? AsuSmoker { get; set; }
            public int? AsuAmount { get; set; }
            public DateTime? AsuGeneratedDate { get; set; }
            public DateTime? AsuCreatedOn { get; set; }
            public DateTime? AsuUpdatedOn { get; set; }
            public string AsuAdditionalInformation { get; set; } = "";
            public string AsuCreatedBy { get; set; } = "";
            public string AsuUpdatedBy { get; set; } = "";
            public ActiveState? AsuIsDeleted { get; set; }
            public CoverTypeEnum? AsuCoverType { get; set; }
            public CoverFromTypeEnum? AsuCoverFromType { get; set; }
            public IPASUEmploymentStatusEnum? AsuIPASUEmploymentStatus { get; set; }
            public PensionPremiumTypeEnum? AsuPremiumType { get; set; }



            //

            public int? FuneralID { get; set; }
            public int? FuneralAge { get; set; }
            public DateTime? FuneralDob { get; set; }
            public DateTime? FuneralGeneratedDate { get; set; }
            public DateTime? FuneralCreatedOn { get; set; }
            public DateTime? FuneralUpdatedOn { get; set; }
            public string FuneralCreatedBy { get; set; } = "";
            public string FuneralUpdatedBy { get; set; } = "";
            public ActiveState? FuneralIsDeleted { get; set; }

            //


            public int? EquityreleaseID { get; set; }
            public int? EquityreleaseAge { get; set; }
            public DateTime? EquityreleaseDob { get; set; }
            public int? EquityreleaseHomeValue { get; set; }
            public int? EquityreleaseOutstandingMortgageValue { get; set; }
            public int? EquityreleaseAgeType { get; set; }
            public int? EquityreleaseEquityType { get; set; }
            public DateTime? EquityreleaseGeneratedDate { get; set; }
            public DateTime? EquityreleaseCreatedOn { get; set; }
            public DateTime? EquityreleaseUpdatedOn { get; set; }
            public string EquityreleaseCreatedBy { get; set; } = "";
            public string EquityreleaseUpdatedBy { get; set; } = "";
            public ActiveState? EquityreleaseIsDeleted { get; set; }



            //


            public int? loanID { get; set; }
            public DateTime? LoanDob { get; set; }
            public int? LoanAge { get; set; }
            public LoanPurposeEnum? LoanPurpose { get; set; }
            public DateTime? LoanPreviousAddressSince { get; set; }
            public string LoanPreviousAddress { get; set; } = "";
            public string LoanPreviousPostCode { get; set; } = "";
            public string LoanPreviousCity { get; set; } = "";
            public string LoanEmployerName { get; set; } = "";
            public DateTime? LoanEmployerSince { get; set; }
            public string LoanOccupation { get; set; } = "";
            public bool? LoanBeenInDebt { get; set; }
            public bool? LoanGurantor { get; set; }
            public DateTime? LoanGeneratedDate { get; set; }
            public string LoanTotalCreditors { get; set; } = "";
            public string LoanGuarantorName { get; set; } = "";
            public string LoanGuarantorPhone { get; set; } = "";
            public string LoanGuarantorEmail { get; set; } = "";
            public int? LoanPeriod { get; set; }
            public LoanEmploymentStatusEnum? LoanEmploymentStatus { get; set; }
            public int? LoanMortgageLoanValue { get; set; }
            public CreditRatingEnum? LoanCreditRating { get; set; }
            public int? LoanAnnualIncome { get; set; }
            public LoanCountryOfResidenceEnum? LoanCountryOfResidenceget { get; set; }
            public MaritalStatusEnum? LoanMaritalStatus { get; set; }
            public int? LoanMortgageBalance { get; set; }
            public int? LoanPropertyValue { get; set; }
            public DateTime? LoanAddressStartDate { get; set; }
            public bool? loanHomeOwner { get; set; }
            public bool? LoanHadBankruptcy { get; set; }
            public DateTime? LoanCreatedOn { get; set; }
            public DateTime? LoanUpdatedOn { get; set; }
            public string LoanCreatedBy { get; set; } = "";
            public string LoanUpdatedBy { get; set; } = "";
            public ActiveState? LoanDeleteStatus { get; set; }

        }
    }
