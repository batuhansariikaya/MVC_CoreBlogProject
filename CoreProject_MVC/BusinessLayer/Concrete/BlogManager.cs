using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;
        

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
       
        public Blog GetByID(int id)
        {
           return _blogDal.TGetByID(id);
        }
        public List<Blog> GetBlogByID(int id)
		{
            return _blogDal.GetListAll(x => x.BlogID == id);
		}

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

		public List<Blog> GetListBlogWithCategoryName()
		{
            return _blogDal.GetListWithCategoryName().OrderByDescending(x => x.BlogID).Take(10).ToList();
		}
      public List<Blog> CategoryNameListByWriter(int  id)
        {
            return _blogDal.GetListWithCategoryNameByWriter(id);
        }
      
        public List<Blog> GetBlogListWithWriter(int id)
		{
            
            return _blogDal.GetListAll(x => x.WriterID == id);
		}

        public void TAdd(Blog t)
        {
			
		
                _blogDal.Insert(t);
            
           
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);

        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

		public List<Blog> Last3Post()
		{
            return _blogDal.GetListAll().OrderByDescending(x=>x.BlogID).Take(3).ToList();
		}
	}
}
