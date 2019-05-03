
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain;
using Microsoft.EntityFrameworkCore;

 
namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ArtAdvisorContext artAdvisorcontext { get; set; }
 
        public RepositoryBase(ArtAdvisorContext artAdvisorcontext)
        {
            this.artAdvisorcontext = artAdvisorcontext;
        }
 
        public IEnumerable<T> FindAll()
        {
            return this.artAdvisorcontext.Set<T>();
        }
 
        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.artAdvisorcontext.Set<T>().Where(expression);
        }
 
        public void Create(T entity)
        {
            this.artAdvisorcontext.Set<T>().Add(entity);
        }
 
        public void Update(T entity)
        {
            this.artAdvisorcontext.Entry(entity).State = EntityState.Modified;
        }
 
        public void Delete(T entity)
        {
            this.artAdvisorcontext.Set<T>().Remove(entity);
        }
        public void Save()
        {
            this.artAdvisorcontext.SaveChanges();
        }
    }
}