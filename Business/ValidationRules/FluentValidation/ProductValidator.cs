using Entities.Concrete;
using FluentValidation;
using System;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();//boş olamaz
            RuleFor(p => p.ProductName).MinimumLength(2);//2 karakterden az olamaz
            RuleFor(p => p.UnitPrice).NotEmpty();//boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0); //0 dan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //category ıdsı 1 olan ların unit price 10'dan büyük olmalı
            RuleFor(p => p.ProductName).Must(StartWithA);
            //must(uymalı), ürün ismi A ile başlamalı
            //Cross Cuting Console
        }

        private bool StartWithA(string arg) // true yada false döner
        {
            return arg.StartsWith("A");
        }
    }
}
