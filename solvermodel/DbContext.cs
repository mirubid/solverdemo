



    


using System;
using Microsoft.EntityFrameworkCore;

using solverweb.model;

namespace solverweb.data {

    public partial class SolverDbContext:DbContext
    {

        public SolverDbContext(DbContextOptions<SolverDbContext> options):base(options){

        }
            public DbSet<solverweb.model.Cities> Cities {get;set;}

            public DbSet<solverweb.model.Countries> Countries {get;set;}

            public DbSet<solverweb.model.DeliveryMethods> DeliveryMethods {get;set;}

            public DbSet<solverweb.model.PaymentMethods> PaymentMethods {get;set;}

            public DbSet<solverweb.model.People> People {get;set;}

            public DbSet<solverweb.model.StateProvinces> StateProvinces {get;set;}

            public DbSet<solverweb.model.SystemParameters> SystemParameters {get;set;}

            public DbSet<solverweb.model.TransactionTypes> TransactionTypes {get;set;}

            public DbSet<solverweb.model.PurchaseOrderLines> PurchaseOrderLines {get;set;}

            public DbSet<solverweb.model.PurchaseOrders> PurchaseOrders {get;set;}

            public DbSet<solverweb.model.SupplierCategories> SupplierCategories {get;set;}

            public DbSet<solverweb.model.Suppliers> Suppliers {get;set;}

            public DbSet<solverweb.model.SupplierTransactions> SupplierTransactions {get;set;}

            public DbSet<solverweb.model.BuyingGroups> BuyingGroups {get;set;}

            public DbSet<solverweb.model.CustomerCategories> CustomerCategories {get;set;}

            public DbSet<solverweb.model.Customers> Customers {get;set;}

            public DbSet<solverweb.model.CustomerTransactions> CustomerTransactions {get;set;}

            public DbSet<solverweb.model.InvoiceLines> InvoiceLines {get;set;}

            public DbSet<solverweb.model.Invoices> Invoices {get;set;}

            public DbSet<solverweb.model.OrderLines> OrderLines {get;set;}

            public DbSet<solverweb.model.Orders> Orders {get;set;}

            public DbSet<solverweb.model.SpecialDeals> SpecialDeals {get;set;}

            public DbSet<solverweb.model.ColdRoomTemperatures> ColdRoomTemperatures {get;set;}

            public DbSet<solverweb.model.Colors> Colors {get;set;}

            public DbSet<solverweb.model.PackageTypes> PackageTypes {get;set;}

            public DbSet<solverweb.model.StockGroups> StockGroups {get;set;}

            public DbSet<solverweb.model.StockItemHoldings> StockItemHoldings {get;set;}

            public DbSet<solverweb.model.StockItems> StockItems {get;set;}

            public DbSet<solverweb.model.StockItemStockGroups> StockItemStockGroups {get;set;}

            public DbSet<solverweb.model.StockItemTransactions> StockItemTransactions {get;set;}

            public DbSet<solverweb.model.VehicleTemperatures> VehicleTemperatures {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
        modelBuilder
        .Entity<solverweb.model.Cities>()
        .ToTable("Cities", "Application");

        modelBuilder
        .Entity<solverweb.model.Countries>()
        .ToTable("Countries", "Application");

        modelBuilder
        .Entity<solverweb.model.DeliveryMethods>()
        .ToTable("DeliveryMethods", "Application");

        modelBuilder
        .Entity<solverweb.model.PaymentMethods>()
        .ToTable("PaymentMethods", "Application");

        modelBuilder
        .Entity<solverweb.model.People>()
        .ToTable("People", "Application");

        modelBuilder
        .Entity<solverweb.model.StateProvinces>()
        .ToTable("StateProvinces", "Application");

        modelBuilder
        .Entity<solverweb.model.SystemParameters>()
        .ToTable("SystemParameters", "Application");

        modelBuilder
        .Entity<solverweb.model.TransactionTypes>()
        .ToTable("TransactionTypes", "Application");

        modelBuilder
        .Entity<solverweb.model.PurchaseOrderLines>()
        .ToTable("PurchaseOrderLines", "Purchasing");

        modelBuilder
        .Entity<solverweb.model.PurchaseOrders>()
        .ToTable("PurchaseOrders", "Purchasing");

        modelBuilder
        .Entity<solverweb.model.SupplierCategories>()
        .ToTable("SupplierCategories", "Purchasing");

        modelBuilder
        .Entity<solverweb.model.Suppliers>()
        .ToTable("Suppliers", "Purchasing");

        modelBuilder
        .Entity<solverweb.model.SupplierTransactions>()
        .ToTable("SupplierTransactions", "Purchasing");

        modelBuilder
        .Entity<solverweb.model.BuyingGroups>()
        .ToTable("BuyingGroups", "Sales");

        modelBuilder
        .Entity<solverweb.model.CustomerCategories>()
        .ToTable("CustomerCategories", "Sales");

        modelBuilder
        .Entity<solverweb.model.Customers>()
        .ToTable("Customers", "Sales");

        modelBuilder
        .Entity<solverweb.model.CustomerTransactions>()
        .ToTable("CustomerTransactions", "Sales");

        modelBuilder
        .Entity<solverweb.model.InvoiceLines>()
        .ToTable("InvoiceLines", "Sales");

        modelBuilder
        .Entity<solverweb.model.Invoices>()
        .ToTable("Invoices", "Sales");

        modelBuilder
        .Entity<solverweb.model.OrderLines>()
        .ToTable("OrderLines", "Sales");

        modelBuilder
        .Entity<solverweb.model.Orders>()
        .ToTable("Orders", "Sales");

        modelBuilder
        .Entity<solverweb.model.SpecialDeals>()
        .ToTable("SpecialDeals", "Sales");

        modelBuilder
        .Entity<solverweb.model.ColdRoomTemperatures>()
        .ToTable("ColdRoomTemperatures", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.Colors>()
        .ToTable("Colors", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.PackageTypes>()
        .ToTable("PackageTypes", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.StockGroups>()
        .ToTable("StockGroups", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.StockItemHoldings>()
        .ToTable("StockItemHoldings", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.StockItems>()
        .ToTable("StockItems", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.StockItemStockGroups>()
        .ToTable("StockItemStockGroups", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.StockItemTransactions>()
        .ToTable("StockItemTransactions", "Warehouse");

        modelBuilder
        .Entity<solverweb.model.VehicleTemperatures>()
        .ToTable("VehicleTemperatures", "Warehouse");

        
}
    }
}

