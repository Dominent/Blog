namespace Blog.DAO
{
    using Blog.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The blog application database context
    /// Used intereacting with entity framework models
    /// </summary>
    public class BlogContext : DbContext
    {
        /// <summary>
        /// Represents the table Posts
        /// </summary>
        public DbSet<Post> Posts { get; set; }

        /// <summary>
        /// Represents the table Tags
        /// </summary>
        public DbSet<Tag> Tags { get; set; }

        /// <summary>
        /// Represents the table Users
        /// </summary>
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Blog;Trusted_Connection=True;");
        }
    }
}
