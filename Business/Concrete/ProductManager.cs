using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService

    {
        IProductDal _productDal;
        //Injection
        public ProductManager(IProductDal productDal)
        {

            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //Business Code,
            if (product.ProductName.Length<2)
            {
                return new ErrorResult("Ürün ismi en az 2 karakter olmalıdır");

            }
             _productDal.Add(product);
            return new Result(true,"ürün Eklendi");
        }

        public List<Product> GetAll()
        {
            // İş Kodları
            //Yetkisi Varmı

            return _productDal.GetAll();
        }

        public List<Product> GetAllCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
