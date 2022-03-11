using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public  class WriterValidator:AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
			RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
			RuleFor(x => x.WriterPassword2).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
			RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Bu alan boş bırakılamaz");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter veri girişi yapınız");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter veri girişi yapabilirsiniz");
			RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Geçerli e-posta girişi yapınız.");
			//	RuleFor(x => x.WriterPassword)
			//.NotEmpty().WithMessage("Parola alanı boş geçilemez!")
			// .Must(IsPasswordValid).WithMessage("Parolanız en az sekiz karakter, en az bir harf ve bir sayı içermelidir!");


			//}
			//private bool IsPasswordValid(string arg)
			//{
			//	Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
			//	return regex.IsMatch(arg);



			// yazar kayıt işlemi yaparken eger sifreler eslesmiyorsa kaydolmama 
			RuleFor(x => x.WriterPassword).Equal(x => x.WriterPassword2).WithMessage("Şifreler Eşleşmiyor");
		}
	}
}
