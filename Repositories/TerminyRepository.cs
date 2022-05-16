namespace Korepetycje_Matematyka.Repositories
{
    public class TerminyRepository : ITerminyRepository
    {
        private DbContextAccount _contextAccount;
        public TerminyRepository(DbContextAccount contextAccount)
        {
            _contextAccount = contextAccount ?? throw new ArgumentNullException(nameof(contextAccount));
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
            return await _contextAccount.Terminy.OrderBy(x => x.Id).ToListAsync();
        }

        public Task<Terminy?> GetOneAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Terminy account)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
