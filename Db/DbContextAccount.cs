
namespace Korepetycje_Matematyka.Db
{
    public class DbContextAccount : DbContext
    {
        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Terminy> Terminy { get; set; } = null!;
        public DbContextAccount(DbContextOptions<DbContextAccount> options) : base(options)
        {

        }
    }
}
