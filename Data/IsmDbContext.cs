using Microsoft.EntityFrameworkCore;
using ISM_Redesign.Models;
using ISM_Redesing.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ISM_Redesign.Data
{
    public class IsmDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        public IsmDbContext(DbContextOptions<IsmDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ProductTableConfiguration.Configure(builder);
            ExpenseTableConfiguration.Configure(builder);
            base.OnModelCreating(builder);
        }

        public static void InitializeDbTest(IApplicationBuilder applicationBuilder)
        {
            // code to thes integration with EF core goes here
        }
    }
}

