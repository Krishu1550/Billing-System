using Billing_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Billing_Application.DBConnection
{
    public class BillDb :DbContext  
    {

        public BillDb(DbContextOptions<BillDb> options):base(options)
        {
            
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }  

    }
}
