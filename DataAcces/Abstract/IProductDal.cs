using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{

    //Product ile yapacağım işlemler burda imzalanır
    public interface IProductDal:IEntityRepository<Product>
    {

        List<ProductDetailDto> GetProductDetails();

    }
}

//Code ReFactoring