namespace Blog.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The blog user
    /// </summary>
    public class User
    {
        /// <summary>
        /// The unique identifier of the blog user
        /// Used by the database and the ORM
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The blog user's username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The blog user's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The blog user's password hash.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// The blog user's posts
        /// </summary>
        public IEnumerable<Post> Posts { get; set; }
    }
}
