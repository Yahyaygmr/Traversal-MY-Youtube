using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AppUserValidate
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(u => u.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez.");
            RuleFor(u => u.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez.");
            RuleFor(u => u.Email).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez.");
            RuleFor(u => u.UserName).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez.");
            RuleFor(u => u.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez.");
            RuleFor(u => u.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrarı Alanı Boş Geçilemez.");

            RuleFor(u => u.UserName).MinimumLength(5).WithMessage("Lüfen En Az 5 Karakter Giriniz");
            RuleFor(u => u.UserName).MaximumLength(20).WithMessage("Lüfen En Fazla 20 Karakter Giriniz");

            RuleFor(u => u.Password).Equal(u => u.ConfirmPassword).WithMessage("Şifreler Uyuşmuyor.");

        }
    }
}
