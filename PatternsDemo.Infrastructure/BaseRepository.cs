using Microsoft.EntityFrameworkCore;
using PatternsDemo.IInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternsDemo.Infrastructure
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly PatternDemoDBContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;

        public BaseRepository(PatternDemoDBContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
