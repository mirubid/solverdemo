





    





using System;
using System.ComponentModel.DataAnnotations;

namespace solverweb.model {
    ///<summary> Application.Cities </summary>
    public class Cities
    {
       [Key]
        public int CityID{get;set;}
        public string CityName{get;set;}
        public int StateProvinceID{get;set;}
        public long? LatestRecordedPopulation{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Application.Countries </summary>
    public class Countries
    {
       [Key]
        public int CountryID{get;set;}
        public string CountryName{get;set;}
        public string FormalName{get;set;}
        public string IsoAlpha3Code{get;set;}
        public int? IsoNumericCode{get;set;}
        public string CountryType{get;set;}
        public long? LatestRecordedPopulation{get;set;}
        public string Continent{get;set;}
        public string Region{get;set;}
        public string Subregion{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Application.DeliveryMethods </summary>
    public class DeliveryMethods
    {
       [Key]
        public int DeliveryMethodID{get;set;}
        public string DeliveryMethodName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Application.PaymentMethods </summary>
    public class PaymentMethods
    {
       [Key]
        public int PaymentMethodID{get;set;}
        public string PaymentMethodName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Application.People </summary>
    public class People
    {
       [Key]
        public int PersonID{get;set;}
        public string FullName{get;set;}
        public string PreferredName{get;set;}
        public string SearchName{get;set;}
        public bool IsPermittedToLogon{get;set;}
        public string LogonName{get;set;}
        public bool IsExternalLogonProvider{get;set;}
        public byte[] HashedPassword{get;set;}
        public bool IsSystemUser{get;set;}
        public bool IsEmployee{get;set;}
        public bool IsSalesperson{get;set;}
        public string UserPreferences{get;set;}
        public string PhoneNumber{get;set;}
        public string FaxNumber{get;set;}
        public string EmailAddress{get;set;}
        public byte[] Photo{get;set;}
        public string CustomFields{get;set;}
        public string OtherLanguages{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Application.StateProvinces </summary>
    public class StateProvinces
    {
       [Key]
        public int StateProvinceID{get;set;}
        public string StateProvinceCode{get;set;}
        public string StateProvinceName{get;set;}
        public int CountryID{get;set;}
        public string SalesTerritory{get;set;}
        public long? LatestRecordedPopulation{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Application.SystemParameters </summary>
    public class SystemParameters
    {
       [Key]
        public int SystemParameterID{get;set;}
        public string DeliveryAddressLine1{get;set;}
        public string DeliveryAddressLine2{get;set;}
        public int DeliveryCityID{get;set;}
        public string DeliveryPostalCode{get;set;}
        public string PostalAddressLine1{get;set;}
        public string PostalAddressLine2{get;set;}
        public int PostalCityID{get;set;}
        public string PostalPostalCode{get;set;}
        public string ApplicationSettings{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Application.TransactionTypes </summary>
    public class TransactionTypes
    {
       [Key]
        public int TransactionTypeID{get;set;}
        public string TransactionTypeName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Purchasing.PurchaseOrderLines </summary>
    public class PurchaseOrderLines
    {
       [Key]
        public int PurchaseOrderLineID{get;set;}
        public int PurchaseOrderID{get;set;}
        public int StockItemID{get;set;}
        public int OrderedOuters{get;set;}
        public string Description{get;set;}
        public int ReceivedOuters{get;set;}
        public int PackageTypeID{get;set;}
        public decimal? ExpectedUnitPricePerOuter{get;set;}
        public DateTime? LastReceiptDate{get;set;}
        public bool IsOrderLineFinalized{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Purchasing.PurchaseOrders </summary>
    public class PurchaseOrders
    {
       [Key]
        public int PurchaseOrderID{get;set;}
        public int SupplierID{get;set;}
        public DateTime OrderDate{get;set;}
        public int DeliveryMethodID{get;set;}
        public int ContactPersonID{get;set;}
        public DateTime? ExpectedDeliveryDate{get;set;}
        public string SupplierReference{get;set;}
        public bool IsOrderFinalized{get;set;}
        public string Comments{get;set;}
        public string InternalComments{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Purchasing.SupplierCategories </summary>
    public class SupplierCategories
    {
       [Key]
        public int SupplierCategoryID{get;set;}
        public string SupplierCategoryName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Purchasing.Suppliers </summary>
    public class Suppliers
    {
       [Key]
        public int SupplierID{get;set;}
        public string SupplierName{get;set;}
        public int SupplierCategoryID{get;set;}
        public int PrimaryContactPersonID{get;set;}
        public int AlternateContactPersonID{get;set;}
        public int? DeliveryMethodID{get;set;}
        public int DeliveryCityID{get;set;}
        public int PostalCityID{get;set;}
        public string SupplierReference{get;set;}
        public string BankAccountName{get;set;}
        public string BankAccountBranch{get;set;}
        public string BankAccountCode{get;set;}
        public string BankAccountNumber{get;set;}
        public string BankInternationalCode{get;set;}
        public int PaymentDays{get;set;}
        public string InternalComments{get;set;}
        public string PhoneNumber{get;set;}
        public string FaxNumber{get;set;}
        public string WebsiteURL{get;set;}
        public string DeliveryAddressLine1{get;set;}
        public string DeliveryAddressLine2{get;set;}
        public string DeliveryPostalCode{get;set;}
        public string PostalAddressLine1{get;set;}
        public string PostalAddressLine2{get;set;}
        public string PostalPostalCode{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Purchasing.SupplierTransactions </summary>
    public class SupplierTransactions
    {
       [Key]
        public int SupplierTransactionID{get;set;}
        public int SupplierID{get;set;}
        public int TransactionTypeID{get;set;}
        public int? PurchaseOrderID{get;set;}
        public int? PaymentMethodID{get;set;}
        public string SupplierInvoiceNumber{get;set;}
        public DateTime TransactionDate{get;set;}
        public decimal AmountExcludingTax{get;set;}
        public decimal TaxAmount{get;set;}
        public decimal TransactionAmount{get;set;}
        public decimal OutstandingBalance{get;set;}
        public DateTime? FinalizationDate{get;set;}
        public bool? IsFinalized{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Sales.BuyingGroups </summary>
    public class BuyingGroups
    {
       [Key]
        public int BuyingGroupID{get;set;}
        public string BuyingGroupName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Sales.CustomerCategories </summary>
    public class CustomerCategories
    {
       [Key]
        public int CustomerCategoryID{get;set;}
        public string CustomerCategoryName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Sales.Customers </summary>
    public class Customers
    {
       [Key]
        public int CustomerID{get;set;}
        public string CustomerName{get;set;}
        public int BillToCustomerID{get;set;}
        public int CustomerCategoryID{get;set;}
        public int? BuyingGroupID{get;set;}
        public int PrimaryContactPersonID{get;set;}
        public int? AlternateContactPersonID{get;set;}
        public int DeliveryMethodID{get;set;}
        public int DeliveryCityID{get;set;}
        public int PostalCityID{get;set;}
        public decimal? CreditLimit{get;set;}
        public DateTime AccountOpenedDate{get;set;}
        public decimal StandardDiscountPercentage{get;set;}
        public bool IsStatementSent{get;set;}
        public bool IsOnCreditHold{get;set;}
        public int PaymentDays{get;set;}
        public string PhoneNumber{get;set;}
        public string FaxNumber{get;set;}
        public string DeliveryRun{get;set;}
        public string RunPosition{get;set;}
        public string WebsiteURL{get;set;}
        public string DeliveryAddressLine1{get;set;}
        public string DeliveryAddressLine2{get;set;}
        public string DeliveryPostalCode{get;set;}
        public string PostalAddressLine1{get;set;}
        public string PostalAddressLine2{get;set;}
        public string PostalPostalCode{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Sales.CustomerTransactions </summary>
    public class CustomerTransactions
    {
       [Key]
        public int CustomerTransactionID{get;set;}
        public int CustomerID{get;set;}
        public int TransactionTypeID{get;set;}
        public int? InvoiceID{get;set;}
        public int? PaymentMethodID{get;set;}
        public DateTime TransactionDate{get;set;}
        public decimal AmountExcludingTax{get;set;}
        public decimal TaxAmount{get;set;}
        public decimal TransactionAmount{get;set;}
        public decimal OutstandingBalance{get;set;}
        public DateTime? FinalizationDate{get;set;}
        public bool? IsFinalized{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Sales.InvoiceLines </summary>
    public class InvoiceLines
    {
       [Key]
        public int InvoiceLineID{get;set;}
        public int InvoiceID{get;set;}
        public int StockItemID{get;set;}
        public string Description{get;set;}
        public int PackageTypeID{get;set;}
        public int Quantity{get;set;}
        public decimal? UnitPrice{get;set;}
        public decimal TaxRate{get;set;}
        public decimal TaxAmount{get;set;}
        public decimal LineProfit{get;set;}
        public decimal ExtendedPrice{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Sales.Invoices </summary>
    public class Invoices
    {
       [Key]
        public int InvoiceID{get;set;}
        public int CustomerID{get;set;}
        public int BillToCustomerID{get;set;}
        public int? OrderID{get;set;}
        public int DeliveryMethodID{get;set;}
        public int ContactPersonID{get;set;}
        public int AccountsPersonID{get;set;}
        public int SalespersonPersonID{get;set;}
        public int PackedByPersonID{get;set;}
        public DateTime InvoiceDate{get;set;}
        public string CustomerPurchaseOrderNumber{get;set;}
        public bool IsCreditNote{get;set;}
        public string CreditNoteReason{get;set;}
        public string Comments{get;set;}
        public string DeliveryInstructions{get;set;}
        public string InternalComments{get;set;}
        public int TotalDryItems{get;set;}
        public int TotalChillerItems{get;set;}
        public string DeliveryRun{get;set;}
        public string RunPosition{get;set;}
        public string ReturnedDeliveryData{get;set;}
        public DateTime? ConfirmedDeliveryTime{get;set;}
        public string ConfirmedReceivedBy{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Sales.OrderLines </summary>
    public class OrderLines
    {
       [Key]
        public int OrderLineID{get;set;}
        public int OrderID{get;set;}
        public int StockItemID{get;set;}
        public string Description{get;set;}
        public int PackageTypeID{get;set;}
        public int Quantity{get;set;}
        public decimal? UnitPrice{get;set;}
        public decimal TaxRate{get;set;}
        public int PickedQuantity{get;set;}
        public DateTime? PickingCompletedWhen{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Sales.Orders </summary>
    public class Orders
    {
       [Key]
        public int OrderID{get;set;}
        public int CustomerID{get;set;}
        public int SalespersonPersonID{get;set;}
        public int? PickedByPersonID{get;set;}
        public int ContactPersonID{get;set;}
        public int? BackorderOrderID{get;set;}
        public DateTime OrderDate{get;set;}
        public DateTime ExpectedDeliveryDate{get;set;}
        public string CustomerPurchaseOrderNumber{get;set;}
        public bool IsUndersupplyBackordered{get;set;}
        public string Comments{get;set;}
        public string DeliveryInstructions{get;set;}
        public string InternalComments{get;set;}
        public DateTime? PickingCompletedWhen{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Sales.SpecialDeals </summary>
    public class SpecialDeals
    {
       [Key]
        public int SpecialDealID{get;set;}
        public int? StockItemID{get;set;}
        public int? CustomerID{get;set;}
        public int? BuyingGroupID{get;set;}
        public int? CustomerCategoryID{get;set;}
        public int? StockGroupID{get;set;}
        public string DealDescription{get;set;}
        public DateTime StartDate{get;set;}
        public DateTime EndDate{get;set;}
        public decimal? DiscountAmount{get;set;}
        public decimal? DiscountPercentage{get;set;}
        public decimal? UnitPrice{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Warehouse.ColdRoomTemperatures </summary>
    public class ColdRoomTemperatures
    {
       [Key]
        public long ColdRoomTemperatureID{get;set;}
        public int ColdRoomSensorNumber{get;set;}
        public DateTime RecordedWhen{get;set;}
        public decimal Temperature{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Warehouse.Colors </summary>
    public class Colors
    {
       [Key]
        public int ColorID{get;set;}
        public string ColorName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Warehouse.PackageTypes </summary>
    public class PackageTypes
    {
       [Key]
        public int PackageTypeID{get;set;}
        public string PackageTypeName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Warehouse.StockGroups </summary>
    public class StockGroups
    {
       [Key]
        public int StockGroupID{get;set;}
        public string StockGroupName{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Warehouse.StockItemHoldings </summary>
    public class StockItemHoldings
    {
       [Key]
        public int StockItemID{get;set;}
        public int QuantityOnHand{get;set;}
        public string BinLocation{get;set;}
        public int LastStocktakeQuantity{get;set;}
        public decimal LastCostPrice{get;set;}
        public int ReorderLevel{get;set;}
        public int TargetStockLevel{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Warehouse.StockItems </summary>
    public class StockItems
    {
       [Key]
        public int StockItemID{get;set;}
        public string StockItemName{get;set;}
        public int SupplierID{get;set;}
        public int? ColorID{get;set;}
        public int UnitPackageID{get;set;}
        public int OuterPackageID{get;set;}
        public string Brand{get;set;}
        public string Size{get;set;}
        public int LeadTimeDays{get;set;}
        public int QuantityPerOuter{get;set;}
        public bool IsChillerStock{get;set;}
        public string Barcode{get;set;}
        public decimal TaxRate{get;set;}
        public decimal UnitPrice{get;set;}
        public decimal? RecommendedRetailPrice{get;set;}
        public decimal TypicalWeightPerUnit{get;set;}
        public string MarketingComments{get;set;}
        public string InternalComments{get;set;}
        public byte[] Photo{get;set;}
        public string CustomFields{get;set;}
        public string Tags{get;set;}
        public string SearchDetails{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime ValidFrom{get;set;}
        public DateTime ValidTo{get;set;}
    }
    ///<summary> Warehouse.StockItemStockGroups </summary>
    public class StockItemStockGroups
    {
       [Key]
        public int StockItemStockGroupID{get;set;}
        public int StockItemID{get;set;}
        public int StockGroupID{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Warehouse.StockItemTransactions </summary>
    public class StockItemTransactions
    {
       [Key]
        public int StockItemTransactionID{get;set;}
        public int StockItemID{get;set;}
        public int TransactionTypeID{get;set;}
        public int? CustomerID{get;set;}
        public int? InvoiceID{get;set;}
        public int? SupplierID{get;set;}
        public int? PurchaseOrderID{get;set;}
        public DateTime TransactionOccurredWhen{get;set;}
        public decimal Quantity{get;set;}
        public int LastEditedBy{get;set;}
        public DateTime LastEditedWhen{get;set;}
    }
    ///<summary> Warehouse.VehicleTemperatures </summary>
    public class VehicleTemperatures
    {
       [Key]
        public long VehicleTemperatureID{get;set;}
        public string VehicleRegistration{get;set;}
        public int ChillerSensorNumber{get;set;}
        public DateTime RecordedWhen{get;set;}
        public decimal Temperature{get;set;}
        public bool IsCompressed{get;set;}
        public string FullSensorData{get;set;}
        public byte[] CompressedSensorData{get;set;}
    }
}
