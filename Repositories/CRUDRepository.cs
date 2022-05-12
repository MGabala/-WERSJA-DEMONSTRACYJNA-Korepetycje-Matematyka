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

        public async Task DeleteAsync(int id)
        {
          var delete = await _contextAccount.Accounts.FirstOrDefaultAsync(x=>x.Id == id);
         _contextAccount.Accounts.Remove(delete);
           _contextAccount.SaveChanges();
        }

        public async Task<IEnumerable<Account>> GetAllAsync()
        {
            return await _contextAccount.Accounts.OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<Account?> GetOneAsync(int id)
        {
            return await _contextAccount.Accounts.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExistsAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
