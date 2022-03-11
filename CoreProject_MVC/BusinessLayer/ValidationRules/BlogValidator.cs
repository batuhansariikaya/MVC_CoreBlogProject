using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class BlogValidator:AbstractValidator<Blog>
	{
		public BlogValidator()
		{
			RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez").Length(5,50).WithMessage("Başlık 5 ile 50 karakter arasında olmalıdır!");
			RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriği Boş Geçilemez");
			RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Resim Boş Geçilemez");
			RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Blog Resim Boş Geçilemez");
			

		}
	}
}
