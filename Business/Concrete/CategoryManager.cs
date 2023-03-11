using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
            return _categoryDal.GetAll();
        }

        // select * from categories where CategoryId=3
        public Category GetById(int categoryId)
        {
            //İş Kodları
            return _categoryDal.Get(c => c.CategoryId == categoryId);
            //veritabanından gelen category ıd ile dışardan verilen
            //categoryıd eşitse o category ıd bağlı verileri getir.
        }
    }
}
