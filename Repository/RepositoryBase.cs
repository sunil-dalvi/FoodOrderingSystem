using FoodOrderingSystem.Contracts;
using FoodOrderingSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FoodOrderingSystem.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected FoodOrderingDBContext FoodOrderingDBContext { get; set; }
        public RepositoryBase(FoodOrderingDBContext context)
        {
            this.FoodOrderingDBContext = context;
        }
        public IQueryable<T> FindAll()
        {
            return this.FoodOrderingDBContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.FoodOrderingDBContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            this.FoodOrderingDBContext.Set<T>().Add(entity);
            this.FoodOrderingDBContext.SaveChanges();

        }
        public void Update(T entity)
        {
            this.FoodOrderingDBContext.Set<T>().Update(entity);
            this.FoodOrderingDBContext.SaveChanges();
        }
        public void Delete(T entity)
        {
            this.FoodOrderingDBContext.Set<T>().Remove(entity);
            this.FoodOrderingDBContext.SaveChanges();
        }
    }
}
