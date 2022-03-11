using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// DESKTOP-1AT1R42\SQLEXPRESS
			optionsBuilder.UseSqlServer("server=DESKTOP-1AT1R42\\SQLEXPRESS; database=DbCoreProject_MVC; integrated security=true;");
			
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
		public DbSet<About> Abouts { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Writer> Writers { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<NewsLetter> NewsLetters { get; set; }
		public DbSet<Message> Messages { get; set; }
		
	  

	}
}