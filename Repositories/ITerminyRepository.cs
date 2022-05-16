namespace Korepetycje_Matematyka.Repositories
{
    public interface ITerminyRepository
    {
        public Task<IEnumerable<Terminy>> GetAllTerminyAsync();
        public Task<Terminy?> GetOneAsync(int id);
        public Task<bool> UserExistsAsync(int id);
        public Task<bool> SaveChangesAsync();
        public Task DeleteAsync(int id);
        public Task CreateAsync(Terminy account);
        public Task UpdateAsync(Terminy account);
    }
}
