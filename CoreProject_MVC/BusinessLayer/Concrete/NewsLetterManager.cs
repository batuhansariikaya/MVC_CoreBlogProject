using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetter;

		public NewsLetterManager(INewsLetterDal newsLetter)
		{
			_newsLetter = newsLetter;
		}

        public NewsLetter GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
		{
			throw new NotImplementedException();
		}

        public void TAdd(NewsLetter t)
        {
            _newsLetter.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
