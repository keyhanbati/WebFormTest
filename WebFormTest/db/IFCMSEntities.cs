using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebFormTest.db
{
    public partial class IFCMSEntities : DbContext
    {
        public IFCMSEntities()
            : base("name=IFCMSEntities")
        {
        }

        public virtual DbSet<AccountBalances> AccountBalances { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<ApiLogs> ApiLogs { get; set; }
        public virtual DbSet<NationalCodes> NationalCodes { get; set; }
        public virtual DbSet<BasicInformationDetails> BasicInformationDetails { get; set; }
        public virtual DbSet<BasicInformations> BasicInformations { get; set; }
        public virtual DbSet<BranPercentages> BranPercentages { get; set; }
        public virtual DbSet<BuyerPerformanceGoups> BuyerPerformanceGoups { get; set; }
        public virtual DbSet<CarPlateLetters> CarPlateLetters { get; set; }
        public virtual DbSet<CountryDivisionCoordinates> CountryDivisionCoordinates { get; set; }
        public virtual DbSet<CountryDivisions> CountryDivisions { get; set; }
        public virtual DbSet<CountryDivisionsFlat> CountryDivisionsFlat { get; set; }
        public virtual DbSet<DotinRsCodes> DotinRsCodes { get; set; }
        public virtual DbSet<HolidayCalendarCountryDivisions> HolidayCalendarCountryDivisions { get; set; }
        public virtual DbSet<HolidayCalendars> HolidayCalendars { get; set; }
        public virtual DbSet<Intervals> Intervals { get; set; }
        public virtual DbSet<OrganizationCountryDivisions> OrganizationCountryDivisions { get; set; }
        public virtual DbSet<Organizations> Organizations { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<PhaseProductTemplates> PhaseProductTemplates { get; set; }
        public virtual DbSet<Phases> Phases { get; set; }
        public virtual DbSet<PopulationInfo> PopulationInfo { get; set; }
        public virtual DbSet<QoutaIncerasePercentages> QoutaIncerasePercentages { get; set; }
        public virtual DbSet<QuotaPhaseConfiguration> QuotaPhaseConfiguration { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SupportContact> SupportContact { get; set; }
        public virtual DbSet<ValidColumnNames> ValidColumnNames { get; set; }
        public virtual DbSet<BuyerAgents> BuyerAgents { get; set; }
        public virtual DbSet<BuyerAsnafStatuses> BuyerAsnafStatuses { get; set; }
        public virtual DbSet<BuyerBankCards> BuyerBankCards { get; set; }
        public virtual DbSet<BuyerComments> BuyerComments { get; set; }
        public virtual DbSet<BuyerConsumptionTypes> BuyerConsumptionTypes { get; set; }
        public virtual DbSet<BuyerCookingSubTypes> BuyerCookingSubTypes { get; set; }
        public virtual DbSet<BuyerCookingTypes> BuyerCookingTypes { get; set; }
        public virtual DbSet<BuyerDismissals> BuyerDismissals { get; set; }
        public virtual DbSet<BuyerDismissalStatuses> BuyerDismissalStatuses { get; set; }
        public virtual DbSet<BuyerFacilities> BuyerFacilities { get; set; }
        public virtual DbSet<BuyerFiles> BuyerFiles { get; set; }
        public virtual DbSet<BuyerGroupBuyers> BuyerGroupBuyers { get; set; }
        public virtual DbSet<BuyerGroups> BuyerGroups { get; set; }
        public virtual DbSet<BuyerInfoCorrections> BuyerInfoCorrections { get; set; }
        public virtual DbSet<BuyerInfoCorrectionsOldData> BuyerInfoCorrectionsOldData { get; set; }
        public virtual DbSet<BuyerInfoCorrectionStatuses> BuyerInfoCorrectionStatuses { get; set; }
        public virtual DbSet<BuyerMonths> BuyerMonths { get; set; }
        public virtual DbSet<BuyerOwners> BuyerOwners { get; set; }
        public virtual DbSet<BuyerPos> BuyerPos { get; set; }
        public virtual DbSet<BuyerProductTemplateLogs> BuyerProductTemplateLogs { get; set; }
        public virtual DbSet<BuyerProductTemplates> BuyerProductTemplates { get; set; }
        public virtual DbSet<BuyerPurchaseTypes> BuyerPurchaseTypes { get; set; }
        public virtual DbSet<Buyers> Buyers { get; set; }
        public virtual DbSet<BuyerScores> BuyerScores { get; set; }
        public virtual DbSet<BuyerStatuses> BuyerStatuses { get; set; }
        public virtual DbSet<BuyerSubCountryDivisionIds> BuyerSubCountryDivisionIds { get; set; }
        public virtual DbSet<RawFlourDetailFileImportLogs> RawFlourDetailFileImportLogs { get; set; }
        public virtual DbSet<RawFlourDetailImportLogMessages> RawFlourDetailImportLogMessages { get; set; }
        public virtual DbSet<RawFlourDetails> RawFlourDetails { get; set; }
        public virtual DbSet<Banks> Banks { get; set; }
        public virtual DbSet<CallCount> CallCount { get; set; }
        public virtual DbSet<CdcExceptTable> CdcExceptTable { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UnitDegrees> UnitDegrees { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<UnitTypes> UnitTypes { get; set; }
        public virtual DbSet<GflourInquiryDetails> GflourInquiryDetails { get; set; }
        public virtual DbSet<ProductInventories> ProductInventories { get; set; }
        public virtual DbSet<WheatInventories> WheatInventories { get; set; }
        public virtual DbSet<BranPercentageLimitations> BranPercentageLimitations { get; set; }
        public virtual DbSet<BuyerReceiptLimitations> BuyerReceiptLimitations { get; set; }
        public virtual DbSet<BuyerTransportTypeLimitations> BuyerTransportTypeLimitations { get; set; }
        public virtual DbSet<DealingAmountLimitations> DealingAmountLimitations { get; set; }
        public virtual DbSet<DealingLimitations> DealingLimitations { get; set; }
        public virtual DbSet<DealingSeperateLimitations> DealingSeperateLimitations { get; set; }
        public virtual DbSet<TaxLimitations> TaxLimitations { get; set; }
        public virtual DbSet<TransportLimitations> TransportLimitations { get; set; }
        public virtual DbSet<Yeast> Yeast { get; set; }
        public virtual DbSet<QuotaFileDetailsExportLog> QuotaFileDetailsExportLog { get; set; }
        public virtual DbSet<QuotaFileHeaderExportLog> QuotaFileHeaderExportLog { get; set; }
        public virtual DbSet<MessageReceivers> MessageReceivers { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MessageSendLogs> MessageSendLogs { get; set; }
        public virtual DbSet<NaninoBuyerCookingTypes> NaninoBuyerCookingTypes { get; set; }
        public virtual DbSet<NaninoBuyerDiscrepancies> NaninoBuyerDiscrepancies { get; set; }
        public virtual DbSet<NaninoBuyerDiscrepancyStatuses> NaninoBuyerDiscrepancyStatuses { get; set; }
        public virtual DbSet<NaninoBuyerPos> NaninoBuyerPos { get; set; }
        public virtual DbSet<NaninoBuyerPosSubmitLog> NaninoBuyerPosSubmitLog { get; set; }
        public virtual DbSet<NaninoBuyers> NaninoBuyers { get; set; }
        public virtual DbSet<NaninoBuyerSaleAggregates> NaninoBuyerSaleAggregates { get; set; }
        public virtual DbSet<NaninoBuyerStatusReportLog> NaninoBuyerStatusReportLog { get; set; }
        public virtual DbSet<NaninoCookingTypes> NaninoCookingTypes { get; set; }
        public virtual DbSet<NaninoProvinces> NaninoProvinces { get; set; }
        public virtual DbSet<NaninoViolationTypes> NaninoViolationTypes { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }
        public virtual DbSet<PaymentInstallmentDetails> PaymentInstallmentDetails { get; set; }
        public virtual DbSet<PaymentItems> PaymentItems { get; set; }
        public virtual DbSet<PaymentOperationDetails> PaymentOperationDetails { get; set; }
        public virtual DbSet<PaymentOperations> PaymentOperations { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentStatuses> PaymentStatuses { get; set; }
        public virtual DbSet<PaymentToken> PaymentToken { get; set; }
        public virtual DbSet<PaymentTokenStatuses> PaymentTokenStatuses { get; set; }
        public virtual DbSet<Packages> Packages { get; set; }
        public virtual DbSet<ProductDetails> ProductDetails { get; set; }
        public virtual DbSet<ProductRates> ProductRates { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductTemplateBranPercentages> ProductTemplateBranPercentages { get; set; }
        public virtual DbSet<ProductTemplates> ProductTemplates { get; set; }
        public virtual DbSet<SalePlanInstallments> SalePlanInstallments { get; set; }
        public virtual DbSet<SalesPlans> SalesPlans { get; set; }
        public virtual DbSet<FlourSalesDetails> FlourSalesDetails { get; set; }
        public virtual DbSet<QuotaFileImportLogDetails> QuotaFileImportLogDetails { get; set; }
        public virtual DbSet<QuotaFileImportLogMessages> QuotaFileImportLogMessages { get; set; }
        public virtual DbSet<QuotaFileImportLogs> QuotaFileImportLogs { get; set; }
        public virtual DbSet<Quotations> Quotations { get; set; }
        public virtual DbSet<QutaBatchLogDetails> QutaBatchLogDetails { get; set; }
        public virtual DbSet<QutaBatchLogs> QutaBatchLogs { get; set; }
        public virtual DbSet<UserCountryDivisions> UserCountryDivisions { get; set; }
        public virtual DbSet<UserEntities> UserEntities { get; set; }
        public virtual DbSet<SellerPersons> SellerPersons { get; set; }
        public virtual DbSet<SellerProducts> SellerProducts { get; set; }
        public virtual DbSet<SellerProductTemplates> SellerProductTemplates { get; set; }
        public virtual DbSet<SellerRates> SellerRates { get; set; }
        public virtual DbSet<Sellers> Sellers { get; set; }
        public virtual DbSet<SellerStatuses> SellerStatuses { get; set; }
        public virtual DbSet<SellerSuspensions> SellerSuspensions { get; set; }
        public virtual DbSet<SellerTransportTypes> SellerTransportTypes { get; set; }
        public virtual DbSet<ShipmentInfoSubmitLogs> ShipmentInfoSubmitLogs { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<CarTypes> CarTypes { get; set; }
        public virtual DbSet<DriverCars> DriverCars { get; set; }
        public virtual DbSet<DriverCarTransportationCompanies> DriverCarTransportationCompanies { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<DriverTransportationCompanies> DriverTransportationCompanies { get; set; }
        public virtual DbSet<ShipmentCosts> ShipmentCosts { get; set; }
        public virtual DbSet<ShipmentInfoDetails> ShipmentInfoDetails { get; set; }
        public virtual DbSet<ShipmentInfos> ShipmentInfos { get; set; }
        public virtual DbSet<ShipmentInfoStatuses> ShipmentInfoStatuses { get; set; }
        public virtual DbSet<ShipmentInquiries> ShipmentInquiries { get; set; }
        public virtual DbSet<ShipmentInquiryDetails> ShipmentInquiryDetails { get; set; }
        public virtual DbSet<ShipmentPlatforms> ShipmentPlatforms { get; set; }
        public virtual DbSet<Shipments> Shipments { get; set; }
        public virtual DbSet<ShipmentStatuses> ShipmentStatuses { get; set; }
        public virtual DbSet<TransportationCompanies> TransportationCompanies { get; set; }
        public virtual DbSet<SendSmsDetailLog> SendSmsDetailLog { get; set; }
        public virtual DbSet<SendSmsMainLog> SendSmsMainLog { get; set; }
        public virtual DbSet<Support> Support { get; set; }
        public virtual DbSet<SuppotStatuses> SuppotStatuses { get; set; }
        public virtual DbSet<QuotaFiles> QuotaFiles { get; set; }
        public virtual DbSet<SyfaOstanCodes> SyfaOstanCodes { get; set; }
        public virtual DbSet<SyfaUseTypes> SyfaUseTypes { get; set; }
        public virtual DbSet<WheatImportInfos> WheatImportInfos { get; set; }
        public virtual DbSet<WheatImportLogs> WheatImportLogs { get; set; }
        public virtual DbSet<WheatImports> WheatImports { get; set; }
        public virtual DbSet<OrderInquiries> OrderInquiries { get; set; }
        public virtual DbSet<OrdersInquiryRequests> OrdersInquiryRequests { get; set; }
        public virtual DbSet<CountryDivisionsback_1402_09_04> CountryDivisionsback_1402_09_04 { get; set; }
        public virtual DbSet<CountryDivisionsFlatback_1402_09_04> CountryDivisionsFlatback_1402_09_04 { get; set; }
        public virtual DbSet<PersonsHistory> PersonsHistory { get; set; }
        public virtual DbSet<PersonUpdateLogs> PersonUpdateLogs { get; set; }
        public virtual DbSet<C___Buyers> C___Buyers { get; set; }
        public virtual DbSet<C__Buyers14020824> C__Buyers14020824 { get; set; }
        public virtual DbSet<C__BuyerStatuses14020913> C__BuyerStatuses14020913 { get; set; }
        public virtual DbSet<BuyerMaping> BuyerMaping { get; set; }
        public virtual DbSet<Population_Amar> Population_Amar { get; set; }
        public virtual DbSet<ShipmentInfoStatusItemsLog> ShipmentInfoStatusItemsLog { get; set; }
        public virtual DbSet<ShipmentInfoStatusItemsLogs> ShipmentInfoStatusItemsLogs { get; set; }
        public virtual DbSet<TempMessage> TempMessage { get; set; }
        public virtual DbSet<TempProductInventories> TempProductInventories { get; set; }
        public virtual DbSet<TempWheatInventories> TempWheatInventories { get; set; }
        public virtual DbSet<C__NaninoBuyerSales14020722> C__NaninoBuyerSales14020722 { get; set; }
        public virtual DbSet<BuyerFraud> BuyerFraud { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<SubTicket> SubTicket { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketAccessLimitation> TicketAccessLimitation { get; set; }
        public virtual DbSet<ViewCountryDivisions> ViewCountryDivisions { get; set; }
        public virtual DbSet<vmGenerateCountryDivisionFlat> vmGenerateCountryDivisionFlat { get; set; }
        public virtual DbSet<vwCountryDivision_Pivot> vwCountryDivision_Pivot { get; set; }
        public virtual DbSet<ViewOrder> ViewOrder { get; set; }
        public virtual DbSet<vwAllBanksUnits> vwAllBanksUnits { get; set; }
        public virtual DbSet<vwAllUsers> vwAllUsers { get; set; }
        public virtual DbSet<vwBuyerInfo> vwBuyerInfo { get; set; }
        public virtual DbSet<vwCountryDivisions> vwCountryDivisions { get; set; }
        public virtual DbSet<vwUnits> vwUnits { get; set; }
        public virtual DbSet<vwUsers> vwUsers { get; set; }
        public virtual DbSet<AllFiles> AllFiles { get; set; }
        public virtual DbSet<AllFilesPro> AllFilesPro { get; set; }
        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<AsnafLogs> AsnafLogs { get; set; }
        public virtual DbSet<DotinLogs> DotinLogs { get; set; }
        public virtual DbSet<Histories> Histories { get; set; }
        public virtual DbSet<JobLogs> JobLogs { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<PaylaLogs> PaylaLogs { get; set; }
        public virtual DbSet<ServiceLogs> ServiceLogs { get; set; }
        public virtual DbSet<NaninoBuyerSales> NaninoBuyerSales { get; set; }
        public virtual DbSet<NaninoBuyerViolations> NaninoBuyerViolations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountBalances>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<AccountBalances>()
                .Property(e => e.BalanceAmount)
                .HasPrecision(20, 0);

            modelBuilder.Entity<Accounts>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts>()
                .Property(e => e.CustomerNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts>()
                .Property(e => e.AccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts>()
                .Property(e => e.BranchCode)
                .IsUnicode(false);

            modelBuilder.Entity<Accounts>()
                .Property(e => e.OwnerPercent)
                .HasPrecision(5, 2);

            modelBuilder.Entity<NationalCodes>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<BasicInformationDetails>()
                .Property(e => e.Coding)
                .IsUnicode(false);

            modelBuilder.Entity<BasicInformationDetails>()
                .HasMany(e => e.BasicInformationDetails1)
                .WithOptional(e => e.BasicInformationDetails2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<BasicInformationDetails>()
                .HasMany(e => e.QuotaPhaseConfiguration)
                .WithRequired(e => e.BasicInformationDetails)
                .HasForeignKey(e => e.QuotaPhaseConfigurationTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BasicInformations>()
                .Property(e => e.Coding)
                .IsUnicode(false);

            modelBuilder.Entity<BasicInformations>()
                .HasMany(e => e.BasicInformationDetails)
                .WithRequired(e => e.BasicInformations)
                .HasForeignKey(e => e.BaseInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BasicInformations>()
                .HasMany(e => e.BasicInformations1)
                .WithOptional(e => e.BasicInformations2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<BranPercentages>()
                .Property(e => e.Percentage)
                .HasPrecision(5, 2);

            modelBuilder.Entity<BranPercentages>()
                .HasMany(e => e.BranPercentageLimitations)
                .WithRequired(e => e.BranPercentages)
                .HasForeignKey(e => e.BranPercentageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BranPercentages>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.BranPercentages)
                .HasForeignKey(e => e.BranPercentageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisionCoordinates>()
                .Property(e => e.Latitude)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CountryDivisionCoordinates>()
                .Property(e => e.Longitude)
                .HasPrecision(18, 8);

            modelBuilder.Entity<CountryDivisionCoordinates>()
                .Property(e => e.HCKey)
                .IsUnicode(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.BranPercentageLimitations)
                .WithOptional(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerProvinceId);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.BuyerReceiptLimitations)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.Buyers)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.BuyerSubCountryDivisionIds)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.BuyerTransportTypeLimitations)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.CountryDivisions1)
                .WithOptional(e => e.CountryDivisions2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.DealingAmountLimitations)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.DealingLimitations)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.DealingLimitations1)
                .WithRequired(e => e.CountryDivisions1)
                .HasForeignKey(e => e.SellerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.DealingSeperateLimitations)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.HolidayCalendarCountryDivisions)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.OrganizationCountryDivisions)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.Phases)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.PopulationInfo)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.QuotaPhaseConfiguration)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.ProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.Sellers)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.ShipmentCosts)
                .WithOptional(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerCountyId);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.ShipmentCosts1)
                .WithRequired(e => e.CountryDivisions1)
                .HasForeignKey(e => e.BuyerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.ShipmentCosts2)
                .WithRequired(e => e.CountryDivisions2)
                .HasForeignKey(e => e.SellerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.ShipmentPlatforms)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.ProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.TransportationCompanies)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.ProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.TransportationCompanies1)
                .WithOptional(e => e.CountryDivisions1)
                .HasForeignKey(e => e.CountyId);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.UserCountryDivisions)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.CountryDivisionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.Yeast)
                .WithRequired(e => e.CountryDivisions)
                .HasForeignKey(e => e.BuyerProvinceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountryDivisions>()
                .HasMany(e => e.Yeast1)
                .WithOptional(e => e.CountryDivisions1)
                .HasForeignKey(e => e.BuyerCountyId);

            modelBuilder.Entity<HolidayCalendars>()
                .HasMany(e => e.HolidayCalendarCountryDivisions)
                .WithRequired(e => e.HolidayCalendars)
                .HasForeignKey(e => e.HolidayCalendarId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intervals>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Intervals)
                .HasForeignKey(e => e.IntervalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intervals>()
                .HasMany(e => e.Phases)
                .WithRequired(e => e.Intervals)
                .HasForeignKey(e => e.IntervalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intervals>()
                .HasMany(e => e.ProductInventories)
                .WithRequired(e => e.Intervals)
                .HasForeignKey(e => e.IntervalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Intervals>()
                .HasMany(e => e.TransportLimitations)
                .WithOptional(e => e.Intervals)
                .HasForeignKey(e => e.IntervalId);

            modelBuilder.Entity<Organizations>()
                .HasMany(e => e.OrganizationCountryDivisions)
                .WithRequired(e => e.Organizations)
                .HasForeignKey(e => e.OrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organizations>()
                .HasMany(e => e.Buyers)
                .WithOptional(e => e.Organizations)
                .HasForeignKey(e => e.OrganizationId);

            modelBuilder.Entity<Persons>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Persons>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<Persons>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Persons>()
                .HasMany(e => e.BuyerAgents)
                .WithRequired(e => e.Persons)
                .HasForeignKey(e => e.PersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persons>()
                .HasMany(e => e.BuyerOwners)
                .WithRequired(e => e.Persons)
                .HasForeignKey(e => e.PersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persons>()
                .HasMany(e => e.SellerPersons)
                .WithRequired(e => e.Persons)
                .HasForeignKey(e => e.PersonId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phases>()
                .HasMany(e => e.PhaseProductTemplates)
                .WithRequired(e => e.Phases)
                .HasForeignKey(e => e.PhaseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phases>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Phases)
                .HasForeignKey(e => e.PhaseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phases>()
                .HasMany(e => e.RawFlourDetailFileImportLogs)
                .WithRequired(e => e.Phases)
                .HasForeignKey(e => e.PhaseId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuotaPhaseConfiguration>()
                .Property(e => e.QuotaPhaseConfigurationTypeValue)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ValidColumnNames>()
                .Property(e => e.ColumnName)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerAgents>()
                .Property(e => e.MainAccount)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerDismissals>()
                .HasMany(e => e.BuyerDismissalStatuses)
                .WithRequired(e => e.BuyerDismissals)
                .HasForeignKey(e => e.BuyerDismissalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuyerGroups>()
                .HasMany(e => e.BuyerGroupBuyers)
                .WithRequired(e => e.BuyerGroups)
                .HasForeignKey(e => e.BuyerGroupId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuyerInfoCorrections>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerInfoCorrections>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerInfoCorrections>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerInfoCorrections>()
                .Property(e => e.BusinessLicense)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerInfoCorrections>()
                .HasMany(e => e.BuyerInfoCorrectionStatuses)
                .WithRequired(e => e.BuyerInfoCorrections)
                .HasForeignKey(e => e.BuyerInfoCorrectionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BuyerInfoCorrectionsOldData>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerInfoCorrectionsOldData>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerInfoCorrectionsOldData>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerInfoCorrectionsOldData>()
                .Property(e => e.BusinessLicense)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .Property(e => e.BusinessLicense)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .Property(e => e.GasReceiptSubscriptionNo)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .Property(e => e.ElectricityReceiptId)
                .IsUnicode(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerAgents)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerBankCards)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerComments)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerConsumptionTypes)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerCookingTypes)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerDismissals)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerFacilities)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerGroupBuyers)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerInfoCorrections)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerMonths)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerOwners)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerPos)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerProductTemplates)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerPurchaseTypes)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BranPercentageLimitations)
                .WithOptional(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerReceiptLimitations)
                .WithOptional(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.Buyers1)
                .WithOptional(e => e.Buyers2)
                .HasForeignKey(e => e.DistributeParentBuyerId);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.Buyers11)
                .WithOptional(e => e.Buyers3)
                .HasForeignKey(e => e.RawFlourParentBuyerId);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerScores)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerStatuses)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerSubCountryDivisionIds)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.BuyerTransportTypeLimitations)
                .WithOptional(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.DealingLimitations)
                .WithOptional(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.FlourSalesDetails)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.NaninoBuyers)
                .WithOptional(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.RawFlourDetailFileImportLogs)
                .WithRequired(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Buyers>()
                .HasMany(e => e.TransportLimitations)
                .WithOptional(e => e.Buyers)
                .HasForeignKey(e => e.BuyerId);

            modelBuilder.Entity<BuyerScores>()
                .Property(e => e.InspectionScore)
                .HasPrecision(2, 1);

            modelBuilder.Entity<BuyerScores>()
                .Property(e => e.PeoplesScore)
                .HasPrecision(2, 1);

            modelBuilder.Entity<BuyerScores>()
                .Property(e => e.FunctionalScore)
                .HasPrecision(2, 1);

            modelBuilder.Entity<RawFlourDetailFileImportLogs>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<RawFlourDetailFileImportLogs>()
                .HasMany(e => e.RawFlourDetailImportLogMessages)
                .WithRequired(e => e.RawFlourDetailFileImportLogs)
                .HasForeignKey(e => e.RawFlourDetailFileImportLogId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RawFlourDetails>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<RawFlourDetails>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Banks>()
                .HasMany(e => e.BuyerBankCards)
                .WithRequired(e => e.Banks)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banks>()
                .HasMany(e => e.Units)
                .WithRequired(e => e.Banks)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CallCount>()
                .Property(e => e.SPNAME)
                .IsFixedLength();

            modelBuilder.Entity<Units>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.Units)
                .HasForeignKey(e => e.BankUnitId);

            modelBuilder.Entity<Units>()
                .HasMany(e => e.Units1)
                .WithOptional(e => e.Units2)
                .HasForeignKey(e => e.ParentUnitID);

            modelBuilder.Entity<GflourInquiryDetails>()
                .Property(e => e.SepratingRate)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Yeast>()
                .Property(e => e.Amount)
                .HasPrecision(5, 3);

            modelBuilder.Entity<QuotaFileDetailsExportLog>()
                .Property(e => e.File_BuyerCookingTypes)
                .IsUnicode(false);

            modelBuilder.Entity<QuotaFileDetailsExportLog>()
                .Property(e => e.File_FunctionalPercent)
                .HasPrecision(10, 2);

            modelBuilder.Entity<QuotaFileHeaderExportLog>()
                .HasMany(e => e.QuotaFileDetailsExportLog)
                .WithRequired(e => e.QuotaFileHeaderExportLog)
                .HasForeignKey(e => e.frkQuotaFileHeaderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MessageReceivers>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MessageReceivers>()
                .HasMany(e => e.MessageSendLogs)
                .WithRequired(e => e.MessageReceivers)
                .HasForeignKey(e => e.MessageReceiverId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Messages>()
                .HasMany(e => e.MessageReceivers)
                .WithRequired(e => e.Messages)
                .HasForeignKey(e => e.MessageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaninoBuyerCookingTypes>()
                .Property(e => e.ConvertRatio)
                .HasPrecision(3, 3);

            modelBuilder.Entity<NaninoBuyerDiscrepancies>()
                .HasMany(e => e.NaninoBuyerDiscrepancyStatuses)
                .WithRequired(e => e.NaninoBuyerDiscrepancies)
                .HasForeignKey(e => e.NaninoBuyerDiscrepancyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NaninoBuyers>()
                .Property(e => e.BuyerCode)
                .IsUnicode(false);

            modelBuilder.Entity<NaninoBuyers>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<NaninoBuyers>()
                .Property(e => e.CityCode)
                .IsUnicode(false);

            modelBuilder.Entity<NaninoBuyers>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<NaninoBuyers>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<NaninoBuyers>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<NaninoBuyers>()
                .HasMany(e => e.NaninoBuyerCookingTypes)
                .WithOptional(e => e.NaninoBuyers)
                .HasForeignKey(e => e.NaninoBuyerId);

            modelBuilder.Entity<NaninoBuyers>()
                .HasMany(e => e.NaninoBuyerPos)
                .WithOptional(e => e.NaninoBuyers)
                .HasForeignKey(e => e.NaninoBuyerId);

            modelBuilder.Entity<NaninoBuyerSaleAggregates>()
                .Property(e => e.FlourSaleAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NaninoBuyerSaleAggregates>()
                .Property(e => e.FlourSaleAmountWithFraud)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NaninoCookingTypes>()
                .HasMany(e => e.NaninoBuyerCookingTypes)
                .WithOptional(e => e.NaninoCookingTypes)
                .HasForeignKey(e => e.NaninoCookingTypeId);

            modelBuilder.Entity<NaninoProvinces>()
                .Property(e => e.ProvinceCode)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItems>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<OrderItems>()
                .HasMany(e => e.ProductRates)
                .WithRequired(e => e.OrderItems)
                .HasForeignKey(e => e.OrderItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItems>()
                .HasMany(e => e.SellerRates)
                .WithRequired(e => e.OrderItems)
                .HasForeignKey(e => e.OrderItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItems>()
                .HasMany(e => e.ShipmentInfoDetails)
                .WithRequired(e => e.OrderItems)
                .HasForeignKey(e => e.OrderItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItems>()
                .HasMany(e => e.ShipmentInquiryDetails)
                .WithRequired(e => e.OrderItems)
                .HasForeignKey(e => e.OrderItemId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.ProductInventories)
                .WithOptional(e => e.Orders)
                .HasForeignKey(e => e.OrderId);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Shipments)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderStatuses)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.OrderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderStatuses>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInstallmentDetails>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.PaymentInstallmentDetails)
                .HasForeignKey(e => e.PaymentInstallmentDetailId);

            modelBuilder.Entity<PaymentItems>()
                .Property(e => e.SourceAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentItems>()
                .Property(e => e.DestinationAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentItems>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentOperations>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentOperations>()
                .HasMany(e => e.PaymentOperationDetails)
                .WithRequired(e => e.PaymentOperations)
                .HasForeignKey(e => e.PaymentOperationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payments>()
                .Property(e => e.CreateUserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Payments>()
                .Property(e => e.UpdateUserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Payments>()
                .HasMany(e => e.PaymentItems)
                .WithRequired(e => e.Payments)
                .HasForeignKey(e => e.PaymentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payments>()
                .HasMany(e => e.PaymentOperations)
                .WithRequired(e => e.Payments)
                .HasForeignKey(e => e.PaymentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payments>()
                .HasMany(e => e.PaymentStatuses)
                .WithRequired(e => e.Payments)
                .HasForeignKey(e => e.PaymentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payments>()
                .HasMany(e => e.PaymentToken)
                .WithRequired(e => e.Payments)
                .HasForeignKey(e => e.PaymentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentStatuses>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentToken>()
                .Property(e => e.CreateUserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentToken>()
                .Property(e => e.UpdateUserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentToken>()
                .HasMany(e => e.PaymentTokenStatuses)
                .WithRequired(e => e.PaymentToken)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentTokenStatuses>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Packages>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Packages)
                .HasForeignKey(e => e.PackageId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductRates>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ProductInventories)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ProductDetails)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ProductRates)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.SellerProducts)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.ProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.PhaseProductTemplates)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.BuyerProductTemplates)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.BranPercentageLimitations)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.DealingLimitations)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.ProductTemplateBranPercentages)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.SellerProductTemplates)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductTemplates>()
                .HasMany(e => e.ShipmentCosts)
                .WithRequired(e => e.ProductTemplates)
                .HasForeignKey(e => e.ProductTemplateId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesPlans>()
                .HasMany(e => e.SalePlanInstallments)
                .WithRequired(e => e.SalesPlans)
                .HasForeignKey(e => e.SalePlanId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuotaFileImportLogs>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<QuotaFileImportLogs>()
                .HasMany(e => e.QuotaFileImportLogMessages)
                .WithRequired(e => e.QuotaFileImportLogs)
                .HasForeignKey(e => e.QuotaFileImportLogId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quotations>()
                .Property(e => e.InspectionScore)
                .HasPrecision(2, 1);

            modelBuilder.Entity<Quotations>()
                .Property(e => e.PeoplesScore)
                .HasPrecision(2, 1);

            modelBuilder.Entity<Quotations>()
                .Property(e => e.FunctionalScore)
                .HasPrecision(2, 1);

            modelBuilder.Entity<Quotations>()
                .HasMany(e => e.QutaBatchLogDetails)
                .WithRequired(e => e.Quotations)
                .HasForeignKey(e => e.SourceQuotaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quotations>()
                .HasMany(e => e.QutaBatchLogDetails1)
                .WithRequired(e => e.Quotations1)
                .HasForeignKey(e => e.DestinationQuotaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QutaBatchLogs>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<QutaBatchLogs>()
                .HasMany(e => e.QutaBatchLogDetails)
                .WithRequired(e => e.QutaBatchLogs)
                .HasForeignKey(e => e.QutaBatchLogId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SellerProducts>()
                .HasMany(e => e.SalesPlans)
                .WithRequired(e => e.SellerProducts)
                .HasForeignKey(e => e.SellerProductId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SellerRates>()
                .Property(e => e.UserIPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .Property(e => e.NationalId)
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .Property(e => e.EconomicCode)
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .Property(e => e.IntermediateAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .Property(e => e.MainAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .Property(e => e.Tel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .Property(e => e.Fax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .Property(e => e.PostalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.Buyers)
                .WithOptional(e => e.Sellers)
                .HasForeignKey(e => e.SellerParentId);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.ProductInventories)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.DealingLimitations)
                .WithOptional(e => e.Sellers)
                .HasForeignKey(e => e.SellerId);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.TransportLimitations)
                .WithOptional(e => e.Sellers)
                .HasForeignKey(e => e.SellerId);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.SellerPersons)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.SellerProducts)
                .WithOptional(e => e.Sellers)
                .HasForeignKey(e => e.SellerId);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.SellerProductTemplates)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.SellerRates)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasOptional(e => e.Sellers1)
                .WithRequired(e => e.Sellers2);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.SellerStatuses)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.SellerSuspensions)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.SellerTransportTypes)
                .WithRequired(e => e.Sellers)
                .HasForeignKey(e => e.SellerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sellers>()
                .HasMany(e => e.ShipmentCosts)
                .WithOptional(e => e.Sellers)
                .HasForeignKey(e => e.SellerId);

            modelBuilder.Entity<Cars>()
                .HasMany(e => e.DriverCarTransportationCompanies)
                .WithRequired(e => e.Cars)
                .HasForeignKey(e => e.CarId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DriverCars>()
                .HasMany(e => e.ShipmentInfos)
                .WithOptional(e => e.DriverCars)
                .HasForeignKey(e => e.DriverCarId);

            modelBuilder.Entity<DriverCars>()
                .HasMany(e => e.Shipments)
                .WithOptional(e => e.DriverCars)
                .HasForeignKey(e => e.DriverCarId);

            modelBuilder.Entity<Drivers>()
                .HasMany(e => e.DriverCarTransportationCompanies)
                .WithRequired(e => e.Drivers)
                .HasForeignKey(e => e.DriverId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipmentInfos>()
                .HasMany(e => e.ShipmentInfoDetails)
                .WithRequired(e => e.ShipmentInfos)
                .HasForeignKey(e => e.ShipmentInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipmentInfos>()
                .HasMany(e => e.ShipmentInfoStatuses)
                .WithRequired(e => e.ShipmentInfos)
                .HasForeignKey(e => e.ShipmentInfoId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ShipmentInquiries>()
                .HasMany(e => e.ShipmentInquiryDetails)
                .WithRequired(e => e.ShipmentInquiries)
                .HasForeignKey(e => e.ShipmentInquiryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipments>()
                .HasMany(e => e.ShipmentInfos)
                .WithRequired(e => e.Shipments)
                .HasForeignKey(e => e.ShipmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipments>()
                .HasMany(e => e.ShipmentInquiries)
                .WithRequired(e => e.Shipments)
                .HasForeignKey(e => e.ShipmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipments>()
                .HasMany(e => e.ShipmentStatuses)
                .WithRequired(e => e.Shipments)
                .HasForeignKey(e => e.ShipmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportationCompanies>()
                .Property(e => e.NationalId)
                .IsUnicode(false);

            modelBuilder.Entity<TransportationCompanies>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<TransportationCompanies>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<TransportationCompanies>()
                .Property(e => e.IntermediateAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransportationCompanies>()
                .Property(e => e.MainAccountNumber)
                .IsUnicode(false);

            modelBuilder.Entity<TransportationCompanies>()
                .HasMany(e => e.TransportLimitations)
                .WithRequired(e => e.TransportationCompanies)
                .HasForeignKey(e => e.TransportationCompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportationCompanies>()
                .HasMany(e => e.DriverCarTransportationCompanies)
                .WithRequired(e => e.TransportationCompanies)
                .HasForeignKey(e => e.TransportationCompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportationCompanies>()
                .HasMany(e => e.DriverTransportationCompanies)
                .WithRequired(e => e.TransportationCompanies)
                .HasForeignKey(e => e.TransportationCompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportationCompanies>()
                .HasMany(e => e.ShipmentCosts)
                .WithRequired(e => e.TransportationCompanies)
                .HasForeignKey(e => e.TransportationCompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TransportationCompanies>()
                .HasMany(e => e.ShipmentInquiries)
                .WithRequired(e => e.TransportationCompanies)
                .HasForeignKey(e => e.TransportationCompanyId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SendSmsDetailLog>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<SendSmsMainLog>()
                .HasMany(e => e.SendSmsDetailLog)
                .WithRequired(e => e.SendSmsMainLog)
                .HasForeignKey(e => e.ParentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Support>()
                .HasMany(e => e.SuppotStatuses)
                .WithRequired(e => e.Support)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WheatImportInfos>()
                .Property(e => e.NationalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WheatImports>()
                .HasMany(e => e.WheatImportInfos)
                .WithRequired(e => e.WheatImports)
                .HasForeignKey(e => e.WheatImportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WheatImports>()
                .HasMany(e => e.WheatImportLogs)
                .WithRequired(e => e.WheatImports)
                .HasForeignKey(e => e.WheatImportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdersInquiryRequests>()
                .Property(e => e.TrackingCode)
                .IsUnicode(false);

            modelBuilder.Entity<PersonsHistory>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<PersonsHistory>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<PersonsHistory>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PersonUpdateLogs>()
                .Property(e => e.NationalCode)
                .IsUnicode(false);

            modelBuilder.Entity<PersonUpdateLogs>()
                .Property(e => e.MobileNo)
                .IsUnicode(false);

            modelBuilder.Entity<PersonUpdateLogs>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<C___Buyers>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<C___Buyers>()
                .Property(e => e.BusinessLicense)
                .IsUnicode(false);

            modelBuilder.Entity<C___Buyers>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<C___Buyers>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<C___Buyers>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<C___Buyers>()
                .Property(e => e.GasReceiptSubscriptionNo)
                .IsUnicode(false);

            modelBuilder.Entity<C___Buyers>()
                .Property(e => e.ElectricityReceiptId)
                .IsUnicode(false);

            modelBuilder.Entity<C__Buyers14020824>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<C__Buyers14020824>()
                .Property(e => e.BusinessLicense)
                .IsUnicode(false);

            modelBuilder.Entity<C__Buyers14020824>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<C__Buyers14020824>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<C__Buyers14020824>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<C__Buyers14020824>()
                .Property(e => e.GasReceiptSubscriptionNo)
                .IsUnicode(false);

            modelBuilder.Entity<C__Buyers14020824>()
                .Property(e => e.ElectricityReceiptId)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerMaping>()
                .Property(e => e.BuyerCode)
                .IsUnicode(false);

            modelBuilder.Entity<C__NaninoBuyerSales14020722>()
                .Property(e => e.FlourSaleAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<C__NaninoBuyerSales14020722>()
                .Property(e => e.FlourSaleAmountWithFraud)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BuyerFraud>()
                .Property(e => e.PROVINCENAME)
                .IsUnicode(false);

            modelBuilder.Entity<BuyerFraud>()
                .Property(e => e.FraudTitle)
                .IsUnicode(false);

            modelBuilder.Entity<TicketAccessLimitation>()
                .Property(e => e.RoleTitle)
                .IsUnicode(false);

            modelBuilder.Entity<vwBuyerInfo>()
                .Property(e => e.BuyerCode)
                .IsUnicode(false);

            modelBuilder.Entity<Histories>()
                .Property(e => e.IPAddress)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Histories>()
                .Property(e => e.MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<Logs>()
                .Property(e => e.IPAddress)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Logs>()
                .Property(e => e.MachineName)
                .IsUnicode(false);

            modelBuilder.Entity<NaninoBuyerSales>()
                .Property(e => e.FlourSaleAmount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NaninoBuyerSales>()
                .Property(e => e.FlourSaleAmountWithFraud)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NaninoBuyerViolations>()
                .Property(e => e.Value)
                .HasPrecision(18, 0);
        }
    }
}
