using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Add(T item)
        {
            using var c = new Context();
            c.Set<T>().Add(item);
            c.SaveChanges();
        }

        public void Delete(T item)
        {
            using var c = new Context();
            c.Set<T>().Remove(item);
            c.SaveChanges();

        }

		public List<T> GetByFilter(Expression<Func<T, bool>> filter)
		{
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
		}

		public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Update(T item)
        {
            using var c = new Context();
            c.Set<T>().Update(item);
            c.SaveChanges();
        }
    }
}
