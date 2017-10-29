namespace Blog.ConsoleClient
{
    using Blog.DAO;
    using Blog.Models;
    using System;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            using (var blogContext = new BlogContext())
            {
                //blogContext.Posts.Add(new Post() { Name = "Test" });

                //blogContext.SaveChanges();

                Console.WriteLine(blogContext.Posts.ToList());
            }
        }
    }
}
