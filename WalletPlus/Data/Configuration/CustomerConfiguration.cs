using Microsoft.EntityFrameworkCore;
using WalletPlus.Web.Data.Entities;

namespace WalletPlus.Data.Configuration
{
    public class CustomerConfiguration
    {
        public static ModelBuilder Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("first_name");
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.PhoneNo).HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(c => c.Email).HasMaxLength(256);

            modelBuilder.Entity<Customer>().HasIndex(c => c.PhoneNo).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();

            return modelBuilder;
        }
    }
}
