﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
	{
		IQueryable<TEntity> All { get; }

		IEnumerable<TEntity> Get(
            System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null,
			Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
			string includeProperties = "");

		void Insert(TEntity entity);

		void Update(TEntity entityToUpdate);

		void SetStateModified(TEntity entity);
	}
}
