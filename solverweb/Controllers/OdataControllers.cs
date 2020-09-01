


    


using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using System.ComponentModel.DataAnnotations;

using solverweb.data;

namespace solverweb.Controllers {    
    public partial class CitiesController:ControllerBase
{
    private SolverDbContext _db;

    public CitiesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.Cities> Get()
    {
            return _db.Cities;
        
    }

    [EnableQuery]
    public solverweb.model.Cities Get([FromODataUri] int keyCityID )
    {
        var result = Get().Where(p => p.CityID==keyCityID).FirstOrDefault();
        return result;
    }
}
public partial class CountriesController:ControllerBase
{
    private SolverDbContext _db;

    public CountriesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.Countries> Get()
    {
            return _db.Countries;
        
    }

    [EnableQuery]
    public solverweb.model.Countries Get([FromODataUri] int keyCountryID )
    {
        var result = Get().Where(p => p.CountryID==keyCountryID).FirstOrDefault();
        return result;
    }
}
public partial class DeliveryMethodsController:ControllerBase
{
    private SolverDbContext _db;

    public DeliveryMethodsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.DeliveryMethods> Get()
    {
            return _db.DeliveryMethods;
        
    }

    [EnableQuery]
    public solverweb.model.DeliveryMethods Get([FromODataUri] int keyDeliveryMethodID )
    {
        var result = Get().Where(p => p.DeliveryMethodID==keyDeliveryMethodID).FirstOrDefault();
        return result;
    }
}
public partial class PaymentMethodsController:ControllerBase
{
    private SolverDbContext _db;

    public PaymentMethodsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.PaymentMethods> Get()
    {
            return _db.PaymentMethods;
        
    }

    [EnableQuery]
    public solverweb.model.PaymentMethods Get([FromODataUri] int keyPaymentMethodID )
    {
        var result = Get().Where(p => p.PaymentMethodID==keyPaymentMethodID).FirstOrDefault();
        return result;
    }
}
public partial class PeopleController:ControllerBase
{
    private SolverDbContext _db;

    public PeopleController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.People> Get()
    {
            return _db.People;
        
    }

    [EnableQuery]
    public solverweb.model.People Get([FromODataUri] int keyPersonID )
    {
        var result = Get().Where(p => p.PersonID==keyPersonID).FirstOrDefault();
        return result;
    }
}
public partial class StateProvincesController:ControllerBase
{
    private SolverDbContext _db;

    public StateProvincesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.StateProvinces> Get()
    {
            return _db.StateProvinces;
        
    }

    [EnableQuery]
    public solverweb.model.StateProvinces Get([FromODataUri] int keyStateProvinceID )
    {
        var result = Get().Where(p => p.StateProvinceID==keyStateProvinceID).FirstOrDefault();
        return result;
    }
}
public partial class SystemParametersController:ControllerBase
{
    private SolverDbContext _db;

    public SystemParametersController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.SystemParameters> Get()
    {
            return _db.SystemParameters;
        
    }

    [EnableQuery]
    public solverweb.model.SystemParameters Get([FromODataUri] int keySystemParameterID )
    {
        var result = Get().Where(p => p.SystemParameterID==keySystemParameterID).FirstOrDefault();
        return result;
    }
}
public partial class TransactionTypesController:ControllerBase
{
    private SolverDbContext _db;

    public TransactionTypesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.TransactionTypes> Get()
    {
            return _db.TransactionTypes;
        
    }

    [EnableQuery]
    public solverweb.model.TransactionTypes Get([FromODataUri] int keyTransactionTypeID )
    {
        var result = Get().Where(p => p.TransactionTypeID==keyTransactionTypeID).FirstOrDefault();
        return result;
    }
}
public partial class PurchaseOrderLinesController:ControllerBase
{
    private SolverDbContext _db;

    public PurchaseOrderLinesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.PurchaseOrderLines> Get()
    {
            return _db.PurchaseOrderLines;
        
    }

    [EnableQuery]
    public solverweb.model.PurchaseOrderLines Get([FromODataUri] int keyPurchaseOrderLineID )
    {
        var result = Get().Where(p => p.PurchaseOrderLineID==keyPurchaseOrderLineID).FirstOrDefault();
        return result;
    }
}
public partial class PurchaseOrdersController:ControllerBase
{
    private SolverDbContext _db;

    public PurchaseOrdersController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.PurchaseOrders> Get()
    {
            return _db.PurchaseOrders;
        
    }

    [EnableQuery]
    public solverweb.model.PurchaseOrders Get([FromODataUri] int keyPurchaseOrderID )
    {
        var result = Get().Where(p => p.PurchaseOrderID==keyPurchaseOrderID).FirstOrDefault();
        return result;
    }
}
public partial class SupplierCategoriesController:ControllerBase
{
    private SolverDbContext _db;

