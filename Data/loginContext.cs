using login.Models; // นำเข้า namespace ของ User
using Microsoft.EntityFrameworkCore;

namespace login.Data
{
    public class loginContext : DbContext
    {
        public loginContext(DbContextOptions<loginContext> options)
            : base(options)
        {
        }

        public DbSet<users> users { get; set; }
    }
}
