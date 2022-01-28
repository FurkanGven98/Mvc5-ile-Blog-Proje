using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını boş geçemezsiniz.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama boş olamaz.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter olmalı");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Maksimum 50 karakter girebilirsiniz.");
        }
    }
}
