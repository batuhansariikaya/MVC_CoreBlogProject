using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace EntityLayer.Concrete
{
	public class AppUser: IdentityUser<int>
	{
		public string NameSurname { get; set; }
		public string ImageURL { get; set; }
	}
}
