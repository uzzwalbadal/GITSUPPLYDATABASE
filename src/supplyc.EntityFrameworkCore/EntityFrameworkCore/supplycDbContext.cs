using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using supplyc.Authorization.Roles;
using supplyc.Authorization.Users;
using supplyc.MultiTenancy;
using supplyc.Entity.Products;
using supplyc.Entity.Purchase;
using supplyc.Entity.Stocks.Batchs;
using supplyc.Entity.Stocks.StockIs;
using supplyc.Entity.Stocks.StockOs;
using supplyc.Entity.Customers;
using System.Transactions;

using supplyc.Entity.SupplyTransactions;
using supplyc.Entity.Supplys;

namespace supplyc.EntityFrameworkCore
{
    public class supplycDbContext : AbpZeroDbContext<Tenant, Role, User, supplycDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public supplycDbContext(DbContextOptions<supplycDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<SupplyBatch> SupplyBatchs { get; set; }
        public DbSet<SupplyStockIn> SupplyStockIns { get; set; }
        public DbSet<SupplyStockOutt> SupplyStockOutts { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplytransaction> Supplytransactions { get; set; }
        public DbSet<Supplytransactiontype> Supplytransactiontypes { get; set; }
        public DbSet<Supply> Supplys { get; set; }




    }
}
