using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProject_MVC.Controllers
{
	public class CommentController : Controller
	{
		CommentManager commentManager = new CommentManager(new EfCommentRepository());
		BlogManager blogManager = new BlogManager(new EfBlogRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			ViewBag.i1 = id;			
			var commentList = commentManager.GetList(id);
			return PartialView(commentList);
		}
		[HttpGet]
		public PartialViewResult AddComment(int id)
		{
			var blogComment=blogManager.GetByID(id);
			ViewBag.commentıd = blogComment;
			return PartialView(blogComment);
		}
		[HttpPost]
		public PartialViewResult AddComment(Comment comment)
		{
			//comment.BlogID =2;	
			
			comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			comment.CommentStatus = true;
			commentManager.TAdd(comment);
			return PartialView();
		}
	}
}
