using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
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

        public List<Product> GetAll()
        {
            // İş Kodları
            //Yetkisi Varmı

            return _productDal.GetAll();
        }
    }
}
