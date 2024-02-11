using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.GuideValidate
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen Rehber Adını Giriniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Rehber Açıklamasını Giriniz");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen 30 karakterden az veri girişi yapın.");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("Lütfen 8 karakterden uzun bir isim Girin");
        }
    }
}
