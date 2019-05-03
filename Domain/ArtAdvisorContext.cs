using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class ArtAdvisorContext : DbContext
    {
        public ArtAdvisorContext(DbContextOptions<ArtAdvisorContext> options) : base(options) { }

        public DbSet<ArtAdvisorUser> Users { get; set; }
        public DbSet<UserRelationship> UsersRelationsips { get; set; }
        public DbSet<Museum> Museums { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ArtPiece> ArtPieces { get; set; } 
        public DbSet<Translation> Translations { get; set; }
    }
}