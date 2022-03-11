using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;

		public List<Category> GetCategoryListCount(int id)
		{
			return _categoryDal.GetCategoryCount(id).ToList();
		}
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		

		public Category GetByID(int id)
		{
			return _categoryDal.TGetByID(id);
		}

		

		public List<Category> GetList()
		{
			return _categoryDal.GetListAll();
		}

		public List<Category> GetListMaxBlog()
		{
			throw new NotImplementedException();
		}

		public void TAdd(Category t)
        {
			_categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
			_categoryDal.Delete(t);
		}

        public void TUpdate(Category t)
        {
			_categoryDal.Update(t);
		}
    }
}
