namespace Blog.Models
{
    using System;

    /// <summary>
    /// The tag is a keyword which references a blog post
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Default constructor, used by ORM
        /// Initializes the CreatedAt to the current datetime
        /// </summary>
        public Tag()
        {
            this.CreatedAt = new DateTime();
        }

        /// <summary>
        /// The unique identifier of the blog post tag
        /// Used by the database and the ORM
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the blog post tag
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date at which the blog post tag was created
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
