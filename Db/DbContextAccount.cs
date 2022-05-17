
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Korepetycje_Matematyka.Db
{
    public class DbContextAccount : IdentityDbContext<IdentityUser>
    {
        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<Terminy> Terminy { get; set; } = null!;
        public DbContextAccount(DbContextOptions<DbContextAccount> options) : base(options)
        {

        }

    }
}