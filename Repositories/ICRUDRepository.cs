namespace Korepetycje_Matematyka.Repositories
{
    public interface ICRUDRepository
    {
        public Task<IEnumerable<Account>> GetAllAsync();
        public Task<Account?> GetOneAsync(int phoneNumber);
        Task<bool> UserExistsAsync(int phoneNumber);
        Task<bool> SaveChangesAsync();
        Task DeleteAsync(int phoneNumber);
        Task CreateAsync(Account account);
    }
}
