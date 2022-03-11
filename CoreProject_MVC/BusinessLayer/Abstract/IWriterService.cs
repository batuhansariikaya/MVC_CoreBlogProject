using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public  interface IWriterService:IGenericService<Writer>
	{
		List<Writer> GetListWriterInfo(int id);  // yazarın bilgilerini getirme
		List<Writer> GetListLastWriter();   // son yazar getirme
  	}
}
