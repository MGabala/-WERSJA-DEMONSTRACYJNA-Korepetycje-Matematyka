using Korepetycje_Matematyka.Entitites;
using Microsoft.EntityFrameworkCore;

namespace Korepetycje_Matematyka.Db
{
    public class DbContextAccount : DbContext
    {
        public DbSet<EntitiyAccount> Accounts { get; set; } = null!;
        public DbContextAccount(DbContextOptions<DbContextAccount> options) : base(options)
        {

        }
    }
}
