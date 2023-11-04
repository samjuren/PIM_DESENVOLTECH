using Microsoft.EntityFrameworkCore;

namespace PIM_DESENVOLTECH.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Login> Login { get; set; }
    }
}
