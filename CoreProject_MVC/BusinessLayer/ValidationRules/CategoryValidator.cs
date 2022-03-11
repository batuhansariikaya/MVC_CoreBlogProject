using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class CategoryValidator:AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Geçilemez!");
			RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kategori Adı Minimum 2 Karakter Olmalıdır.");
			RuleFor(x => x.CategoryName).MaximumLength(10).WithMessage("Kategori Adı Maksimum 10 Karakter Olmalıdır.");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori Açıklaması Boş Geçilemez!");
			RuleFor(x => x.CategoryDescription).MaximumLength(15).WithMessage("Kategori Açıklaması Maksimum 15 Karakter Olmalıdır!");
			RuleFor(x => x.CategoryDescription).MinimumLength(5).WithMessage("Kategori Açıklaması Minimum 5 Karakter Olmalıdır!");

		}
	}
}
