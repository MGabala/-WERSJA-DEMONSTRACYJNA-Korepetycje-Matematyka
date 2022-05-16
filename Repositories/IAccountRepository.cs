namespace Korepetycje_Matematyka.Repositories
{
    public interface IAccountRepository
    {
        public Task<IEnumerable<Account>> GetAllAsync();
        public Task<Account?> GetOneAsync(int id);
        public Task<bool> UserExistsAsync(int id);
        public Task<bool> SaveChangesAsync();
        public Task DeleteAsync(int id);
        public Task CreateAsync(Account account);
        public Task UpdateAsync(Account account);
    }
}
