using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RapeCrisisCounsellorSystem.Models;

namespace RapeCrisisCounsellorSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RapeCrisisCounsellorSystem.Models.Counsellor>? Counsellor { get; set; }
        public DbSet<RapeCrisisCounsellorSystem.Models.Schedule>? Schedule { get; set; }
    }
}