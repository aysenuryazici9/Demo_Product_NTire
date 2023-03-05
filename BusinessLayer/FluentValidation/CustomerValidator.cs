using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kullanıcı adı boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Kullanıcı adı en az 3 karakter olmalıdır!");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi boş geçilemez!");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir bilgisi en az 3 karakter olmalıdır!");
        }
    }
}
