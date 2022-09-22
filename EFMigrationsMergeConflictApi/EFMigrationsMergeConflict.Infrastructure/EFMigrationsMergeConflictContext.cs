using EFMigrationsMergeConflictApi.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace EFMigrationsMergeConflictApi.Infrastructure
{
    public class EFMigrationsMergeConflictContext : DbContext
    {
        public EFMigrationsMergeConflictContext(DbContextOptions<EFMigrationsMergeConflictContext> options)
    : base(options)
        {
        }

        public DbSet<Blog> Blogs => Set<Blog>();
    }
}
