
using ProjectOnFinalIlds.Models.UtilityObjects;
using ProjectOnFinalIlds.Models.UtilityObjects.HealthEnum;
using ProjectOnFinalIlds.Models.UtilityObjects.LoanEnum;
using ProjectOnFinalIlds.Models.UtilityObjects.PPIEnum;
using System;

namespace ProjectOnFinalIlds.UtilityObjects
{
    public class AllFieldCapture
    {
        public int LeadId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Postcode { get; set; } = string.Empty;
        public string WorkPhone { get; set; } = string.Empty;
        public string HomePhone { get; set; } = string.Empty;
        public string Address1 { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Description { get; set; }
        //public int MortgageTypeId { get; set; }

        public DateTime Dob { get; set; } = DateTime.Parse(System.Data.SqlTypes.SqlDateTime.MinValue.ToString());
        public int Period { get; set; }
        public int SiteId { get; set; }


        public string ProductName { get; set; } = string.Empty;
        public string OperatorName { get; set; } = string.Empty;
        public string OperatorSpecificComments { get; set; } = string.Empty;
        public DateTime GeneratedDate { get; set; } = DateTime.Now;
        public int PropertyValue { get; set; }
        public int LoanValue { get; set; }
        public RateType RateType { get; set; }
        public RepaymentType RepaymentType { get; set; }
        public PropertyType PropertyType { get; set; }
        public PropertyLocation PropertyLocation { get; set; }
        public int CurrentDebt { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public int AnnualIncome { get; set; }
        public CreditHistory CreditHistory { get; set; }
        public bool MissAnyLoan { get; set; }
        public bool HadBankruptcy { get; set; }
        public bool AppliedIva { get; set; }
        public bool HadCcj { get; set; }
        public bool Opt { get; set; } = true;
        public bool AdverseCredit { get; set; }
        public LeadStatusEnum LeadStatus { get; set; }

        public string Source { get; set; } = string.Empty;
        public string Keyword { get; set; } = string.Empty;
        public string MatchType { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public int Age { get; set; }


        //Life Leads
        public bool SingleOwnership { get; set; }
        public bool Smoker { get; set; }
        public PensionPremiumTypeEnum PremiumType { get; set; }
        public bool CriticalIllness { get; set; }
        public InsuranceTypeEnum InsuranceType { get; set; }
        public int Amount { get; set; }
        public string ProductType { get; set; } = string.Empty;
        public CoverTypeEnum CoverType { get; set; }
        public CoverFromTypeEnum CoverFromType { get; set; }
        public IPASUEmploymentStatusEnum IPASUEmploymentStatus { get; set; }
        public string PartnerTitle { get; set; } = string.Empty;
        public string PartnerFirstName { get; set; } = string.Empty;
        public string PartnerLastName { get; set; } = string.Empty;
        public bool PartnerSmoker { get; set; }
        public DateTime? PartnerDob { get; set; }
        public string AdditionalInformation { get; set; } = string.Empty;


        //Loan Specific Fields

        public LoanEmploymentStatusEnum LoanEmploymentStatus { get; set; }
        public LoanPurposeEnum LoanPurpose { get; set; }


        public DateTime? PreviousAddressSince { get; set; }

        public string PreviousPostCode { get; set; } = string.Empty;
        public string PreviousCity { get; set; } = string.Empty;

        public string PreviousAddress { get; set; } = string.Empty;
        public CreditRatingEnum LoanCreditRating { get; set; }
        public DateTime? AddressStartDate { get; set; }
        public DateTime? EmployedSince { get; set; }
        public string EmployerName { get; set; } = string.Empty;

        public string Occupation { get; set; } = string.Empty;
        public bool BeenInDebt { get; set; }

        public bool LoanGuarantor { get; set; }

        public string TotalCreditors { get; set; }
        public int? LoanAnnualIncome { get; set; }

        public int LoanCountryOfResidence { get; set; }
        public MaritalStatusEnum LoanMaritalStatus { get; set; }

        public int MortgageBalance { get; set; }
        public int? LoanPropertyValue { get; set; }
        public bool? HomeOwner { get; set; }

        public int MortgageLoanValue { get; set; }

        //Equity Release leads
        public int HomeValue { get; set; }
        public int? OutstandingMortgageValue { get; set; }

        //Medical leads

        public int PremiumTypeId { get; set; }

        public int InsuranceTypeId { get; set; }

        public int? FamilyNumber { get; set; }
        public String PartnerGender { get; set; }
        public HealthCoverTypeEnum CoverTypeHealth { get; set; }
        public int? PartnerAge { get; set; }

        public bool ExistingPolicy { get; set; }

        //corporate medical insurance
        public int CorporateCoverTypeHealth { get; set; }

        public string CompanyName { get; set; } = string.Empty;


        public string CompanyPostCode { get; set; } = string.Empty;

        public string CompanyCity { get; set; } = string.Empty;

        public string CompanyAddress { get; set; } = string.Empty;
        public EmployeeNumberEnum EmployeeNumber { get; set; }
        //debt
        public DebtEmploymentStatusEnum DebtEmploymentStatus { get; set; }
        public ResidentialStatusEnum ResidentialStatus { get; set; }
        public PropertyLocation ResidentialLocation { get; set; }
        //public bool HadCCJ { get; set; }
        public DebtTypeEnum DebtType { get; set; }
        public DebtTypeEnum DebtCategory { get; set; }
        public string DebtTypes { get; set; }
        public int TotalUnsecuredDebt { get; set; }
        //public int TotalCreditors { get; set; }
        public int MonthlyRepayments { get; set; }
        public int MonthlyDisposable { get; set; }
        public int MonthlyIncome { get; set; }

        //LogBookLoan
        //public int Amount { get; set; }
        public string NumberPlate { get; set; }
        public int CurrentMileage { get; set; }
        public bool ClearOfFinance { get; set; }
        public LogBookLoanCountryResidenceEnum LogBookLoanCountryResidence { get; set; }
        public ContactTimeEnum ContactTime { get; set; } = ContactTimeEnum.anytime;
        public string CarMake { get; set; } = string.Empty;
        public string CarModel { get; set; } = string.Empty;
        public int CarRegistrationYear { get; set; }
        //public bool Opt { get; set; }

        //Solar
        public ProjectOnFinalIlds.Models.UtilityObjects.SolarPropertyTypeEnum SolarPropertyType { get; set; }
        public SolarPropertyOwnershipEnum PropertyOwnership { get; set; }
        //public bool Opt { get; set; }
        //ppi
        public LoanStatusEnum LoanStatus { get; set; }
        public PPIEmploymentStatusEnum PPIEmploymentStatus { get; set; }

        //Pension fields
        public PersonalPensionTypeEnum? PersonalPensionType { get; set; }
        public PensionPremiumTypeEnum? PensionPremiumType { get; set; }
        public int PensionValue { get; set; }
        public PensionTypeEnum? PensionType { get; set; }
        public PensionAccessFundEnum? PensionAccessFund { get; set; }
        public int ExistPensions { get; set; }
        //public bool Opt { get; set; } = true;
        public string PensionTypeOther { get; set; } = string.Empty;
        public bool IsCurrentlyPayingMoney { get; set; } = false;

        // public string OrganizationName { get; set; }
        public string OrganizationHashCode { get; set; } = string.Empty;

        public int OrganizationMasterId { get; set; }

        public LeadCategoryEnum LeadCategory { get; set; } = LeadCategoryEnum.CompleteForm;

        //Email Sending Required
        public bool ESR { get; set; } = false;
        public string LeadComment { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public MailType MailType { get; set; }
        public string UserAgent { get; set; } = string.Empty;
        public string Query { get; set; } = string.Empty;

        //injuryClaim fields
        public InjureTime InjureTime { get; set; }
        public ProjectOnFinalIlds.Models.UtilityObjects.AccidentType AccidentType { get; set; }
        public bool IsMedicalAttention { get; set; }
        public bool IsAlreadyClaimed { get; set; }
        public string AccidentLocation { get; set; }
    }
}
