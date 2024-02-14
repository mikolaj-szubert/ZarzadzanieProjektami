using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZarzadzanieProjektami.Models;

namespace ZarzadzanieProjektami.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ZarzadzanieProjektami.Models.Project> Project { get; set; } = default!;
        public DbSet<ZarzadzanieProjektami.Models.ProjectTask> ProjectTask { get; set; } = default!;
    }
}
