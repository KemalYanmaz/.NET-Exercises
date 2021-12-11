using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün İsmi Boş Olamaz.");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Kategori Id Boş Olamaz.");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Birim Fiyat Boş Olamaz.");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Birim Adeti Boş Olamaz.");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Stoktaki Ürün Adeti Boş Olamaz.");
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Birim Fiyat 0'dan Büyük Olmalıdır.");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0).WithMessage("Stoktaki Ürün Adeti 0'dan Küçük Olamaz.");
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p=>p.CategoryId==2).WithMessage("2 Kategori Id'li Ürünlerde Birim Fiyat 10'dan büyük olmalıdır.");
            RuleFor(p => p.ProductName).Must(StartsWithB).When(p=>p.CategoryId==2).WithMessage("2 Kategori ID'li Ürünlerde Ürün Adı 'B' ile başlamalıdır.");
        }
        private bool StartsWithB(string arg)
        {
            return arg.StartsWith("B");
        }
    }
}
