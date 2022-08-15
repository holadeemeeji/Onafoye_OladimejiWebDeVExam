using WalletPlus.Data;
using WalletPlus.Data.Repositories;
using WalletPlus.Web.WebData.Entities;

namespace WalletPlus.Web.Data.Repositories
{
    public class CountryRepository : Repository<Country, Guid>
    {
        public CountryRepository(ApplicationDbContex dbContext) : base(dbContext)
        {

        }
    }

}
