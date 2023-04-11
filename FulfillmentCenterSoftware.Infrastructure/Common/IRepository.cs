using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FulfillmentCenterSoftware.Infrastructure.Common
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string? includeProperties = null);
        IEnumerable<T> GetAll(string? includeProperties = null);
        void Add(T entity);
        void Remove(T entity);
        void IsActive(T entity);
        void RemoveRange(IEnumerable<T> entity);

    }
}
