using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        List<Product> GetAll();

        List<Product> GetAllCategoryId(int id);

        List<Product> GetByUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();
        void Add(Product product);
    }
}
