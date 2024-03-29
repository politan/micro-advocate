﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MicroAdvocate.Persistence.Database.Entities;

namespace MicroAdvocate.Persistence.Database.Repositories
{
    public interface IRepository<TEntity, in TIdentity>
        where TEntity : IIdentity<TIdentity>
        where TIdentity : struct
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(TIdentity id);
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TIdentity id);
    }
}