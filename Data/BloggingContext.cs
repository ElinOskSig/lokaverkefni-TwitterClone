namespace TwitterClone10.Data
{
    using Microsoft.EntityFrameworkCore;
    using TwitterClone10.Models.TwitterClone_Elin.Models;

    namespace TwitterClone_Elin.Data
    {
        public class BloggingContext : DbContext
        {

            public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
            {

            }

            public DbSet<Post> Post { get; set; }

        }
    }
}