    public SupplierCategoriesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.SupplierCategories> Get()
    {
            return _db.SupplierCategories;
        
    }

    [EnableQuery]
    public solverweb.model.SupplierCategories Get([FromODataUri] int keySupplierCategoryID )
    {
        var result = Get().Where(p => p.SupplierCategoryID==keySupplierCategoryID).FirstOrDefault();
        return result;
    }
}
public partial class SuppliersController:ControllerBase
{
    private SolverDbContext _db;

    public SuppliersController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.Suppliers> Get()
    {
            return _db.Suppliers;
        
    }

    [EnableQuery]
    public solverweb.model.Suppliers Get([FromODataUri] int keySupplierID )
    {
        var result = Get().Where(p => p.SupplierID==keySupplierID).FirstOrDefault();
        return result;
    }
}
public partial class SupplierTransactionsController:ControllerBase
{
    private SolverDbContext _db;

    public SupplierTransactionsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.SupplierTransactions> Get()
    {
            return _db.SupplierTransactions;
        
    }

    [EnableQuery]
    public solverweb.model.SupplierTransactions Get([FromODataUri] int keySupplierTransactionID )
    {
        var result = Get().Where(p => p.SupplierTransactionID==keySupplierTransactionID).FirstOrDefault();
        return result;
    }
}
public partial class BuyingGroupsController:ControllerBase
{
    private SolverDbContext _db;

    public BuyingGroupsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.BuyingGroups> Get()
    {
            return _db.BuyingGroups;
        
    }

    [EnableQuery]
    public solverweb.model.BuyingGroups Get([FromODataUri] int keyBuyingGroupID )
    {
        var result = Get().Where(p => p.BuyingGroupID==keyBuyingGroupID).FirstOrDefault();
        return result;
    }
}
public partial class CustomerCategoriesController:ControllerBase
{
    private SolverDbContext _db;

    public CustomerCategoriesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.CustomerCategories> Get()
    {
            return _db.CustomerCategories;
        
    }

    [EnableQuery]
    public solverweb.model.CustomerCategories Get([FromODataUri] int keyCustomerCategoryID )
    {
        var result = Get().Where(p => p.CustomerCategoryID==keyCustomerCategoryID).FirstOrDefault();
        return result;
    }
}
public partial class CustomersController:ControllerBase
{
    private SolverDbContext _db;

    public CustomersController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.Customers> Get()
    {
            return _db.Customers;
        
    }

    [EnableQuery]
    public solverweb.model.Customers Get([FromODataUri] int keyCustomerID )
    {
        var result = Get().Where(p => p.CustomerID==keyCustomerID).FirstOrDefault();
        return result;
    }
}
public partial class CustomerTransactionsController:ControllerBase
{
    private SolverDbContext _db;

    public CustomerTransactionsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.CustomerTransactions> Get()
    {
            return _db.CustomerTransactions;
        
    }

    [EnableQuery]
    public solverweb.model.CustomerTransactions Get([FromODataUri] int keyCustomerTransactionID )
    {
        var result = Get().Where(p => p.CustomerTransactionID==keyCustomerTransactionID).FirstOrDefault();
        return result;
    }
}
public partial class InvoiceLinesController:ControllerBase
{
    private SolverDbContext _db;

    public InvoiceLinesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.InvoiceLines> Get()
    {
            return _db.InvoiceLines;
        
    }

    [EnableQuery]
    public solverweb.model.InvoiceLines Get([FromODataUri] int keyInvoiceLineID )
    {
        var result = Get().Where(p => p.InvoiceLineID==keyInvoiceLineID).FirstOrDefault();
        return result;
    }
}
public partial class InvoicesController:ControllerBase
{
    private SolverDbContext _db;

    public InvoicesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.Invoices> Get()
    {
            return _db.Invoices;
        
    }

    [EnableQuery]
    public solverweb.model.Invoices Get([FromODataUri] int keyInvoiceID )
    {
        var result = Get().Where(p => p.InvoiceID==keyInvoiceID).FirstOrDefault();
        return result;
    }
}
public partial class OrderLinesController:ControllerBase
{
    private SolverDbContext _db;

    public OrderLinesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.OrderLines> Get()
    {
            return _db.OrderLines;
        
    }

    [EnableQuery]
    public solverweb.model.OrderLines Get([FromODataUri] int keyOrderLineID )
    {
        var result = Get().Where(p => p.OrderLineID==keyOrderLineID).FirstOrDefault();
        return result;
    }
}
public partial class OrdersController:ControllerBase
{
    private SolverDbContext _db;

    public OrdersController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.Orders> Get()
    {
            return _db.Orders;
        
    }

    [EnableQuery]
    public solverweb.model.Orders Get([FromODataUri] int keyOrderID )
    {
        var result = Get().Where(p => p.OrderID==keyOrderID).FirstOrDefault();
        return result;
    }
}
public partial class SpecialDealsController:ControllerBase
{
    private SolverDbContext _db;

