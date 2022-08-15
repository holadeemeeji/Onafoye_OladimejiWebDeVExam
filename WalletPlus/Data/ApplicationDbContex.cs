using Microsoft.EntityFrameworkCore;
using WalletPlus.Data.Configuration;
using WalletPlus.Web.WebData.Entities;

namespace WalletPlus.Data
{
    public class ApplicationDbContex: DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
