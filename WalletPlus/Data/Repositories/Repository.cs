using Microsoft.EntityFrameworkCore;
using WalletPlus.Data.Entities;
using WalletPlus.Web.Data.Entities;
using WalletPlus.Web.Data.Repositories.Interface;

namespace WalletPlus.Data.Repositories
{
    public class Repository<TEntity, Tkey> : IRepository<TEntity, Tkey>, IRepository<TEntity, Tkey> where TEntity : BaseClass2<Tkey>
    {

        private readonly ApplicationDbContex _CustomerRepo;

        public Repository(ApplicationDbContex customerRepo)
        {
            _CustomerRepo = customerRepo;
        }

        public async Task<List<TEntity>> GetAll()
        {
            var customer = await _CustomerRepo.Set<TEntity>().ToListAsync();
            return customer;
        }
        public async Task<TEntity> GetSingle(Tkey id)
        {
            var model = await _CustomerRepo.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));
            return model;
        }
        public async Task Create(TEntity model)
        {
            await _CustomerRepo.Set<TEntity>().AddAsync(model);
            await _CustomerRepo.SaveChangesAsync();
        }
        public async Task<TEntity> Edit(Tkey id)
        {
            var model = await _CustomerRepo.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));
            Console.Write(model);

            return model;
        }
        public async Task Delete(Tkey id)
        {
            var model = await _CustomerRepo.Set<TEntity>().FirstOrDefaultAsync(c => c.Id!.Equals(id));

            if (model != null)
            {
                _CustomerRepo.Set<TEntity>().Remove(model);
                await _CustomerRepo.SaveChangesAsync();
            }
        }

        public async Task Update(TEntity model)
        {
            _CustomerRepo.Set<TEntity>().Update(model);

            await _CustomerRepo.SaveChangesAsync();
        }

        public Task<IEnumerable<TEntity>> Get(string filter)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(Tkey id)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}