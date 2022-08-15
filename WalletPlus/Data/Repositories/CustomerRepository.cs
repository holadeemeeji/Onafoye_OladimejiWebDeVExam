using WalletPlus.Web.WebData.Entities;

namespace WalletPlus.Data.Repositories
{
    public class CustomerRepo : Repository<Customer, Guid>
    {
        public CustomerRepo(ApplicationDbContex dbContext) : base(dbContext)
    {

    }
}
}
