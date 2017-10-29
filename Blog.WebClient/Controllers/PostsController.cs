namespace Blog.WebClient.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Blog.Models;
    using Blog.Contracts;

    [Produces("application/json")]
    [Route("api/v1/Posts")]
    public class PostsController : BaseController
    {
        public PostsController(IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
        }

        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return this.unitOfWork.Posts.GetAll();
        }
    }
}