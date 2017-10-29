//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository{T}.cs" author="Petromil "Dominent" Pavlov>
//     Copyright (c) Petromil "Dominent" Pavlov. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------------------------------------------------

namespace Blog.Contracts
{
    using Blog.Models;

    public interface IUnitOfWork
    {
        IRepository<Post> Posts { get; set; }

        IRepository<Tag> Tags { get; set; }

        IRepository<User> Users { get; set; }

        void Complete();
    }
}
