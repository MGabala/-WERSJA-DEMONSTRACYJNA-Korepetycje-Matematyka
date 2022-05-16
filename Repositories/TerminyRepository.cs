namespace Korepetycje_Matematyka.Repositories
{
    public class TerminyRepository : ITerminyRepository
    {
        private DbContextAccount _contextTerminy;
        public TerminyRepository(DbContextAccount contextTerminy)
        {
            _contextTerminy = contextTerminy ?? throw new ArgumentNullException(nameof(_contextTerminy));
        }
        public Task CreateAsync(Terminy account)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Terminy>> GetAllTerminyAsync()
        {
            return await _contextTerminy.Terminy.OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<Terminy?> GetOneAsync(int id)
        {
           return await _contextTerminy.Terminy.FirstOrDefaultAsync(x=>x.Id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _contextTerminy.SaveChangesAsync() >= 0);
        }

        public async Task UpdateAsync(Terminy account)
        {
            _contextTerminy.Entry(account).State = EntityState.Modified;
            _contextTerminy.SaveChanges();
        }

        public Task<bool> UserExistsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
