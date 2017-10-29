namespace Blog.DAO
{
    using Blog.Contracts;
    using Blog.Models;
    using Blog.DAO.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private BlogContext _context;

        public UnitOfWork(BlogContext context)
        {
            this._context = context;

            this.InitializeRepositories();
        }

        private void InitializeRepositories()
        {
            this.Posts = new EntityFrameworkRepositoryBase<Post>(this._context);
            this.Tags = new EntityFrameworkRepositoryBase<Tag>(this._context);
            this.Users = new EntityFrameworkRepositoryBase<User>(this._context);
        }

        public IRepository<Post> Posts { get; set; }

        public IRepository<Tag> Tags { get; set; }

        public IRepository<User> Users { get; set; }

        public void Complete()
        {
            this._context.SaveChanges();
        }
    }
}
