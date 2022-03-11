using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		Context context = new Context();

		public void Delete(T t)
		{
			context.Remove(t);
			context.SaveChanges();
		}

		public T TGetByID(int id)
		{
			return context.Set<T>().Find(id);

		}

		public List<T> GetListAll()
		{
			return context.Set<T>().ToList();
		}

		public void Insert(T t)
		{
			context.Add(t);
			context.SaveChanges();
		}

		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
			return context.Set<T>().Where(filter).ToList();	 
		}

		public void Update(T t)
		{
			context.Update(t);
			context.SaveChanges();
		}
	}
}
