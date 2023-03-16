using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

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
                return new ErrorResult(Messages.ProductNameInvalid);

            }
             _productDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);        }

        public IResult Delete(Product product)
        {
            
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Product>> GetAll()
        {
            // İş Kodları
            //Yetkisi Varmı

            if (DateTime.Now.Hour==22)
            {
                return new ErrorResult(false,Messages.ProductNameInvalid);
            }

            return new DataResult<List<Product>>(_productDal.GetAll(),true,Messages.ProductListed);

        }

        public IDataResult<List<Product>> GetAllCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdate);
        }
    }
}
