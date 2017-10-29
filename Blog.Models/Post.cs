namespace Blog.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The blog post
    /// </summary>
    public class Post
    {
        /// <summary>
        /// Default constructor, used by ORM
        /// Initializes the CreatedAt to the current datetime
        /// </summary>
        public Post()
        {
            this.CreatedAt = DateTime.Now;
        }

        /// <summary>
        /// The unique identifier of the blog post
        /// Used by the database and the ORM
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the blog post
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The content of the blog post
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The date at which the blog post was created
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The blog post tags
        /// Used for searching and finding the desired blog post
        /// </summary>
        public IEnumerable<Tag> Tags { get; set; }
    }
}
