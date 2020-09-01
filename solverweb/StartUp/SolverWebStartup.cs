


    


using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.AspNet.OData.Builder;

using solverweb.data;

namespace solverweb {
    [System.CodeDom.Compiler.GeneratedCode("SolverWebStartup.tt","0")]
    public static partial class SolverWebStartup{

        public static void ConfigureOdata(ODataConventionModelBuilder odataBuilder){
            odataBuilder.EntitySet<solverweb.model.Cities>("Cities")
                .EntityType.HasKey(t=>new {t.CityID});
            odataBuilder.EntitySet<solverweb.model.Countries>("Countries")
                .EntityType.HasKey(t=>new {t.CountryID});
            odataBuilder.EntitySet<solverweb.model.DeliveryMethods>("DeliveryMethods")
                .EntityType.HasKey(t=>new {t.DeliveryMethodID});
            odataBuilder.EntitySet<solverweb.model.PaymentMethods>("PaymentMethods")
                .EntityType.HasKey(t=>new {t.PaymentMethodID});
            odataBuilder.EntitySet<solverweb.model.People>("People")
                .EntityType.HasKey(t=>new {t.PersonID});
            odataBuilder.EntitySet<solverweb.model.StateProvinces>("StateProvinces")
                .EntityType.HasKey(t=>new {t.StateProvinceID});
            odataBuilder.EntitySet<solverweb.model.SystemParameters>("SystemParameters")
                .EntityType.HasKey(t=>new {t.SystemParameterID});
            odataBuilder.EntitySet<solverweb.model.TransactionTypes>("TransactionTypes")
                .EntityType.HasKey(t=>new {t.TransactionTypeID});
            odataBuilder.EntitySet<solverweb.model.PurchaseOrderLines>("PurchaseOrderLines")
                .EntityType.HasKey(t=>new {t.PurchaseOrderLineID});
            odataBuilder.EntitySet<solverweb.model.PurchaseOrders>("PurchaseOrders")
                .EntityType.HasKey(t=>new {t.PurchaseOrderID});
            odataBuilder.EntitySet<solverweb.model.SupplierCategories>("SupplierCategories")
                .EntityType.HasKey(t=>new {t.SupplierCategoryID});
            odataBuilder.EntitySet<solverweb.model.Suppliers>("Suppliers")
                .EntityType.HasKey(t=>new {t.SupplierID});
            odataBuilder.EntitySet<solverweb.model.SupplierTransactions>("SupplierTransactions")
                .EntityType.HasKey(t=>new {t.SupplierTransactionID});
            odataBuilder.EntitySet<solverweb.model.BuyingGroups>("BuyingGroups")
                .EntityType.HasKey(t=>new {t.BuyingGroupID});
            odataBuilder.EntitySet<solverweb.model.CustomerCategories>("CustomerCategories")
                .EntityType.HasKey(t=>new {t.CustomerCategoryID});
            odataBuilder.EntitySet<solverweb.model.Customers>("Customers")
                .EntityType.HasKey(t=>new {t.CustomerID});
            odataBuilder.EntitySet<solverweb.model.CustomerTransactions>("CustomerTransactions")
                .EntityType.HasKey(t=>new {t.CustomerTransactionID});
            odataBuilder.EntitySet<solverweb.model.InvoiceLines>("InvoiceLines")
                .EntityType.HasKey(t=>new {t.InvoiceLineID});
            odataBuilder.EntitySet<solverweb.model.Invoices>("Invoices")
                .EntityType.HasKey(t=>new {t.InvoiceID});
            odataBuilder.EntitySet<solverweb.model.OrderLines>("OrderLines")
                .EntityType.HasKey(t=>new {t.OrderLineID});
            odataBuilder.EntitySet<solverweb.model.Orders>("Orders")
                .EntityType.HasKey(t=>new {t.OrderID});
            odataBuilder.EntitySet<solverweb.model.SpecialDeals>("SpecialDeals")
                .EntityType.HasKey(t=>new {t.SpecialDealID});
            odataBuilder.EntitySet<solverweb.model.ColdRoomTemperatures>("ColdRoomTemperatures")
                .EntityType.HasKey(t=>new {t.ColdRoomTemperatureID});
            odataBuilder.EntitySet<solverweb.model.Colors>("Colors")
                .EntityType.HasKey(t=>new {t.ColorID});
            odataBuilder.EntitySet<solverweb.model.PackageTypes>("PackageTypes")
                .EntityType.HasKey(t=>new {t.PackageTypeID});
            odataBuilder.EntitySet<solverweb.model.StockGroups>("StockGroups")
                .EntityType.HasKey(t=>new {t.StockGroupID});
            odataBuilder.EntitySet<solverweb.model.StockItemHoldings>("StockItemHoldings")
                .EntityType.HasKey(t=>new {t.StockItemID});
            odataBuilder.EntitySet<solverweb.model.StockItems>("StockItems")
                .EntityType.HasKey(t=>new {t.StockItemID});
            odataBuilder.EntitySet<solverweb.model.StockItemStockGroups>("StockItemStockGroups")
                .EntityType.HasKey(t=>new {t.StockItemStockGroupID});
            odataBuilder.EntitySet<solverweb.model.StockItemTransactions>("StockItemTransactions")
                .EntityType.HasKey(t=>new {t.StockItemTransactionID});
            odataBuilder.EntitySet<solverweb.model.VehicleTemperatures>("VehicleTemperatures")
                .EntityType.HasKey(t=>new {t.VehicleTemperatureID});
        }
    }
}

