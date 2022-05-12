namespace Korepetycje_Matematyka.Repositories
{
    public class CRUDRepository : ICRUDRepository
    {
        private DbContextAccount _contextAccount;
        public CRUDRepository(DbContextAccount contextAccount)
        {
           _contextAccount = contextAccount ?? throw new ArgumentNullException(nameof(contextAccount));
        }
        public async Task CreateAsync(Account account)
        {
           await _contextAccount.Accounts.AddAsync(account);
            await _contextAccount.SaveChangesAsync();
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
