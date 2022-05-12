namespace Korepetycje_Matematyka
{
    public class CRUDRepository : ICRUDRepository
    {
        public Task CreateAsync(Account account)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Account>> GetAllAsync()
        {
            throw new NotImplementedException();
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
