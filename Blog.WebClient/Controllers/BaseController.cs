namespace Blog.WebClient.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Blog.Contracts;

    public abstract class BaseController : Controller
    {
        public BaseController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IUnitOfWork unitOfWork { get; private set; }
    }
}