using WalletPlus.Data.Entities;
using WalletPlus.Web.WebData.Entities;

namespace WalletPlus.Data
{
   public class seeder
    {

         public static async Task Seed(ApplicationDbContex context)
    {
        if (!context.Customers.Any())
        {

            context.Customers.Add(new Customer

            {
                FirstName = "Oladimeji",
                LastName = "Onafoye",
                MiddleName = "Emma",
                
                MaritalStatus = MaritalStatus.Single,
                DateOfBirth = DateTime.Now.AddYears(-20),
                Country = "England",
                State = "London",
                City = "Manhattan",
                Active = true,

            });
            context.Customers.Add(new Customer

            {
                FirstName = "Clara",
                LastName = "Sola",
                MiddleName = "Amirah",
              
                MaritalStatus = MaritalStatus.Single,
                DateOfBirth = DateTime.Now.AddYears(-10),
                Country = "England",
                State = "London",
                City = "Manhattan",
                Active = true,

            }
                );
            // context.SaveChangesAsync();
            await context.SaveChangesAsync();
        }

    }
    }
}

