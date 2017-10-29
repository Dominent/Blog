//--------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityFrameworkRepositoryBase{T}.cs" author="Petromil "Dominent" Pavlov>
//     Copyright (c) Petromil "Dominent" Pavlov. All rights reserved.
// </copyright>
//--------------------------------------------------------------------------------------------------------------------

namespace Blog.DAO.Repositories
{
    using Blog.Contracts;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    /// <summary>
    /// Base class implementation of Repository pattern.
    /// </summary>
    /// <typeparam name="T">Concrete implementation of Repository pattern.</typeparam>
    public class EntityFrameworkRepositoryBase<T> : IRepository<T> where T : class
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="EfReposiotyBase{T}"/> class.
        /// </summary>
        /// <param name="context">The application database context.</param>
        public EntityFrameworkRepositoryBase(BlogContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException();
            }

            this.Context = context;
            this.DBSet = context.Set<T>();
        }

        protected DbSet<T> DBSet { get; private set; }
        protected DbContext Context { get; private set; }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return this.DBSet.FirstOrDefault(filter);
        }

        public T Get(object id)
        {
            return this.DBSet.Find(id);
        }

        public TResult Get<TResult>(Expression<Func<T, TResult>> selector)
        {
            return this.DBSet.Select(selector).FirstOrDefault();
        }

        /// <summary>
        /// Gets all corresponding entities from the Database.
        /// </summary>
        /// <returns>A <see cref="IEnumerable{T}"/> of entities.</returns>
        public IEnumerable<T> GetAll()
        {
            return this.DBSet.ToList();
        }

        public IEnumerable<TResult> GetAll<TResult>(Expression<Func<T, TResult>> selector)
        {
            return this.DBSet.Select(selector).ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return this.DBSet.Where(filter).ToList();
        }

        public IEnumerable<TResult> GetAll<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            return this.DBSet.Where(filter).Select(selector).ToList();
        }

        public IEnumerable<T> GetAll<TKey>(Expression<Func<T, bool>> filter, Expression<Func<T, TKey>> orderBy, int offset, int fetch)
        {
            var start = offset * fetch;
            var end = start + fetch;

            return this.DBSet.Where(filter).OrderBy(orderBy).Skip(start).Take(end).ToList();
        }

        /// <summary>
        /// Adds an entity into the database.
        /// </summary>
        /// <param name="entity">The entity that will be inserted.</param>
        public void Add(T entity)
        {
            var entry = this.Context.Entry(entity);

            entry.State = EntityState.Added;
        }

        /// <summary>
        /// Updates an entity.
        /// Attaches the entity to the DbSet and changes the entity state to modified.
        /// </summary>
        /// <param name="entity">The entity that will be updated.</param>
        public void Update(T entity)
        {
            var entry = this.Context.Entry(entity);

            entry.State = EntityState.Modified;
        }

        /// <summary>
        /// Removes an entity from the database.
        /// Sets the state of the entity to detached and removes it from the Database./>
        /// </summary>
        /// <param name="entity">The entity which will be removed.</param>
        public void Delete(T entity)
        {
            var entry = this.Context.Entry(entity);

            entry.State = EntityState.Deleted;
        }
    }
}

