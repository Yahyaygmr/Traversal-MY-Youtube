using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AboutValidate
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Geçilemez!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En Az 50 Karakter!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("En Fazla 1500 Karakter!");
        }
    }
}
