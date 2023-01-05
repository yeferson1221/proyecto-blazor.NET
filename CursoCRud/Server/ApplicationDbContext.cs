using CursoCRud.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoCRud.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            : base(options)
        {
            
        }

        public DbSet<Persona> personas { get; set; }
    }
}
