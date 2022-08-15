using WalletPlus.Data.Entities;

namespace WalletPlus.Data.Repositories
{
    public interface IRepository<TEntity, Tkey> where TEntity : BaseClass2<Tkey>
    {
        Task<Guid> Add(TEntity entity);
        Task Create(TEntity model);
        Task Delete(Tkey id);
        Task<TEntity> Edit(Tkey id);
        Task<IEnumerable<TEntity>> Get(string filter);
        Task<TEntity> Get(Tkey id);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetSingle(Tkey id);
        Task Update(TEntity model);
    }
}