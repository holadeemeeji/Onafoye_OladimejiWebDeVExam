
using WalletPlus.Data.Entities;
using WalletPlus.Web.Data.Entities;

namespace WalletPlus.Web.Data.Repositories.Interface
{
    public interface IRepository<TEntity, TKey> where TEntity : BaseEntities<TKey>
    {
        Task<IEnumerable<TEntity>> Get(string filter);

        Task<TEntity> Get(TKey id);

        Task<Guid> Add(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TKey id);
        Task GetAll();
        Task GetSingle(Guid id);
    }
}
