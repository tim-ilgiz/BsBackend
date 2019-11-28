using bsbackend.Maps;
using Microsoft.EntityFrameworkCore;


namespace bsbackend.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Blog>().ToTable("Blog");
            base.OnModelCreating(builder);

            new BlogMap(builder.Entity<Blog>());
        }
    }
}