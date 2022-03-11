using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_CoreProject.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class WriterController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
		Context context = new Context();
		public IActionResult Index()
        {
			
            return View();
        }
       
        public IActionResult WriterBlogs(int id)
        {
			//var blogID = context.Comments.Where(x => x.BlogID == id).Select(y => y.CommentID).Count();
			//ViewBag.blogcomment = blogID;
			var userMail = User.Identity.Name;			
			var writerID = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
			var writerBlogs = blogManager.CategoryNameListByWriter(writerID);
            return View(writerBlogs);
        }
		[HttpGet]
		public IActionResult BlogAdd()
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
			List<SelectListItem> categoryList = (from x in categoryManager.GetList()
												 select new SelectListItem
												 {
													 Text = x.CategoryName,
													 Value = x.CategoryID.ToString()


												 }).ToList();
			ViewBag.cv = categoryList;
			return View();
		}
		[HttpPost]
		public IActionResult BlogAdd(Blog blog)
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
			List<SelectListItem> categoryList = (from x in categoryManager.GetList()
												 select new SelectListItem
												 {
													 Text = x.CategoryName,
													 Value = x.CategoryID.ToString()


												 }).ToList();
			ViewBag.cv = categoryList;
			var userMail = User.Identity.Name;			
			Context context = new Context();
			var writerID = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID ).FirstOrDefault();
			BlogValidator validator = new BlogValidator();
			ValidationResult result = validator.Validate(blog);
			if (result.IsValid)
			{
				blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				blog.BlogStatus = true;
				blog.WriterID = writerID;
				//blog.CategoryID = int.Parse(categoryList.ToString());
				blogManager.TAdd(blog);
				return RedirectToAction("WriterBlogs", "Writer", "Areas");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		
		}
		[HttpGet]
		public IActionResult BlogEdit(int id)
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
			List<SelectListItem> categoryList = (from x in categoryManager.GetList()
												 select new SelectListItem
												 {
													 Text = x.CategoryName,
													 Value = x.CategoryID.ToString()


												 }).ToList();
			ViewBag.cv = categoryList;
			List<SelectListItem> statusList = new List<SelectListItem>();
			statusList.Add(new SelectListItem
			{
				Text = "Aktif",
				Value = "1",
				Selected=true
			});
			statusList.Add(new SelectListItem
			{
				Text = "Pasif",
				Value = "0",
				Selected=true
			});
			ViewBag.status = statusList;
			var blogValues = blogManager.GetByID(id);
			return View(blogValues);
		}
		[HttpPost]
		public IActionResult BlogEdit(Blog blog) 
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
			List<SelectListItem> categoryList = (from x in categoryManager.GetList()
												 select new SelectListItem
												 {
													 Text = x.CategoryName,
													 Value = x.CategoryID.ToString()


												 }).ToList();
			ViewBag.cv = categoryList;
			List<SelectListItem> statusList = new List<SelectListItem>();
			statusList.Add(new SelectListItem
			{
				Text = "Aktif",
				Value = "1"
			});
			statusList.Add(new SelectListItem
			{
				Text = "Pasif",
				Value = "0"
			});
			ViewBag.status = statusList;
			blogManager.TUpdate(blog);
			return RedirectToAction("WriterBlogs","Writer");
		}
		public IActionResult BlogDelete(int id)
		{
			var delete=blogManager.GetByID(id);
			blogManager.TDelete(delete);
			return RedirectToAction("WriterBlogs","Writer","Areas");
		}
		
	

	}
}
