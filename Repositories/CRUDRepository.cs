namespace Korepetycje_Matematyka.Repositories
{
    public class CRUDRepository : ICRUDRepository
    {
        private DbContextAccount _contextAccount;
        public CRUDRepository(DbContextAccount contextAccount)
        {
           _contextAccount = contextAccount ?? throw new ArgumentNullException(nameof(contextAccount));
        }
        public Task CreateAsync(Account account)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            return await _contextAccount.Accounts.OrderBy(x => x.Id).ToListAsync();
        }

        public Task<Account?> GetOneAsync(int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsAsync(int phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
