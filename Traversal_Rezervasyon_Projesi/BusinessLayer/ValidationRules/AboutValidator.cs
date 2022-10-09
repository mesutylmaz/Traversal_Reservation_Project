using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısımını boş geçemezsiniz!");
            RuleFor(x=>x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz!");
            RuleFor(x => x.Description).MinimumLength(1).WithMessage("Açıklama alanına en az 1 karakter girişi yapmalısınız!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("Açıklama alanına en fazla 1500 karakter girişi yapabilirsiniz!");
        }
    }
}
