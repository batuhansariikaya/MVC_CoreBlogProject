using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;
using X.PagedList.Web.Common;
using X.PagedList.Mvc.Core.Fluent;
using X.PagedList.Mvc.Core;
using X.PagedList.Mvc;
using Microsoft.AspNetCore.Authorization;
using DataAccessLayer.Concrete;

namespace CoreProject_MVC.Controllers
{
	[AllowAnonymous]
	public class BlogController : Controller
	{
		
		BlogManager blogManager = new BlogManager(new EfBlogRepository());
		CommentManager cm = new CommentManager(new EfCommentRepository());
		CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
		Context context = new Context();
		public IActionResult Index(int page=1)
		{
			var blogList = blogManager.GetListBlogWithCategoryName().ToPagedList(page,6);	
			return View(blogList);
		}
		public IActionResult BlogDetail(int id)
		{
			/*  blog detay  sayfasinda o bloga ait yorum sayisi    */			
			var blogID = context.Comments.Where(x=>x.BlogID==id).Select(y => y.CommentID).Count();
			ViewBag.blogcomment = blogID;
			/* finish*/

			/* bloga ait kategori adi    */
			var categoryName = context.Blogs.Where(x => x.BlogID == id).Select(y => y.Category.CategoryName).FirstOrDefault();
			ViewBag.category = categoryName;

			//var blogDetail = blogManager.GetListBlogWithCategoryName();

			/* kategori sayıları */
			/* yazarin diger yazilari*/
			//var writer = context.Blogs.Where(x => x.BlogID == id).Select(z => z.WriterID).;
			//ViewBag.writerid = writer;


			ViewBag.i = id;
			var blogDetail = blogManager.GetBlogByID(id);
			return View(blogDetail);
		}
		
		

	}
}