    public SpecialDealsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.SpecialDeals> Get()
    {
            return _db.SpecialDeals;
        
    }

    [EnableQuery]
    public solverweb.model.SpecialDeals Get([FromODataUri] int keySpecialDealID )
    {
        var result = Get().Where(p => p.SpecialDealID==keySpecialDealID).FirstOrDefault();
        return result;
    }
}
public partial class ColdRoomTemperaturesController:ControllerBase
{
    private SolverDbContext _db;

    public ColdRoomTemperaturesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.ColdRoomTemperatures> Get()
    {
            return _db.ColdRoomTemperatures;
        
    }

    [EnableQuery]
    public solverweb.model.ColdRoomTemperatures Get([FromODataUri] long keyColdRoomTemperatureID )
    {
        var result = Get().Where(p => p.ColdRoomTemperatureID==keyColdRoomTemperatureID).FirstOrDefault();
        return result;
    }
}
public partial class ColorsController:ControllerBase
{
    private SolverDbContext _db;

    public ColorsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.Colors> Get()
    {
            return _db.Colors;
        
    }

    [EnableQuery]
    public solverweb.model.Colors Get([FromODataUri] int keyColorID )
    {
        var result = Get().Where(p => p.ColorID==keyColorID).FirstOrDefault();
        return result;
    }
}
public partial class PackageTypesController:ControllerBase
{
    private SolverDbContext _db;

    public PackageTypesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.PackageTypes> Get()
    {
            return _db.PackageTypes;
        
    }

    [EnableQuery]
    public solverweb.model.PackageTypes Get([FromODataUri] int keyPackageTypeID )
    {
        var result = Get().Where(p => p.PackageTypeID==keyPackageTypeID).FirstOrDefault();
        return result;
    }
}
public partial class StockGroupsController:ControllerBase
{
    private SolverDbContext _db;

    public StockGroupsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.StockGroups> Get()
    {
            return _db.StockGroups;
        
    }

    [EnableQuery]
    public solverweb.model.StockGroups Get([FromODataUri] int keyStockGroupID )
    {
        var result = Get().Where(p => p.StockGroupID==keyStockGroupID).FirstOrDefault();
        return result;
    }
}
public partial class StockItemHoldingsController:ControllerBase
{
    private SolverDbContext _db;

    public StockItemHoldingsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.StockItemHoldings> Get()
    {
            return _db.StockItemHoldings;
        
    }

    [EnableQuery]
    public solverweb.model.StockItemHoldings Get([FromODataUri] int keyStockItemID )
    {
        var result = Get().Where(p => p.StockItemID==keyStockItemID).FirstOrDefault();
        return result;
    }
}
public partial class StockItemsController:ControllerBase
{
    private SolverDbContext _db;

    public StockItemsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.StockItems> Get()
    {
            return _db.StockItems;
        
    }

    [EnableQuery]
    public solverweb.model.StockItems Get([FromODataUri] int keyStockItemID )
    {
        var result = Get().Where(p => p.StockItemID==keyStockItemID).FirstOrDefault();
        return result;
    }
}
public partial class StockItemStockGroupsController:ControllerBase
{
    private SolverDbContext _db;

    public StockItemStockGroupsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.StockItemStockGroups> Get()
    {
            return _db.StockItemStockGroups;
        
    }

    [EnableQuery]
    public solverweb.model.StockItemStockGroups Get([FromODataUri] int keyStockItemStockGroupID )
    {
        var result = Get().Where(p => p.StockItemStockGroupID==keyStockItemStockGroupID).FirstOrDefault();
        return result;
    }
}
public partial class StockItemTransactionsController:ControllerBase
{
    private SolverDbContext _db;

    public StockItemTransactionsController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.StockItemTransactions> Get()
    {
            return _db.StockItemTransactions;
        
    }

    [EnableQuery]
    public solverweb.model.StockItemTransactions Get([FromODataUri] int keyStockItemTransactionID )
    {
        var result = Get().Where(p => p.StockItemTransactionID==keyStockItemTransactionID).FirstOrDefault();
        return result;
    }
}
public partial class VehicleTemperaturesController:ControllerBase
{
    private SolverDbContext _db;

    public VehicleTemperaturesController(SolverDbContext db){
        _db=db;
    }

    [EnableQuery(PageSize = 20)]
    public IQueryable<solverweb.model.VehicleTemperatures> Get()
    {
            return _db.VehicleTemperatures;
        
    }

    [EnableQuery]
    public solverweb.model.VehicleTemperatures Get([FromODataUri] long keyVehicleTemperatureID )
    {
        var result = Get().Where(p => p.VehicleTemperatureID==keyVehicleTemperatureID).FirstOrDefault();
        return result;
    }
}
    
}

