using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SystemZarzadzaniaProjektami.Models;

namespace SystemZarzadzaniaProjektami.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SystemZarzadzaniaProjektami.Models.Project> Project { get; set; } = default!;
        public DbSet<SystemZarzadzaniaProjektami.Models.ProjectTask> ProjectTask { get; set; } = default!;
    }
}
