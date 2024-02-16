using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidate
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementUpdateDto>
    {
        public AnnouncementUpdateValidator()
        {
            RuleFor(a => a.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin");
            RuleFor(a => a.Content).NotEmpty().WithMessage("Lütfen duyuru içeriğini boş geçmeyin");

            RuleFor(a => a.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız");
            RuleFor(a => a.Content).MinimumLength(5).WithMessage("Lütfen en az 20 karakter veri girişi yapınız");

            RuleFor(a => a.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapınız");
            RuleFor(a => a.Content).MaximumLength(500).WithMessage("Lütfen en fazla 500 karakter veri girişi yapınız");
        }
    }
}
