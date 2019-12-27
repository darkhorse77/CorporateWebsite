using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CorporateWebsite.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public DbSet<ContentModule> ContentModules { get; set; }
        public DbSet<ModuleSection> ModuleSections { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
