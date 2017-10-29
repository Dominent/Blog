//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository{T}.cs" author="Petromil "Dominent" Pavlov>
//     Copyright (c) Petromil "Dominent" Pavlov. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------------------------------------------------

namespace Blog.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IRepository<T> where T : class
    {
        T Get(object id);

        T Get(Expression<Func<T, bool>> filter);

        TResult Get<TResult>(Expression<Func<T, TResult>> selector);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter);

        IEnumerable<TResult> GetAll<TResult>(Expression<Func<T, TResult>> selector);

        IEnumerable<TResult> GetAll<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector);

        IEnumerable<T> GetAll<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> orderBy, int offset, int fetch);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
