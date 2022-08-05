﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator: AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel adı boş geçilemez");
            RuleFor(x => x.ImageUrlView).NotEmpty().WithMessage("Görsel2 adı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat adı boş geçilemez");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Deper adı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az5 karakter olmalı.");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı en fazla 100 karakter olmalı.");

        }
    }
}
