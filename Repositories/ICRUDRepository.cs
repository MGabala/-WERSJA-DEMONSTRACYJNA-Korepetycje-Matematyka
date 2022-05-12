namespace Korepetycje_Matematyka.Repositories
{
    public interface ICRUDRepository
    {
        public Task<IEnumerable<Account>> GetAllAsync();
        public Task<Account?> GetOneAsync(int id);
        Task<bool> UserExistsAsync(int id);
        Task<bool> SaveChangesAsync();
        Task DeleteAsync(int id);
        Task CreateAsync(Account account);
    }
}
