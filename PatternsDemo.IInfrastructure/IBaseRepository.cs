using System.Collections.Generic;

namespace PatternsDemo.IInfrastructure
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}
