using Core.DataAccess.EntityFramework;
using DataAcces.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Concrete.EntityFramework
{

    
    //NuGet
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {

        //NorthwindContext northwindContext = new NorthwindContext();
            
       
    }
}
